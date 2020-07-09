namespace CSP
{
    partial class login
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
            this.groupDB = new System.Windows.Forms.GroupBox();
            this.loginDB = new System.Windows.Forms.Button();
            this.getPw = new System.Windows.Forms.TextBox();
            this.getId = new System.Windows.Forms.TextBox();
            this.getIp = new System.Windows.Forms.TextBox();
            this.label_PW = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label_ip = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.getDBname = new System.Windows.Forms.TextBox();
            this.labelDBname = new System.Windows.Forms.Label();
            this.groupDB.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupDB
            // 
            this.groupDB.Controls.Add(this.loginDB);
            this.groupDB.Controls.Add(this.getPw);
            this.groupDB.Controls.Add(this.getId);
            this.groupDB.Controls.Add(this.getIp);
            this.groupDB.Controls.Add(this.label_PW);
            this.groupDB.Controls.Add(this.label_id);
            this.groupDB.Controls.Add(this.label_ip);
            this.groupDB.Location = new System.Drawing.Point(13, 12);
            this.groupDB.Name = "groupDB";
            this.groupDB.Size = new System.Drawing.Size(457, 147);
            this.groupDB.TabIndex = 1;
            this.groupDB.TabStop = false;
            this.groupDB.Text = "DB 연결";
            // 
            // loginDB
            // 
            this.loginDB.Location = new System.Drawing.Point(276, 65);
            this.loginDB.Name = "loginDB";
            this.loginDB.Size = new System.Drawing.Size(181, 71);
            this.loginDB.TabIndex = 6;
            this.loginDB.Text = "접속";
            this.loginDB.UseVisualStyleBackColor = true;
            this.loginDB.Click += new System.EventHandler(this.loginDB_Click_1);
            // 
            // getPw
            // 
            this.getPw.Location = new System.Drawing.Point(6, 115);
            this.getPw.Name = "getPw";
            this.getPw.Size = new System.Drawing.Size(255, 21);
            this.getPw.TabIndex = 5;
            // 
            // getId
            // 
            this.getId.Location = new System.Drawing.Point(7, 75);
            this.getId.Name = "getId";
            this.getId.Size = new System.Drawing.Size(255, 21);
            this.getId.TabIndex = 4;
            // 
            // getIp
            // 
            this.getIp.Location = new System.Drawing.Point(7, 36);
            this.getIp.Name = "getIp";
            this.getIp.Size = new System.Drawing.Size(255, 21);
            this.getIp.TabIndex = 3;
            // 
            // label_PW
            // 
            this.label_PW.AutoSize = true;
            this.label_PW.Location = new System.Drawing.Point(7, 100);
            this.label_PW.Name = "label_PW";
            this.label_PW.Size = new System.Drawing.Size(45, 12);
            this.label_PW.TabIndex = 2;
            this.label_PW.Text = "DB-PW";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(7, 60);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(38, 12);
            this.label_id.TabIndex = 1;
            this.label_id.Text = "DB-ID";
            // 
            // label_ip
            // 
            this.label_ip.AutoSize = true;
            this.label_ip.Location = new System.Drawing.Point(7, 20);
            this.label_ip.Name = "label_ip";
            this.label_ip.Size = new System.Drawing.Size(58, 12);
            this.label_ip.TabIndex = 0;
            this.label_ip.Text = "Server-IP";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 175);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(454, 29);
            this.progressBar1.TabIndex = 2;
            // 
            // getDBname
            // 
            this.getDBname.Location = new System.Drawing.Point(289, 49);
            this.getDBname.Name = "getDBname";
            this.getDBname.Size = new System.Drawing.Size(178, 21);
            this.getDBname.TabIndex = 6;
            // 
            // labelDBname
            // 
            this.labelDBname.AutoSize = true;
            this.labelDBname.Location = new System.Drawing.Point(287, 33);
            this.labelDBname.Name = "labelDBname";
            this.labelDBname.Size = new System.Drawing.Size(63, 12);
            this.labelDBname.TabIndex = 6;
            this.labelDBname.Text = "DB-NAME";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 216);
            this.ControlBox = false;
            this.Controls.Add(this.labelDBname);
            this.Controls.Add(this.getDBname);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupDB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.groupDB.ResumeLayout(false);
            this.groupDB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupDB;
        private System.Windows.Forms.TextBox getPw;
        private System.Windows.Forms.TextBox getId;
        private System.Windows.Forms.TextBox getIp;
        private System.Windows.Forms.Label label_PW;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_ip;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button loginDB;
        private System.Windows.Forms.TextBox getDBname;
        private System.Windows.Forms.Label labelDBname;
    }
}