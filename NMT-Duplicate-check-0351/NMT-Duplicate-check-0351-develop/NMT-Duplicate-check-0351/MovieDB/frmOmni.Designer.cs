namespace JigQuick
{
    partial class frmOmni
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOmni));
            this.pnlResult1 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.lbProcess = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProduct1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAssembly = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProduct2 = new System.Windows.Forms.TextBox();
            this.btnReset2 = new System.Windows.Forms.Button();
            this.lblResult2 = new System.Windows.Forms.Label();
            this.txtResultDetail2 = new System.Windows.Forms.TextBox();
            this.txtResultDetail1 = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnlResult2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCounter = new System.Windows.Forms.Label();
            this.Version_lbl = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.ComboBox();
            this.ckbModel = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlResult1
            // 
            this.pnlResult1.BackColor = System.Drawing.Color.White;
            this.pnlResult1.Location = new System.Drawing.Point(21, 234);
            this.pnlResult1.Margin = new System.Windows.Forms.Padding(4);
            this.pnlResult1.Name = "pnlResult1";
            this.pnlResult1.Size = new System.Drawing.Size(380, 322);
            this.pnlResult1.TabIndex = 52;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(9, 4);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(147, 34);
            this.btnReset.TabIndex = 59;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lbProcess
            // 
            this.lbProcess.AutoSize = true;
            this.lbProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProcess.Location = new System.Drawing.Point(149, 207);
            this.lbProcess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbProcess.Name = "lbProcess";
            this.lbProcess.Size = new System.Drawing.Size(103, 24);
            this.lbProcess.TabIndex = 61;
            this.lbProcess.Text = "HOUSING";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(55, 133);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 20);
            this.lblResult.TabIndex = 2;
            this.lblResult.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 42);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Housing Serial";
            // 
            // txtProduct1
            // 
            this.txtProduct1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtProduct1.Location = new System.Drawing.Point(5, 82);
            this.txtProduct1.Margin = new System.Windows.Forms.Padding(4);
            this.txtProduct1.Name = "txtProduct1";
            this.txtProduct1.Size = new System.Drawing.Size(341, 30);
            this.txtProduct1.TabIndex = 1;
            this.txtProduct1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProduct1_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtProduct1);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.lblResult);
            this.panel1.Location = new System.Drawing.Point(24, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 162);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtAssembly);
            this.groupBox2.Controls.Add(this.panel8);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.txtResultDetail2);
            this.groupBox2.Controls.Add(this.txtResultDetail1);
            this.groupBox2.Controls.Add(this.panel6);
            this.groupBox2.Controls.Add(this.pnlResult2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lbProcess);
            this.groupBox2.Controls.Add(this.pnlResult1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(-4, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1571, 683);
            this.groupBox2.TabIndex = 68;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "NTRS CHECK: HOUSING + MOVER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(996, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 24);
            this.label4.TabIndex = 77;
            this.label4.Text = "Link Barcode";
            // 
            // txtAssembly
            // 
            this.txtAssembly.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssembly.Location = new System.Drawing.Point(1000, 69);
            this.txtAssembly.Margin = new System.Windows.Forms.Padding(4);
            this.txtAssembly.Multiline = true;
            this.txtAssembly.Name = "txtAssembly";
            this.txtAssembly.ReadOnly = true;
            this.txtAssembly.Size = new System.Drawing.Size(489, 132);
            this.txtAssembly.TabIndex = 76;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel8.Controls.Add(this.label3);
            this.panel8.Controls.Add(this.txtProduct2);
            this.panel8.Controls.Add(this.btnReset2);
            this.panel8.Controls.Add(this.lblResult2);
            this.panel8.Location = new System.Drawing.Point(503, 41);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(375, 160);
            this.panel8.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mover Serial";
            // 
            // txtProduct2
            // 
            this.txtProduct2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtProduct2.Location = new System.Drawing.Point(9, 82);
            this.txtProduct2.Margin = new System.Windows.Forms.Padding(4);
            this.txtProduct2.Name = "txtProduct2";
            this.txtProduct2.Size = new System.Drawing.Size(349, 30);
            this.txtProduct2.TabIndex = 1;
            this.txtProduct2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProduct2_KeyDown);
            // 
            // btnReset2
            // 
            this.btnReset2.BackColor = System.Drawing.Color.White;
            this.btnReset2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset2.Location = new System.Drawing.Point(9, 4);
            this.btnReset2.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset2.Name = "btnReset2";
            this.btnReset2.Size = new System.Drawing.Size(133, 34);
            this.btnReset2.TabIndex = 59;
            this.btnReset2.Text = "Reset";
            this.btnReset2.UseVisualStyleBackColor = false;
            this.btnReset2.Click += new System.EventHandler(this.btnReset2_Click);
            // 
            // lblResult2
            // 
            this.lblResult2.AutoSize = true;
            this.lblResult2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult2.Location = new System.Drawing.Point(51, 133);
            this.lblResult2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult2.Name = "lblResult2";
            this.lblResult2.Size = new System.Drawing.Size(0, 20);
            this.lblResult2.TabIndex = 2;
            this.lblResult2.Visible = false;
            // 
            // txtResultDetail2
            // 
            this.txtResultDetail2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResultDetail2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtResultDetail2.Location = new System.Drawing.Point(503, 575);
            this.txtResultDetail2.Margin = new System.Windows.Forms.Padding(4);
            this.txtResultDetail2.Multiline = true;
            this.txtResultDetail2.Name = "txtResultDetail2";
            this.txtResultDetail2.ReadOnly = true;
            this.txtResultDetail2.Size = new System.Drawing.Size(433, 78);
            this.txtResultDetail2.TabIndex = 75;
            this.txtResultDetail2.Tag = "1";
            // 
            // txtResultDetail1
            // 
            this.txtResultDetail1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResultDetail1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtResultDetail1.Location = new System.Drawing.Point(20, 575);
            this.txtResultDetail1.Margin = new System.Windows.Forms.Padding(4);
            this.txtResultDetail1.Multiline = true;
            this.txtResultDetail1.Name = "txtResultDetail1";
            this.txtResultDetail1.ReadOnly = true;
            this.txtResultDetail1.Size = new System.Drawing.Size(421, 78);
            this.txtResultDetail1.TabIndex = 75;
            this.txtResultDetail1.Tag = "1";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(1000, 234);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(380, 322);
            this.panel6.TabIndex = 53;
            // 
            // pnlResult2
            // 
            this.pnlResult2.BackColor = System.Drawing.Color.White;
            this.pnlResult2.Location = new System.Drawing.Point(503, 234);
            this.pnlResult2.Margin = new System.Windows.Forms.Padding(4);
            this.pnlResult2.Name = "pnlResult2";
            this.pnlResult2.Size = new System.Drawing.Size(380, 322);
            this.pnlResult2.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1109, 207);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 24);
            this.label5.TabIndex = 61;
            this.label5.Text = "JUDGE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(653, 207);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 61;
            this.label1.Text = "MOVER";
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounter.ForeColor = System.Drawing.Color.Blue;
            this.lblCounter.Location = new System.Drawing.Point(1179, 70);
            this.lblCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(37, 39);
            this.lblCounter.TabIndex = 62;
            this.lblCounter.Text = "0";
            // 
            // Version_lbl
            // 
            this.Version_lbl.AutoSize = true;
            this.Version_lbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Version_lbl.Location = new System.Drawing.Point(19, 48);
            this.Version_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Version_lbl.Name = "Version_lbl";
            this.Version_lbl.Size = new System.Drawing.Size(135, 18);
            this.Version_lbl.TabIndex = 70;
            this.Version_lbl.Tag = "";
            this.Version_lbl.Text = "VERSION : 1_0_00";
            // 
            // lblModel
            // 
            this.lblModel.Enabled = false;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblModel.FormattingEnabled = true;
            this.lblModel.Location = new System.Drawing.Point(637, 28);
            this.lblModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(319, 48);
            this.lblModel.TabIndex = 73;
            this.lblModel.SelectedIndexChanged += new System.EventHandler(this.lblModel_SelectedIndexChanged);
            // 
            // ckbModel
            // 
            this.ckbModel.AutoSize = true;
            this.ckbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbModel.Location = new System.Drawing.Point(505, 36);
            this.ckbModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbModel.Name = "ckbModel";
            this.ckbModel.Size = new System.Drawing.Size(120, 36);
            this.ckbModel.TabIndex = 74;
            this.ckbModel.Text = "Model";
            this.ckbModel.UseVisualStyleBackColor = true;
            this.ckbModel.CheckedChanged += new System.EventHandler(this.CkbModel_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1156, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 76;
            this.label2.Text = "TOTAL:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1592, 842);
            this.panel3.TabIndex = 77;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 152);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1590, 688);
            this.panel4.TabIndex = 78;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1588, 685);
            this.panel5.TabIndex = 76;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.groupBox2);
            this.panel7.Location = new System.Drawing.Point(4, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1579, 683);
            this.panel7.TabIndex = 70;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Version_lbl);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblModel);
            this.panel2.Controls.Add(this.ckbModel);
            this.panel2.Controls.Add(this.lblCounter);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1590, 152);
            this.panel2.TabIndex = 77;
            // 
            // frmOmni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1592, 842);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmOmni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serial Check";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmOmni_FormClosed);
            this.Load += new System.EventHandler(this.frmInut_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlResult1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lbProcess;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProduct1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlResult2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Version_lbl;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.ComboBox lblModel;
        private System.Windows.Forms.CheckBox ckbModel;
        private System.Windows.Forms.TextBox txtResultDetail1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox txtResultDetail2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProduct2;
        private System.Windows.Forms.Button btnReset2;
        private System.Windows.Forms.Label lblResult2;
        private System.Windows.Forms.TextBox txtAssembly;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
    }
}
