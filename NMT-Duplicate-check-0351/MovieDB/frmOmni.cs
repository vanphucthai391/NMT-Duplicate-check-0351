using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Linq;
using System.Drawing;
using System.IO;
using System.Data.Linq;
using System.Globalization;
using System.Security.Permissions;
using System.Diagnostics;
using System.IO.Ports;
//test
namespace JigQuick
{
    public partial class frmOmni : Form
    {
        #region Variables
        // コンフィグファイルと、出力テキストファイルは、デスクトップの指定のフォルダに保存する
        string appconfig = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\JigQuickDesk\JigQuickApp\info.ini";
        string outPath = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\LS12 Log\";
        //string outPath = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\JigQuickDesk\ConverterTarget\";
        //string outPath2 = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\JigQuickDesk\NtrsLog\";
        string InputData = String.Empty;
        delegate void SetTextCallback(string text);
        //ＪＩＧＱＵＩＣＫ用、非ローカル変数
        bool sound;
        bool duplicate;

        //ＮＴＲＳ用、非ローカル変数
        int okCount = 0;
        int ngCount;
        int targetProcessCount = 2;

        string model;
        string targetProcessCombined;
        string headTableThisMonth = string.Empty;
        string headTableLastMonth = string.Empty;
        string headTablesubThisMonth = string.Empty;
        string headTablesubLastMonth = string.Empty;
        DataTable dtAllProcess;

        /// <summary>
        // application name that is given from caller application for displaying itself with version on login screen
        /// </summary>
        private string applicationName;
        #endregion

        public frmOmni(string applicationname)
        {
            applicationName = applicationname;

            InitializeComponent();
            dtAllProcess = new DataTable();
        }

