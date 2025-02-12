namespace btlWin1
{
    partial class main
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label1 = new Label();
            grbdanhsach = new GroupBox();
            gridviewdssv = new DataGridView();
            grbchucnang = new GroupBox();
            btnCancel = new Button();
            btnSave = new Button();
            btnReset = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            grbthongtin = new GroupBox();
            dateTimePickerBirth = new DateTimePicker();
            txtPhone = new TextBox();
            label14 = new Label();
            cBoxClass = new ComboBox();
            cBoxGender = new ComboBox();
            txtGPA = new TextBox();
            label13 = new Label();
            txtBranch = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label8 = new Label();
            txtAddress = new TextBox();
            label10 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            label9 = new Label();
            txtName = new TextBox();
            label6 = new Label();
            txtStudentID = new TextBox();
            label5 = new Label();
            label2 = new Label();
            txtCount = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            cBoxFilter = new ComboBox();
            txtSearch = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label21 = new Label();
            label15 = new Label();
            cBoxGPATo = new ComboBox();
            cBoxGPAFrom = new ComboBox();
            cBoxSearchClass = new ComboBox();
            dateTimePickerBirthTo = new DateTimePicker();
            dateTimePickerBirthFrom = new DateTimePicker();
            cBoxSearch = new ComboBox();
            tabPage2 = new TabPage();
            groupBox3 = new GroupBox();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label20 = new Label();
            txtClassID = new TextBox();
            txtNumberSV = new TextBox();
            txtClassMa = new TextBox();
            txtClassName = new TextBox();
            groupBox2 = new GroupBox();
            label19 = new Label();
            groupBox1 = new GroupBox();
            btnClassRefresh = new Button();
            gridviewClass = new DataGridView();
            btnClassDel = new Button();
            btnclassadd = new Button();
            btnClassCancel = new Button();
            btnClassUpdate = new Button();
            btnClassSave = new Button();
            grbdanhsach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridviewdssv).BeginInit();
            grbchucnang.SuspendLayout();
            grbthongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridviewClass).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(445, 32);
            label1.Name = "label1";
            label1.Size = new Size(266, 41);
            label1.TabIndex = 0;
            label1.Text = "Quản Lí Sinh Viên";
            // 
            // grbdanhsach
            // 
            grbdanhsach.Controls.Add(gridviewdssv);
            grbdanhsach.Location = new Point(23, 91);
            grbdanhsach.Margin = new Padding(3, 4, 3, 4);
            grbdanhsach.Name = "grbdanhsach";
            grbdanhsach.Padding = new Padding(3, 4, 3, 4);
            grbdanhsach.Size = new Size(1490, 525);
            grbdanhsach.TabIndex = 1;
            grbdanhsach.TabStop = false;
            grbdanhsach.Text = "Danh Sách Sinh Viên";
            // 
            // gridviewdssv
            // 
            gridviewdssv.AllowUserToAddRows = false;
            gridviewdssv.AllowUserToDeleteRows = false;
            gridviewdssv.AllowUserToResizeColumns = false;
            gridviewdssv.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            gridviewdssv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            gridviewdssv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            gridviewdssv.DefaultCellStyle = dataGridViewCellStyle6;
            gridviewdssv.Dock = DockStyle.Fill;
            gridviewdssv.Location = new Point(3, 24);
            gridviewdssv.Margin = new Padding(3, 4, 3, 4);
            gridviewdssv.MultiSelect = false;
            gridviewdssv.Name = "gridviewdssv";
            gridviewdssv.ReadOnly = true;
            gridviewdssv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            gridviewdssv.RowTemplate.Height = 25;
            gridviewdssv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridviewdssv.Size = new Size(1484, 497);
            gridviewdssv.TabIndex = 0;
            gridviewdssv.CellMouseClick += gridviewdssv_CellMouseClick;
            // 
            // grbchucnang
            // 
            grbchucnang.Controls.Add(btnCancel);
            grbchucnang.Controls.Add(btnSave);
            grbchucnang.Controls.Add(btnReset);
            grbchucnang.Controls.Add(btnEdit);
            grbchucnang.Controls.Add(btnDelete);
            grbchucnang.Controls.Add(btnAdd);
            grbchucnang.Location = new Point(26, 644);
            grbchucnang.Margin = new Padding(3, 4, 3, 4);
            grbchucnang.Name = "grbchucnang";
            grbchucnang.Padding = new Padding(3, 4, 3, 4);
            grbchucnang.Size = new Size(352, 276);
            grbchucnang.TabIndex = 2;
            grbchucnang.TabStop = false;
            grbchucnang.Text = "Chức Năng";
            grbchucnang.Enter += grbchucnang_Enter;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(193, 205);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(98, 48);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(193, 123);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(98, 48);
            btnSave.TabIndex = 0;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(53, 205);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(98, 48);
            btnReset.TabIndex = 0;
            btnReset.Text = "Refresh";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(193, 37);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(98, 48);
            btnEdit.TabIndex = 0;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(53, 123);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(98, 48);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(53, 44);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(98, 48);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // grbthongtin
            // 
            grbthongtin.Controls.Add(dateTimePickerBirth);
            grbthongtin.Controls.Add(txtPhone);
            grbthongtin.Controls.Add(label14);
            grbthongtin.Controls.Add(cBoxClass);
            grbthongtin.Controls.Add(cBoxGender);
            grbthongtin.Controls.Add(txtGPA);
            grbthongtin.Controls.Add(label13);
            grbthongtin.Controls.Add(txtBranch);
            grbthongtin.Controls.Add(label12);
            grbthongtin.Controls.Add(label11);
            grbthongtin.Controls.Add(label8);
            grbthongtin.Controls.Add(txtAddress);
            grbthongtin.Controls.Add(label10);
            grbthongtin.Controls.Add(txtEmail);
            grbthongtin.Controls.Add(label7);
            grbthongtin.Controls.Add(label9);
            grbthongtin.Controls.Add(txtName);
            grbthongtin.Controls.Add(label6);
            grbthongtin.Controls.Add(txtStudentID);
            grbthongtin.Controls.Add(label5);
            grbthongtin.Location = new Point(413, 644);
            grbthongtin.Margin = new Padding(3, 4, 3, 4);
            grbthongtin.Name = "grbthongtin";
            grbthongtin.Padding = new Padding(3, 4, 3, 4);
            grbthongtin.Size = new Size(1101, 276);
            grbthongtin.TabIndex = 3;
            grbthongtin.TabStop = false;
            grbthongtin.Text = "Thông tin";
            // 
            // dateTimePickerBirth
            // 
            dateTimePickerBirth.Location = new Point(113, 197);
            dateTimePickerBirth.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerBirth.Name = "dateTimePickerBirth";
            dateTimePickerBirth.Size = new Size(109, 27);
            dateTimePickerBirth.TabIndex = 22;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(490, 44);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(239, 27);
            txtPhone.TabIndex = 21;
            txtPhone.TextAlign = HorizontalAlignment.Center;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(423, 48);
            label14.Name = "label14";
            label14.Size = new Size(36, 20);
            label14.TabIndex = 20;
            label14.Text = "SĐT";
            // 
            // cBoxClass
            // 
            cBoxClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxClass.FormattingEnabled = true;
            cBoxClass.Items.AddRange(new object[] { " " });
            cBoxClass.Location = new Point(834, 48);
            cBoxClass.Margin = new Padding(3, 4, 3, 4);
            cBoxClass.Name = "cBoxClass";
            cBoxClass.Size = new Size(239, 28);
            cBoxClass.TabIndex = 3;
            cBoxClass.SelectedIndexChanged += cBoxClass_SelectedIndexChanged;
            // 
            // cBoxGender
            // 
            cBoxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxGender.FormattingEnabled = true;
            cBoxGender.Location = new Point(303, 197);
            cBoxGender.Margin = new Padding(3, 4, 3, 4);
            cBoxGender.Name = "cBoxGender";
            cBoxGender.Size = new Size(93, 28);
            cBoxGender.TabIndex = 2;
            // 
            // txtGPA
            // 
            txtGPA.Location = new Point(834, 195);
            txtGPA.Margin = new Padding(3, 4, 3, 4);
            txtGPA.Name = "txtGPA";
            txtGPA.Size = new Size(116, 27);
            txtGPA.TabIndex = 1;
            txtGPA.TextAlign = HorizontalAlignment.Center;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(768, 195);
            label13.Name = "label13";
            label13.Size = new Size(45, 20);
            label13.TabIndex = 0;
            label13.Text = "Điểm";
            // 
            // txtBranch
            // 
            txtBranch.Location = new Point(834, 123);
            txtBranch.Margin = new Padding(3, 4, 3, 4);
            txtBranch.Name = "txtBranch";
            txtBranch.Size = new Size(239, 27);
            txtBranch.TabIndex = 1;
            txtBranch.TextAlign = HorizontalAlignment.Center;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(768, 123);
            label12.Name = "label12";
            label12.Size = new Size(53, 20);
            label12.TabIndex = 0;
            label12.Text = "Ngành";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(768, 52);
            label11.Name = "label11";
            label11.Size = new Size(34, 20);
            label11.TabIndex = 0;
            label11.Text = "Lớp";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(237, 201);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 0;
            label8.Text = "Giới tính";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(489, 197);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(239, 27);
            txtAddress.TabIndex = 1;
            txtAddress.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(423, 201);
            label10.Name = "label10";
            label10.Size = new Size(55, 20);
            label10.TabIndex = 0;
            label10.Text = "Địa chỉ";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(489, 123);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(239, 27);
            txtEmail.TabIndex = 1;
            txtEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(423, 127);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 0;
            label7.Text = "Email";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 205);
            label9.Name = "label9";
            label9.Size = new Size(76, 20);
            label9.TabIndex = 0;
            label9.Text = "Ngày Sinh";
            // 
            // txtName
            // 
            txtName.Location = new Point(113, 123);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(239, 27);
            txtName.TabIndex = 1;
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 127);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 0;
            label6.Text = "Họ Và Tên";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(113, 44);
            txtStudentID.Margin = new Padding(3, 4, 3, 4);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(151, 27);
            txtStudentID.TabIndex = 1;
            txtStudentID.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 44);
            label5.Name = "label5";
            label5.Size = new Size(95, 20);
            label5.TabIndex = 0;
            label5.Text = "Mã Sinh Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 45);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "Số Lượng";
            label2.Click += label2_Click;
            // 
            // txtCount
            // 
            txtCount.Location = new Point(99, 41);
            txtCount.Margin = new Padding(3, 4, 3, 4);
            txtCount.Name = "txtCount";
            txtCount.ReadOnly = true;
            txtCount.Size = new Size(100, 27);
            txtCount.TabIndex = 2;
            txtCount.TextAlign = HorizontalAlignment.Center;
            txtCount.TextChanged += txtCount_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._352137_sort_icon;
            pictureBox1.Location = new Point(935, 47);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._285651_search_icon;
            pictureBox2.Location = new Point(1202, 49);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(970, 52);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 5;
            label3.Text = "Lọc theo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1238, 55);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 6;
            label4.Text = "Tìm kiếm";
            label4.Click += label4_Click;
            // 
            // cBoxFilter
            // 
            cBoxFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxFilter.FormattingEnabled = true;
            cBoxFilter.Location = new Point(1038, 49);
            cBoxFilter.Margin = new Padding(3, 4, 3, 4);
            cBoxFilter.Name = "cBoxFilter";
            cBoxFilter.Size = new Size(121, 28);
            cBoxFilter.TabIndex = 7;
            cBoxFilter.SelectedIndexChanged += cBoxFilter_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(1309, 52);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(201, 27);
            txtSearch.TabIndex = 8;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(-5, 1);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1538, 975);
            tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label21);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(cBoxGPATo);
            tabPage1.Controls.Add(cBoxGPAFrom);
            tabPage1.Controls.Add(cBoxSearchClass);
            tabPage1.Controls.Add(dateTimePickerBirthTo);
            tabPage1.Controls.Add(dateTimePickerBirthFrom);
            tabPage1.Controls.Add(cBoxSearch);
            tabPage1.Controls.Add(grbchucnang);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtSearch);
            tabPage1.Controls.Add(txtCount);
            tabPage1.Controls.Add(cBoxFilter);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(grbthongtin);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(pictureBox2);
            tabPage1.Controls.Add(grbdanhsach);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(1530, 942);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Sinh Viên";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(1309, 16);
            label21.Name = "label21";
            label21.Size = new Size(62, 20);
            label21.TabIndex = 13;
            label21.Text = "Lớn hơn";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(1414, 16);
            label15.Name = "label15";
            label15.Size = new Size(66, 20);
            label15.TabIndex = 13;
            label15.Text = "Nhỏ hơn";
            // 
            // cBoxGPATo
            // 
            cBoxGPATo.FormattingEnabled = true;
            cBoxGPATo.Location = new Point(1414, 51);
            cBoxGPATo.Margin = new Padding(3, 4, 3, 4);
            cBoxGPATo.Name = "cBoxGPATo";
            cBoxGPATo.Size = new Size(95, 28);
            cBoxGPATo.TabIndex = 11;
            cBoxGPATo.SelectedIndexChanged += cBoxGPATo_SelectedIndexChanged;
            // 
            // cBoxGPAFrom
            // 
            cBoxGPAFrom.FormattingEnabled = true;
            cBoxGPAFrom.Location = new Point(1309, 51);
            cBoxGPAFrom.Margin = new Padding(3, 4, 3, 4);
            cBoxGPAFrom.Name = "cBoxGPAFrom";
            cBoxGPAFrom.Size = new Size(98, 28);
            cBoxGPAFrom.TabIndex = 12;
            cBoxGPAFrom.SelectedIndexChanged += cBoxGPAFrom_SelectedIndexChanged;
            // 
            // cBoxSearchClass
            // 
            cBoxSearchClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxSearchClass.FormattingEnabled = true;
            cBoxSearchClass.Location = new Point(1309, 51);
            cBoxSearchClass.Margin = new Padding(3, 4, 3, 4);
            cBoxSearchClass.Name = "cBoxSearchClass";
            cBoxSearchClass.Size = new Size(201, 28);
            cBoxSearchClass.TabIndex = 10;
            cBoxSearchClass.SelectedIndexChanged += cBoxSearchClass_SelectedIndexChanged;
            // 
            // dateTimePickerBirthTo
            // 
            dateTimePickerBirthTo.Location = new Point(1414, 51);
            dateTimePickerBirthTo.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerBirthTo.Name = "dateTimePickerBirthTo";
            dateTimePickerBirthTo.Size = new Size(95, 27);
            dateTimePickerBirthTo.TabIndex = 10;
            dateTimePickerBirthTo.ValueChanged += dateTimePickerBirthTo_ValueChanged;
            // 
            // dateTimePickerBirthFrom
            // 
            dateTimePickerBirthFrom.Location = new Point(1309, 51);
            dateTimePickerBirthFrom.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerBirthFrom.Name = "dateTimePickerBirthFrom";
            dateTimePickerBirthFrom.Size = new Size(98, 27);
            dateTimePickerBirthFrom.TabIndex = 10;
            dateTimePickerBirthFrom.ValueChanged += dateTimePickerBirthFrom_ValueChanged;
            // 
            // cBoxSearch
            // 
            cBoxSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxSearch.FormattingEnabled = true;
            cBoxSearch.Location = new Point(1309, 51);
            cBoxSearch.Margin = new Padding(3, 4, 3, 4);
            cBoxSearch.Name = "cBoxSearch";
            cBoxSearch.Size = new Size(201, 28);
            cBoxSearch.TabIndex = 9;
            cBoxSearch.SelectedIndexChanged += cBoxSearch_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.ButtonFace;
            tabPage2.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(1530, 942);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Lớp";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ButtonFace;
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(txtClassID);
            groupBox3.Controls.Add(txtNumberSV);
            groupBox3.Controls.Add(txtClassMa);
            groupBox3.Controls.Add(txtClassName);
            groupBox3.Location = new Point(247, 65);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(1014, 193);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông Tin";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(488, 81);
            label18.Name = "label18";
            label18.Size = new Size(80, 20);
            label18.TabIndex = 4;
            label18.Text = "Tên Ngành";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(277, 81);
            label17.Name = "label17";
            label17.Size = new Size(65, 20);
            label17.TabIndex = 4;
            label17.Text = "Tên  Lớp";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(107, 81);
            label16.Name = "label16";
            label16.Size = new Size(53, 20);
            label16.TabIndex = 4;
            label16.Text = "ID Lớp";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(790, 81);
            label20.Name = "label20";
            label20.Size = new Size(93, 20);
            label20.TabIndex = 4;
            label20.Text = "Số Lương SV";
            // 
            // txtClassID
            // 
            txtClassID.Location = new Point(107, 105);
            txtClassID.Margin = new Padding(3, 4, 3, 4);
            txtClassID.Name = "txtClassID";
            txtClassID.Size = new Size(107, 27);
            txtClassID.TabIndex = 3;
            txtClassID.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNumberSV
            // 
            txtNumberSV.Location = new Point(790, 105);
            txtNumberSV.Margin = new Padding(3, 4, 3, 4);
            txtNumberSV.Name = "txtNumberSV";
            txtNumberSV.Size = new Size(108, 27);
            txtNumberSV.TabIndex = 2;
            txtNumberSV.TextAlign = HorizontalAlignment.Center;
            // 
            // txtClassMa
            // 
            txtClassMa.Location = new Point(488, 105);
            txtClassMa.Margin = new Padding(3, 4, 3, 4);
            txtClassMa.Name = "txtClassMa";
            txtClassMa.Size = new Size(250, 27);
            txtClassMa.TabIndex = 1;
            txtClassMa.TextAlign = HorizontalAlignment.Center;
            // 
            // txtClassName
            // 
            txtClassName.Location = new Point(277, 105);
            txtClassName.Margin = new Padding(3, 4, 3, 4);
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new Size(150, 27);
            txtClassName.TabIndex = 0;
            txtClassName.TextAlign = HorizontalAlignment.Center;
            txtClassName.TextChanged += txtClassName_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(label19);
            groupBox2.Location = new Point(243, 748);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(1017, 133);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chú Thích";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Times New Roman", 24F, FontStyle.Italic, GraphicsUnit.Point);
            label19.Location = new Point(432, 47);
            label19.Name = "label19";
            label19.Size = new Size(168, 47);
            label19.TabIndex = 0;
            label19.Text = "chú thích";
            label19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(btnClassRefresh);
            groupBox1.Controls.Add(gridviewClass);
            groupBox1.Controls.Add(btnClassDel);
            groupBox1.Controls.Add(btnclassadd);
            groupBox1.Controls.Add(btnClassCancel);
            groupBox1.Controls.Add(btnClassUpdate);
            groupBox1.Controls.Add(btnClassSave);
            groupBox1.Location = new Point(243, 291);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1017, 400);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh Sách";
            // 
            // btnClassRefresh
            // 
            btnClassRefresh.Location = new Point(694, 292);
            btnClassRefresh.Margin = new Padding(3, 4, 3, 4);
            btnClassRefresh.Name = "btnClassRefresh";
            btnClassRefresh.Size = new Size(106, 65);
            btnClassRefresh.TabIndex = 0;
            btnClassRefresh.Text = "Refresh";
            btnClassRefresh.UseVisualStyleBackColor = true;
            btnClassRefresh.Click += btnClassRefresh_Click;
            btnClassRefresh.MouseHover += btnClassRefresh_MouseHover;
            // 
            // gridviewClass
            // 
            gridviewClass.AllowUserToAddRows = false;
            gridviewClass.AllowUserToDeleteRows = false;
            gridviewClass.AllowUserToOrderColumns = true;
            gridviewClass.AllowUserToResizeColumns = false;
            gridviewClass.AllowUserToResizeRows = false;
            gridviewClass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridviewClass.Location = new Point(3, 25);
            gridviewClass.Margin = new Padding(3, 4, 3, 4);
            gridviewClass.MultiSelect = false;
            gridviewClass.Name = "gridviewClass";
            gridviewClass.RowHeadersWidth = 51;
            gridviewClass.RowTemplate.Height = 25;
            gridviewClass.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridviewClass.Size = new Size(635, 371);
            gridviewClass.TabIndex = 7;
            gridviewClass.CellClick += gridviewClass_CellClick;
            gridviewClass.CellContentClick += gridviewClass_CellContentClick;
            // 
            // btnClassDel
            // 
            btnClassDel.Location = new Point(694, 183);
            btnClassDel.Margin = new Padding(3, 4, 3, 4);
            btnClassDel.Name = "btnClassDel";
            btnClassDel.Size = new Size(106, 65);
            btnClassDel.TabIndex = 0;
            btnClassDel.Text = "Xóa";
            btnClassDel.UseVisualStyleBackColor = true;
            btnClassDel.Click += btnClassDel_Click;
            btnClassDel.MouseHover += btnClassDel_MouseHover;
            // 
            // btnclassadd
            // 
            btnclassadd.Location = new Point(694, 73);
            btnclassadd.Margin = new Padding(3, 4, 3, 4);
            btnclassadd.Name = "btnclassadd";
            btnclassadd.Size = new Size(106, 65);
            btnclassadd.TabIndex = 0;
            btnclassadd.Text = "Thêm";
            btnclassadd.UseVisualStyleBackColor = true;
            btnclassadd.Click += btnclassadd_Click;
            btnclassadd.MouseHover += btnclassadd_MouseHover;
            // 
            // btnClassCancel
            // 
            btnClassCancel.Location = new Point(851, 292);
            btnClassCancel.Margin = new Padding(3, 4, 3, 4);
            btnClassCancel.Name = "btnClassCancel";
            btnClassCancel.Size = new Size(106, 65);
            btnClassCancel.TabIndex = 0;
            btnClassCancel.Text = "Hủy";
            btnClassCancel.UseVisualStyleBackColor = true;
            btnClassCancel.Click += btnClassCancel_Click;
            btnClassCancel.MouseHover += btnClassCancel_MouseHover;
            // 
            // btnClassUpdate
            // 
            btnClassUpdate.Location = new Point(851, 73);
            btnClassUpdate.Margin = new Padding(3, 4, 3, 4);
            btnClassUpdate.Name = "btnClassUpdate";
            btnClassUpdate.Size = new Size(106, 65);
            btnClassUpdate.TabIndex = 0;
            btnClassUpdate.Text = "Sửa";
            btnClassUpdate.UseVisualStyleBackColor = true;
            btnClassUpdate.Click += btnClassUpdate_Click;
            btnClassUpdate.MouseHover += btnClassUpdate_MouseHover;
            // 
            // btnClassSave
            // 
            btnClassSave.Location = new Point(851, 183);
            btnClassSave.Margin = new Padding(3, 4, 3, 4);
            btnClassSave.Name = "btnClassSave";
            btnClassSave.Size = new Size(106, 65);
            btnClassSave.TabIndex = 0;
            btnClassSave.Text = "Lưu";
            btnClassSave.UseVisualStyleBackColor = true;
            btnClassSave.Click += btnClassSave_Click;
            btnClassSave.MouseHover += btnClassSave_MouseHover;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1527, 969);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "main";
            Text = "Quản Lí";
            Load += main_Load;
            grbdanhsach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridviewdssv).EndInit();
            grbchucnang.ResumeLayout(false);
            grbthongtin.ResumeLayout(false);
            grbthongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridviewClass).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox grbdanhsach;
        private DataGridView gridviewdssv;
        private GroupBox grbchucnang;
        private GroupBox grbthongtin;
        private Button btnSave;
        private Button btnReset;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnAdd;
        private TextBox txtStudentID;
        private Label label5;
        private Label label2;
        private TextBox txtCount;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label4;
        private ComboBox cBoxFilter;
        private TextBox txtSearch;
        private TextBox txtGPA;
        private Label label13;
        private TextBox txtBranch;
        private Label label12;
        private Label label11;
        private Label label8;
        private TextBox txtAddress;
        private Label label10;
        private TextBox txtEmail;
        private Label label7;
        private Label label9;
        private TextBox txtName;
        private Label label6;
        private ComboBox cBoxGender;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ComboBox cBoxClass;
        private TextBox txtPhone;
        private Label label14;
        private ComboBox cBoxSearch;
        private DateTimePicker dateTimePickerBirth;
        private DateTimePicker dateTimePickerBirthTo;
        private DateTimePicker dateTimePickerBirthFrom;
        private ComboBox cBoxSearchClass;
        private ComboBox cBoxGPATo;
        private ComboBox cBoxGPAFrom;
        private GroupBox groupBox3;
        private Label label18;
        private Label label17;
        private TextBox txtClassMa;
        private TextBox txtClassName;
        private GroupBox groupBox2;
        private Button btnClassRefresh;
        private Button btnClassDel;
        private Button btnClassCancel;
        private Button btnClassSave;
        private Button btnClassUpdate;
        private Button btnclassadd;
        private GroupBox groupBox1;
        private DataGridView gridviewClass;
        private Label label19;
        private Label label20;
        private TextBox txtNumberSV;
        private Button btnCancel;
        private Label label16;
        private TextBox txtClassID;
        private Label label21;
        private Label label15;
    }
}