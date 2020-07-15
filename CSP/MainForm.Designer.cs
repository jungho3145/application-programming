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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.notDel = new System.Windows.Forms.Button();
            this.notAdd = new System.Windows.Forms.Button();
            this.notList = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.stuDel = new System.Windows.Forms.Button();
            this.stuAdd = new System.Windows.Forms.Button();
            this.stuList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.pageCheck.SuspendLayout();
            this.pageInput.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pageSearch.SuspendLayout();
            this.master.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(24, 576);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(815, 602);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pageCheck);
            this.tabControl1.Controls.Add(this.pageInput);
            this.tabControl1.Controls.Add(this.pageSearch);
            this.tabControl1.Controls.Add(this.master);
            this.tabControl1.Location = new System.Drawing.Point(24, 26);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(815, 538);
            this.tabControl1.TabIndex = 1;
            // 
            // pageCheck
            // 
            this.pageCheck.Controls.Add(this.textBox1);
            this.pageCheck.Controls.Add(this.label1);
            this.pageCheck.Controls.Add(this.btnCheck);
            this.pageCheck.Location = new System.Drawing.Point(8, 39);
            this.pageCheck.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pageCheck.Name = "pageCheck";
            this.pageCheck.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pageCheck.Size = new System.Drawing.Size(799, 491);
            this.pageCheck.TabIndex = 0;
            this.pageCheck.Text = "대여 확인";
            this.pageCheck.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 44);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(769, 35);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "학생 번호를 입력하세요";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(565, 98);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(225, 96);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "대여 여부 확인";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // pageInput
            // 
            this.pageInput.Controls.Add(this.groupBox2);
            this.pageInput.Controls.Add(this.groupBox1);
            this.pageInput.Location = new System.Drawing.Point(8, 39);
            this.pageInput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pageInput.Name = "pageInput";
            this.pageInput.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pageInput.Size = new System.Drawing.Size(799, 491);
            this.pageInput.TabIndex = 1;
            this.pageInput.Text = "대여 신청/취소";
            this.pageInput.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.inputString);
            this.groupBox2.Controls.Add(this.btn_del);
            this.groupBox2.Location = new System.Drawing.Point(19, 210);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(776, 184);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "대여 취소";
            // 
            // inputString
            // 
            this.inputString.Enabled = false;
            this.inputString.Location = new System.Drawing.Point(11, 40);
            this.inputString.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.inputString.Name = "inputString";
            this.inputString.Size = new System.Drawing.Size(751, 35);
            this.inputString.TabIndex = 0;
            this.inputString.Text = "학생번호-노트북 번호";
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(524, 94);
            this.btn_del.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(241, 78);
            this.btn_del.TabIndex = 2;
            this.btn_del.Text = "대여 취소";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inputName);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(776, 184);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "대여 신청";
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(11, 40);
            this.inputName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(751, 35);
            this.inputName.TabIndex = 0;
            this.inputName.Text = "학생번호-노트북 번호";
            this.inputName.TextChanged += new System.EventHandler(this.inputName_TextChanged);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(524, 94);
            this.btn_add.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(241, 78);
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
            this.pageSearch.Location = new System.Drawing.Point(8, 39);
            this.pageSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pageSearch.Name = "pageSearch";
            this.pageSearch.Size = new System.Drawing.Size(799, 491);
            this.pageSearch.TabIndex = 2;
            this.pageSearch.Text = "대여 조회";
            this.pageSearch.UseVisualStyleBackColor = true;
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(553, 118);
            this.btnName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(223, 240);
            this.btnName.TabIndex = 2;
            this.btnName.Text = "이름 조회";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // btnTime
            // 
            this.btnTime.Location = new System.Drawing.Point(293, 118);
            this.btnTime.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(223, 240);
            this.btnTime.TabIndex = 1;
            this.btnTime.Text = "기간 조회";
            this.btnTime.UseVisualStyleBackColor = true;
            this.btnTime.Click += new System.EventHandler(this.btnTime_Click);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(32, 118);
            this.btnAll.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(223, 240);
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
            this.master.Location = new System.Drawing.Point(8, 39);
            this.master.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.master.Name = "master";
            this.master.Size = new System.Drawing.Size(799, 491);
            this.master.TabIndex = 3;
            this.master.Text = "학생 관리";
            this.master.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(228, 420);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(557, 35);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 430);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "선택된 항목의 번호";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.notDel);
            this.groupBox4.Controls.Add(this.notAdd);
            this.groupBox4.Controls.Add(this.notList);
            this.groupBox4.Location = new System.Drawing.Point(7, 212);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox4.Size = new System.Drawing.Size(787, 192);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "노트북 관리";
            // 
            // notDel
            // 
            this.notDel.Location = new System.Drawing.Point(537, 36);
            this.notDel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.notDel.Name = "notDel";
            this.notDel.Size = new System.Drawing.Size(186, 150);
            this.notDel.TabIndex = 3;
            this.notDel.Text = "노트북 제거";
            this.notDel.UseVisualStyleBackColor = true;
            this.notDel.Click += new System.EventHandler(this.notDel_Click);
            // 
            // notAdd
            // 
            this.notAdd.Location = new System.Drawing.Point(308, 36);
            this.notAdd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.notAdd.Name = "notAdd";
            this.notAdd.Size = new System.Drawing.Size(186, 150);
            this.notAdd.TabIndex = 2;
            this.notAdd.Text = "노트북 추가";
            this.notAdd.UseVisualStyleBackColor = true;
            this.notAdd.Click += new System.EventHandler(this.notAdd_Click);
            // 
            // notList
            // 
            this.notList.Location = new System.Drawing.Point(71, 32);
            this.notList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.notList.Name = "notList";
            this.notList.Size = new System.Drawing.Size(186, 150);
            this.notList.TabIndex = 1;
            this.notList.Text = "노트북 목록";
            this.notList.UseVisualStyleBackColor = true;
            this.notList.Click += new System.EventHandler(this.notList_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.stuDel);
            this.groupBox3.Controls.Add(this.stuAdd);
            this.groupBox3.Controls.Add(this.stuList);
            this.groupBox3.Location = new System.Drawing.Point(7, 8);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox3.Size = new System.Drawing.Size(787, 192);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "학생 관리";
            // 
            // stuDel
            // 
            this.stuDel.Location = new System.Drawing.Point(537, 30);
            this.stuDel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.stuDel.Name = "stuDel";
            this.stuDel.Size = new System.Drawing.Size(186, 150);
            this.stuDel.TabIndex = 2;
            this.stuDel.Text = "학생 제거";
            this.stuDel.UseVisualStyleBackColor = true;
            this.stuDel.Click += new System.EventHandler(this.stuDel_Click);
            // 
            // stuAdd
            // 
            this.stuAdd.Location = new System.Drawing.Point(308, 30);
            this.stuAdd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.stuAdd.Name = "stuAdd";
            this.stuAdd.Size = new System.Drawing.Size(186, 150);
            this.stuAdd.TabIndex = 1;
            this.stuAdd.Text = "학생 추가";
            this.stuAdd.UseVisualStyleBackColor = true;
            this.stuAdd.Click += new System.EventHandler(this.stuAdd_Click);
            // 
            // stuList
            // 
            this.stuList.Location = new System.Drawing.Point(71, 30);
            this.stuList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.stuList.Name = "stuList";
            this.stuList.Size = new System.Drawing.Size(186, 150);
            this.stuList.TabIndex = 0;
            this.stuList.Text = "학생 목록";
            this.stuList.UseVisualStyleBackColor = true;
            this.stuList.Click += new System.EventHandler(this.stuList_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 1202);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
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