        private void frmInut_Load(object sender, EventArgs e)
        {
            txtProduct.Select();
            lblCounter.Visible = true;
            if (lblModel.Text == "BMD_0351")
            {
                targetProcessCount = 2;
                txtResultDetail.Visible = true;
                //lbProcess.Text = "EN2 + AOI CASE RESULT";
                //if (serialPort1.IsOpen) serialPort1.Close();
            }
            string standByImagePath = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\JigQuickDesk\JigQuickApp\images\STANDBY.bmp";
            pnlResult.BackgroundImageLayout = ImageLayout.Zoom;
            pnlResult.BackgroundImage = System.Drawing.Image.FromFile(standByImagePath);
            pnlMover.BackgroundImageLayout = ImageLayout.Zoom;
            pnlMover.BackgroundImage = System.Drawing.Image.FromFile(standByImagePath);

            TfSQL tf = new TfSQL();
            //tf.getComboBoxData("select distinct model from t_serno order by model asc", ref lblModel);
            lblModel.Text = "BMD_0351";
            if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
            {

                Version deploy = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion;

                StringBuilder version = new StringBuilder();
                version.Append(applicationName + "_");
                version.Append("VERSION_");
                version.Append(deploy.Major);
                version.Append("_");
                //version.Append(deploy.Minor);
                //version.Append("_");
                version.Append(deploy.Build);
                version.Append("_");
                version.Append(deploy.Revision);

                Version_lbl.Text = version.ToString();
            }

            if (!Directory.Exists(outPath)) Directory.CreateDirectory(outPath);
        }
        private void frmOmni_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();
        }
        private void txtProduct_KeyDown(object sender, KeyEventArgs e)
        {
            //if (ckReturn.Checked == true)
            //{
            //    targetProcessCombined = "EN2-LVT";
            //}
            //else
            targetProcessCombined = "EN2-LVT,MOTOR";
            if (e.KeyCode != Keys.Enter) return;
            model = lblModel.Text;
            //txtDataReceive.Clear();
            //ImportDataToDB();
            headTableThisMonth = model.ToLower() + DateTime.Today.ToString("yyyyMM");
            headTableLastMonth = model.ToLower() + ((VBS.Right(DateTime.Today.ToString("yyyyMM"), 2) != "01") ?
                (long.Parse(DateTime.Today.ToString("yyyyMM")) - 1).ToString() : (long.Parse(DateTime.Today.ToString("yyyy")) - 1).ToString() + "12");
            TfSQL tf = new TfSQL();
            try
            {
                if (!tf.CheckTableExist(headTableLastMonth))
                {
                    headTableLastMonth = headTableThisMonth;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (txtProduct.Text == string.Empty) return;
            if (txtProduct.ReadOnly == true) return;
            if (duplicate) return;
            char part = txtProduct.Text[4];
            if (part == 'H')
            {
                bool res = ntrsScanProcess(txtProduct.Text, pnlResult, "'EN2-LVT', 'MOTOR'", txtResultDetail);
                if (!res) return;

            }
            else if (part == 'M')
            {
                bool res1 = ntrsScanProcess(txtProduct.Text, pnlMover, "'EN2-LVT', 'MOTOR'", txtMoverDetail);
                if (!res1) return;

            }
            //bool resMover = ntrsScanProcessMover(txtProduct.Text);

            if (!String.IsNullOrEmpty(txtProduct.Text) && txtProduct.TextLength == 8 && dup == 0)
            {
                lblCounter.Text = (int.Parse(lblCounter.Text) + 1).ToString();
            }
        }
        public int dup = 0;
        // Check Duplicate barcode
        private void checkDuplicate()
        {
            if (txtProduct.Text != String.Empty)// && txtProduct.Text.Length != 24)
            {
                DateTime d = DateTime.Now;
                TfSQL tf = new TfSQL();
                string ser = tf.sqlExecuteScalarString("SELECT serial_no FROM t_serno_bmd_0351 WHERE serial_no = '" + txtProduct.Text + "'");
                if (ser != txtProduct.Text)
                {
                    tf.sqlExecuteScalarString("INSERT INTO t_serno_bmd_0351(serial_no, regist_date, model) VALUES('" + txtProduct.Text + "','" + d + "','" + lblModel.Text + "')");
                    lblResult.Text = "Barcode is OK"; lblResult.ForeColor = Color.Green;

                    string okImagePath = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\JigQuickDesk\JigQuickApp\images\OK_BEAR.png";
                    dup = 0;
                    //pnlMover.BackgroundImageLayout = ImageLayout.Zoom;
                    //pnlMover.BackgroundImage = System.Drawing.Image.FromFile(okImagePath);

                    string date = DateTime.Today.AddDays(1).ToString("yyyy/MM/dd");
                    string date1 = DateTime.Today.ToString("yyyy/MM/dd");
                    string count = tf.sqlExecuteScalarString("select count(serial_no) from t_serno_bmd_0351 where regist_date > '" + date1 + "' and regist_date <= '" + date + "' and model = '" + lblModel.Text.Replace("_", "-") + "'");
                    okCount = okCount + 1;
                    lblCounter.Text = okCount.ToString();

                }
                else if (ser == txtProduct.Text)
                {
                    lblResult.Text = "Duplicate Barcode";
                    lblResult.ForeColor = Color.Red;

                    string ngImagePath = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\JigQuickDesk\JigQuickApp\images\NG_BEAR.png";
                    //string duplImagePath = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\JigQuickDesk\JigQuickApp\images\DUPLICATE.png";
                    dup = 1;
                    pnlResult.BackgroundImageLayout = ImageLayout.Zoom;
                    pnlResult.BackgroundImage = System.Drawing.Image.FromFile(ngImagePath);
                    //pnlMover.BackgroundImageLayout = ImageLayout.Zoom;
                    //pnlMover.BackgroundImage = System.Drawing.Image.FromFile(duplImagePath);
                    txtProduct.BackColor = Color.Red;
                    txtProduct.ReadOnly = true;
                    soundAlarm();
                }
            }
        }
        public string ser;        
        private void resetViewColor(ref DataGridView dgv)
        {
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                dgv.Rows[i].DefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Window);
            }
            duplicate = false;
        }

