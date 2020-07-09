namespace CSP
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.constM = new System.Windows.Forms.NotifyIcon(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pageCheck = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.pageInput = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.inputString = new System.Windows.Forms.TextBox();
            this.btn_del = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inputName = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.pageSearch = new System.Windows.Forms.TabPage();
            this.btnName = new System.Windows.Forms.Button();
            this.btnTime = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.master = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.stuList = new System.Windows.Forms.Button();
            this.stuAdd = new System.Windows.Forms.Button();
            this.stuDel = new System.Windows.Forms.Button();
            this.notList = new System.Windows.Forms.Button();
            this.notAdd = new System.Windows.Forms.Button();
            this.notDel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.pageCheck.SuspendLayout();
            this.pageInput.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pageSearch.SuspendLayout();
            this.master.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // constM
            // 
            this.constM.Text = "학생 노트북 주말대여 시스템";
            this.constM.Visible = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(439, 301);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pageCheck);
            this.tabControl1.Controls.Add(this.pageInput);
            this.tabControl1.Controls.Add(this.pageSearch);
            this.tabControl1.Controls.Add(this.master);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(439, 269);
            this.tabControl1.TabIndex = 1;
            // 
            // pageCheck
            // 
            this.pageCheck.Controls.Add(this.textBox1);
            this.pageCheck.Controls.Add(this.label1);
            this.pageCheck.Controls.Add(this.btnCheck);
            this.pageCheck.Location = new System.Drawing.Point(4, 22);
            this.pageCheck.Name = "pageCheck";
            this.pageCheck.Padding = new System.Windows.Forms.Padding(3);
            this.pageCheck.Size = new System.Drawing.Size(431, 243);
            this.pageCheck.TabIndex = 0;
            this.pageCheck.Text = "대여 확인";
            this.pageCheck.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(416, 21);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "학생 번호를 입력하세요";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(304, 49);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(121, 48);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "대여 여부 확인";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // pageInput
            // 
            this.pageInput.Controls.Add(this.groupBox2);
            this.pageInput.Controls.Add(this.groupBox1);
            this.pageInput.Location = new System.Drawing.Point(4, 22);
            this.pageInput.Name = "pageInput";
            this.pageInput.Padding = new System.Windows.Forms.Padding(3);
            this.pageInput.Size = new System.Drawing.Size(431, 243);
            this.pageInput.TabIndex = 1;
            this.pageInput.Text = "대여 신청/취소";
            this.pageInput.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.inputString);
            this.groupBox2.Controls.Add(this.btn_del);
            this.groupBox2.Location = new System.Drawing.Point(10, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 92);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "대여 취소";
            // 
            // inputString
            // 
            this.inputString.Enabled = false;
            this.inputString.Location = new System.Drawing.Point(6, 20);
            this.inputString.Name = "inputString";
            this.inputString.Size = new System.Drawing.Size(406, 21);
            this.inputString.TabIndex = 0;
            this.inputString.Text = "학생번호-노트북 번호";
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(282, 47);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(130, 39);
            this.btn_del.TabIndex = 2;
            this.btn_del.Text = "대여 취소";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inputName);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 92);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "대여 신청";
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(6, 20);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(406, 21);
            this.inputName.TabIndex = 0;
            this.inputName.Text = "학생번호-노트북 번호";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(282, 47);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(130, 39);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "대여 신청";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // pageSearch
            // 
            this.pageSearch.Controls.Add(this.btnName);
            this.pageSearch.Controls.Add(this.btnTime);
            this.pageSearch.Controls.Add(this.btnAll);
            this.pageSearch.Location = new System.Drawing.Point(4, 22);
            this.pageSearch.Name = "pageSearch";
            this.pageSearch.Size = new System.Drawing.Size(431, 243);
            this.pageSearch.TabIndex = 2;
            this.pageSearch.Text = "대여 조회";
            this.pageSearch.UseVisualStyleBackColor = true;
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(298, 59);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(120, 120);
            this.btnName.TabIndex = 2;
            this.btnName.Text = "이름 조회";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // btnTime
            // 
            this.btnTime.Location = new System.Drawing.Point(158, 59);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(120, 120);
            this.btnTime.TabIndex = 1;
            this.btnTime.Text = "기간 조회";
            this.btnTime.UseVisualStyleBackColor = true;
            this.btnTime.Click += new System.EventHandler(this.btnTime_Click);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(17, 59);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(120, 120);
            this.btnAll.TabIndex = 0;
            this.btnAll.Text = "전체 조회";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // master
            // 
            this.master.Controls.Add(this.textBox2);
            this.master.Controls.Add(this.label2);
            this.master.Controls.Add(this.groupBox4);
            this.master.Controls.Add(this.groupBox3);
            this.master.Location = new System.Drawing.Point(4, 22);
            this.master.Name = "master";
            this.master.Size = new System.Drawing.Size(431, 243);
            this.master.TabIndex = 3;
            this.master.Text = "학생 관리";
            this.master.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.stuDel);
            this.groupBox3.Controls.Add(this.stuAdd);
            this.groupBox3.Controls.Add(this.stuList);
            this.groupBox3.Location = new System.Drawing.Point(4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(424, 96);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "학생 관리";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.notDel);
            this.groupBox4.Controls.Add(this.notAdd);
            this.groupBox4.Controls.Add(this.notList);
            this.groupBox4.Location = new System.Drawing.Point(4, 106);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(424, 96);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "노트북 관리";
            // 
            // stuList
            // 
            this.stuList.Location = new System.Drawing.Point(38, 15);
            this.stuList.Name = "stuList";
            this.stuList.Size = new System.Drawing.Size(100, 75);
            this.stuList.TabIndex = 0;
            this.stuList.Text = "학생 목록";
            this.stuList.UseVisualStyleBackColor = true;
            this.stuList.Click += new System.EventHandler(this.stuList_Click);
            // 
            // stuAdd
            // 
            this.stuAdd.Location = new System.Drawing.Point(166, 15);
            this.stuAdd.Name = "stuAdd";
            this.stuAdd.Size = new System.Drawing.Size(100, 75);
            this.stuAdd.TabIndex = 1;
            this.stuAdd.Text = "학생 추가";
            this.stuAdd.UseVisualStyleBackColor = true;
            this.stuAdd.Click += new System.EventHandler(this.stuAdd_Click);
            // 
            // stuDel
            // 
            this.stuDel.Location = new System.Drawing.Point(289, 15);
            this.stuDel.Name = "stuDel";
            this.stuDel.Size = new System.Drawing.Size(100, 75);
            this.stuDel.TabIndex = 2;
            this.stuDel.Text = "학생 제거";
            this.stuDel.UseVisualStyleBackColor = true;
            this.stuDel.Click += new System.EventHandler(this.stuDel_Click);
            // 
            // notList
            // 
            this.notList.Location = new System.Drawing.Point(38, 16);
            this.notList.Name = "notList";
            this.notList.Size = new System.Drawing.Size(100, 75);
            this.notList.TabIndex = 1;
            this.notList.Text = "노트북 목록";
            this.notList.UseVisualStyleBackColor = true;
            this.notList.Click += new System.EventHandler(this.notList_Click);
            // 
            // notAdd
            // 
            this.notAdd.Location = new System.Drawing.Point(166, 18);
            this.notAdd.Name = "notAdd";
            this.notAdd.Size = new System.Drawing.Size(100, 75);
            this.notAdd.TabIndex = 2;
            this.notAdd.Text = "노트북 추가";
            this.notAdd.UseVisualStyleBackColor = true;
            this.notAdd.Click += new System.EventHandler(this.notAdd_Click);
            // 
            // notDel
            // 
            this.notDel.Location = new System.Drawing.Point(289, 18);
            this.notDel.Name = "notDel";
            this.notDel.Size = new System.Drawing.Size(100, 75);
            this.notDel.TabIndex = 3;
            this.notDel.Text = "노트북 제거";
            this.notDel.UseVisualStyleBackColor = true;
            this.notDel.Click += new System.EventHandler(this.notDel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "선택된 항목의 번호";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(123, 210);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(302, 21);
            this.textBox2.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 601);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "학생 노트북 주말대여 시스템";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.pageCheck.ResumeLayout(false);
            this.pageCheck.PerformLayout();
            this.pageInput.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pageSearch.ResumeLayout(false);
            this.master.ResumeLayout(false);
            this.master.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon constM;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pageCheck;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TabPage pageInput;
        private System.Windows.Forms.TabPage pageSearch;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.Button btnTime;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.TabPage master;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox inputString;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button notDel;
        private System.Windows.Forms.Button notAdd;
        private System.Windows.Forms.Button notList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button stuDel;
        private System.Windows.Forms.Button stuAdd;
        private System.Windows.Forms.Button stuList;
    }
}