        private string aliasName = "MediaFile";
        private void soundAlarm()
        {
            string currentDir = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\JigQuickDesk\JigQuickApp\images";
            string fileName = currentDir + @"\warning.mp3";
            string cmd;

            if (sound)
            {
                cmd = "stop " + aliasName;
                mciSendString(cmd, null, 0, IntPtr.Zero);
                cmd = "close " + aliasName;
                mciSendString(cmd, null, 0, IntPtr.Zero);
                sound = false;
            }

            cmd = "open \"" + fileName + "\" type mpegvideo alias " + aliasName;
            if (mciSendString(cmd, null, 0, IntPtr.Zero) != 0) return;
            cmd = "play " + aliasName;
            mciSendString(cmd, null, 0, IntPtr.Zero);
            sound = true;
        }

        [System.Runtime.InteropServices.DllImport("winmm.dll")]
        private static extern int mciSendString(String command, StringBuilder buffer, int bufferSize, IntPtr hwndCallback);

        private string readIni(string s, string k, string cfs)
        {
            StringBuilder retVal = new StringBuilder(255);
            string section = s;
            string key = k;
            string def = String.Empty;
            int size = 255;
            //get the value from the key in section
            int strref = GetPrivateProfileString(section, key, def, retVal, size, cfs);
            return retVal.ToString();
        }

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filepath);

        private string makeSqlWhereClause(string criteria)
        {
            string sql = " where (";
            foreach (string c in criteria.Split(','))
            {
                sql += "process = " + c + " or ";
            }
            sql = VBS.Left(sql, sql.Length - 3) + ") ";
            System.Diagnostics.Debug.Print(sql);
            return sql;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string standByImagePath = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\JigQuickDesk\JigQuickApp\images\STANDBY.bmp";
            pnlResult.BackgroundImageLayout = ImageLayout.Zoom;
            pnlResult.BackgroundImage = System.Drawing.Image.FromFile(standByImagePath);
            pnlMover.BackgroundImage = Image.FromFile(standByImagePath);
            lblResult.ResetText();
            txtResultDetail.ResetText();
            txtProduct.ResetText();
            txtProduct.ResetText();
            txtProduct.ReadOnly = false;
            txtProduct.BackColor = Color.White;
            txtProduct.BackColor = Color.White;
            txtProduct.Focus();
            pnlMover.Visible = true;
        }

        public class TestResult
        {
            public string process { get; set; }
            public string judge { get; set; }
            public string inspectdate { get; set; }
        }

        public class ProcessList
        {
            public string process { get; set; }
        }

        public string sql1;

        private bool ntrsScanProcess(string id,Panel pnl1, string processSql1,TextBox txtResultDetail)
        {
            TfSQL tf = new TfSQL();
            DataTable dt = new DataTable();
            string log = string.Empty;
            string module = txtProduct.Text;
            string mdlShort = module;
            char part = module[4];
            string scanTime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");   
            switch (lblModel.Text)
            {
                default:
                    if (targetProcessCount == 2)

                        sql1 = "select process, judge, inspectdate from " +
                       "(select process, judge, max(inspectdate) as inspectdate, row_number() OVER (PARTITION BY process ORDER BY max(inspectdate) desc) as flag from (" +
                       "(select process, case when tjudge = '0' then 'PASS' else 'FAIL' end as judge, inspectdate from " + headTableThisMonth + " where process in (" + processSql1 + ") and serno = '" + mdlShort + "') union all " +
                       "(select process, case when tjudge = '0' then 'PASS' else 'FAIL' end as judge, inspectdate from " + headTableLastMonth + " where process in (" + processSql1 + ") and serno = '" + mdlShort + "')" +
                       ") d group by judge, process order by judge desc, process) b where flag = 1";
                    //else
                    //    sql1 = "select process, judge, inspectdate from " +
                    //  "(select process, judge, max(inspectdate) as inspectdate, row_number() OVER (PARTITION BY process ORDER BY max(inspectdate) desc) as flag from (" +
                    //  "(select process, case when tjudge = '0' then 'PASS' else 'FAIL' end as judge, inspectdate from " + headTableThisMonth + " where process = ('EN2-LVT') and serno = '" + mdlShort + "') union all " +
                    //  "(select process, case when tjudge = '0' then 'PASS' else 'FAIL' end as judge, inspectdate from " + headTableLastMonth + " where process = ('EN2-LVT') and serno = '" + mdlShort + "')" +
                    //  ") d group by judge, process order by judge desc, process) b where flag = 1";

                    break;
            }

            System.Diagnostics.Debug.Print(sql1);
            tf.sqlDataAdapterFillDatatableFromTesterDb(sql1, ref dt);
            txtResultDetail.ResetText();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                System.Diagnostics.Debug.Print(dt.Rows[i][0].ToString() + " " + dt.Rows[i][1].ToString() + " " + dt.Rows[i][2].ToString());

                //  txtResultDetail.Text = dt.Rows[i][1].ToString();
            }
            #region New code

            var allResults = dt.AsEnumerable().Select(r => new TestResult()
            {
                process = r.Field<string>("process"),
                judge = r.Field<string>("judge"),
                inspectdate = r.Field<DateTime>("inspectdate").ToString("yyyy/MM/dd HH:mm:ss"),
            }).ToList();
            var passResults = allResults.Where(r => r.judge == "PASS").Select(r => new ProcessList() { process = r.process }).OrderBy(r => r.process).ToList();
            foreach (var p in passResults) System.Diagnostics.Debug.Print(p.process);

            var failResults = allResults.Where(r => r.judge == "FAIL").Select(r => new ProcessList() { process = r.process }).OrderBy(r => r.process).ToList();
            List<string> process = failResults.Select(r => r.process).Except(passResults.Select(r => r.process)).ToList();
            failResults = failResults.Where(r => process.Contains(r.process)).ToList();
            foreach (var p in failResults) System.Diagnostics.Debug.Print(p.process);

            var skipResults = targetProcessCombined.Replace("'", string.Empty).Split(',').ToList().Select(r => new ProcessList() { process = r.ToString() }).OrderBy(r => r.process).ToList();
            process = skipResults.Select(r => r.process).Except(passResults.Select(r => r.process)).ToList().Except(failResults.Select(r => r.process)).ToList();
            skipResults = skipResults.Where(r => process.Contains(r.process)).ToList();
            foreach (var p in skipResults) System.Diagnostics.Debug.Print(p.process);

            string displayPass = string.Empty;
            string displayFail = string.Empty;
            string displayAll = string.Empty;   // ログ用
            List<TestResult> allLog = new List<TestResult>();
            foreach (var p in passResults)
            {
                displayPass += p.process + " ";
                allLog.Add(new TestResult { process = p.process, judge = "PASS", inspectdate = string.Empty });
            }
            displayPass = displayPass.Trim();
            foreach (var p in failResults)
            {
                displayFail += p.process + " F ";
                allLog.Add(new TestResult { process = p.process, judge = "FAIL", inspectdate = string.Empty });
            }
            foreach (var p in skipResults)
            {
                displayFail += p.process + " S ";
                allLog.Add(new TestResult { process = p.process, judge = "SKIP", inspectdate = string.Empty });
            }
            displayFail = displayFail.Trim();

            allLog = allLog.OrderBy(r => r.process).ToList();
            foreach (var p in allLog)
            {
                displayAll += (p.process + ":" + p.judge + ",");
            }
            displayAll = VBS.Left(displayAll, displayAll.Length - 1);
            #endregion

            bool result = false;
            if (passResults.Count == targetProcessCount)
            {
                string okImagePass = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\JigQuickDesk\JigQuickApp\images\OK_BEAR.png";
                pnl1.BackgroundImageLayout = ImageLayout.Zoom;
                pnl1.BackgroundImage = System.Drawing.Image.FromFile(okImagePass);
                checkDuplicate();
                result = true;
                txtProduct.SelectAll();
            }
            else
            {
                string ngImagePath = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\JigQuickDesk\JigQuickApp\images\NG_BEAR.png";
                pnl1.BackgroundImageLayout = ImageLayout.Zoom;
                pnl1.BackgroundImage = System.Drawing.Image.FromFile(ngImagePath);
                //pnlRetest.BackgroundImageLayout = ImageLayout.Zoom;
                //pnlRetest.BackgroundImage = System.Drawing.Image.FromFile(ngImagePath);
                result = true;
                txtProduct.ReadOnly = true;
                txtProduct.BackColor = Color.Red;
                soundAlarm();
            }
            log = Environment.NewLine + scanTime + "," + module + "," + displayAll;
            txtResultDetail.Text = log.Replace(",", ",  ").Replace(Environment.NewLine, string.Empty);
            try
            {
                string outFile = outPath + DateTime.Today.ToString("yyyyMMdd") + ".txt";
                if (System.IO.File.Exists(outFile))
                {
                    System.IO.File.AppendAllText(outFile, log, System.Text.Encoding.GetEncoding("UTF-8"));
                }
                else
                {
                    string header = DateTime.Today.ToString("yyyy/MM/dd") + " " + model + " " + "CHECK HOUSING + MOVER" +
                    Environment.NewLine + "SCAN TIME,PRODUCT SERIAL,TEST DETAIL";
                    System.IO.File.AppendAllText(outFile, header + log, System.Text.Encoding.GetEncoding("UTF-8"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return result;

        }
        public void transProduct(string serial)
        {
            txtProduct.Text = serial;
        }
        private void CkbModel_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbModel.Checked) lblModel.Enabled = true;
            else lblModel.Enabled = false;
        }

        private void lblModel_SelectedIndexChanged(object sender, EventArgs e)
        {

            //else if (lblModel.Text == "LS12_003P")
            //{
            //    targetProcessCount = 2;
            //    txtResultDetail.Visible = true;
            //    lbProcess.Text = "EN2 + AOI CASE RESULT";
            //    initializePort();
            //}
            //else if (lblModel.Text == "LS12_004A")
            //{
            //    targetProcessCount = 1;
            //    txtResultDetail.Visible = true;
            //    lbProcess.Text = "EN2 CHECK RESULT";
            //    initializePort();
            //}

            //else
            //{
            //    targetProcessCount = 1;
            //    txtResultDetail.Visible = false;
            //    lbProcess.Text = "EN2 CHECK RESULT";
            //    if (serialPort1.IsOpen) serialPort1.Close();
            //}
        }


        private void ImportDataToDB()
        {
            //  string no1 = "L" + cmbNo.Text;
            string barcode1 = txtProduct.Text;
            string serno1 = '"' + barcode1 + '"';
            string lot1 = '"' + "_" + DateTime.Now.ToString("yyyyMMdd") + '"';
            string model1 = '"' + lblModel.Text + '"';
            string site1 = '"' + "NCVP" + '"';
            string factory1 = '"' + "2B" + '"';
            string line1 = '"' + "L1" + '"';
            string process1 = '"' + "FINAL" + '"';
            string inspect1 = '"' + "FINAL" + '"';
            string year1 = DateTime.Now.ToString("yyyy");
            string month1 = DateTime.Now.ToString("MM");
            string date1 = DateTime.Now.ToString("dd");
            string inspectdate1 = '"' + year1 + "/" + month1 + "/" + date1 + '"';
            string inspectime1 = '"' + DateTime.Now.ToString("HH:mm:ss") + '"';
            string data1 = '"' + "0" + '"';
            string judge1 = '"' + "0" + '"';
            string status1 = " ";
            string remark1 = " ";
            string nameFile1 = DateTime.Now.ToString("yyyyMMddHHmmss") + ".LS12_003P12BFINAL.csv";
            string outFile1 = @"\\192.168.145.7\ftpin\ftpin2\ " + nameFile1 + "";
            System.IO.File.AppendAllText(outFile1, serno1 + "," + lot1 + "," + model1 + "," + site1 + "," + factory1 + "," + line1 + "," + process1 + "," + inspect1 + "," + inspectdate1 + "," + inspectime1 + "," + data1 + "," + judge1 + "," + status1 + "," + remark1);

        }
    }
}