namespace Test3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnAdd = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            lblContactID = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblAddress = new Label();
            lblContactNumber = new Label();
            lblGender = new Label();
            logo = new PictureBox();
            txtboxContactID = new TextBox();
            txtboxFirstName = new TextBox();
            txtboxLastName = new TextBox();
            txtboxContactNumber = new TextBox();
            txtboxAddress = new TextBox();
            cmbGender = new ComboBox();
            dataGridView = new DataGridView();
            txtboxSearch = new TextBox();
            lblSearch = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Green;
            btnAdd.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(56, 458);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(110, 54);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += button1_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Blue;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(177, 458);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(110, 54);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Orange;
            btnClear.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(417, 458);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(110, 54);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(292, 458);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 54);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // lblContactID
            // 
            lblContactID.AutoSize = true;
            lblContactID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblContactID.Location = new Point(56, 146);
            lblContactID.Name = "lblContactID";
            lblContactID.Size = new Size(86, 20);
            lblContactID.TabIndex = 5;
            lblContactID.Text = "Contact ID";
            lblContactID.Click += label2_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFirstName.Location = new Point(56, 192);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(86, 20);
            lblFirstName.TabIndex = 6;
            lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLastName.Location = new Point(56, 234);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(86, 20);
            lblLastName.TabIndex = 7;
            lblLastName.Text = "Last Name";
            lblLastName.Click += label1_Click_1;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddress.Location = new Point(56, 297);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(68, 20);
            lblAddress.TabIndex = 8;
            lblAddress.Text = "Address";
            lblAddress.Click += label4_Click;
            // 
            // lblContactNumber
            // 
            lblContactNumber.AutoSize = true;
            lblContactNumber.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblContactNumber.Location = new Point(56, 268);
            lblContactNumber.Name = "lblContactNumber";
            lblContactNumber.Size = new Size(93, 20);
            lblContactNumber.TabIndex = 9;
            lblContactNumber.Text = "Contact No.";
            lblContactNumber.Click += label5_Click;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblGender.Location = new Point(56, 371);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(63, 20);
            lblGender.TabIndex = 10;
            lblGender.Text = "Gender";
            lblGender.Click += label6_Click;
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(319, 12);
            logo.Name = "logo";
            logo.Size = new Size(314, 115);
            logo.TabIndex = 11;
            logo.TabStop = false;
            // 
            // txtboxContactID
            // 
            txtboxContactID.Location = new Point(178, 143);
            txtboxContactID.Name = "txtboxContactID";
            txtboxContactID.Size = new Size(175, 23);
            txtboxContactID.TabIndex = 12;
            // 
            // txtboxFirstName
            // 
            txtboxFirstName.Location = new Point(178, 189);
            txtboxFirstName.Name = "txtboxFirstName";
            txtboxFirstName.Size = new Size(175, 23);
            txtboxFirstName.TabIndex = 13;
            // 
            // txtboxLastName
            // 
            txtboxLastName.Location = new Point(178, 231);
            txtboxLastName.Name = "txtboxLastName";
            txtboxLastName.Size = new Size(175, 23);
            txtboxLastName.TabIndex = 14;
            // 
            // txtboxContactNumber
            // 
            txtboxContactNumber.Location = new Point(178, 265);
            txtboxContactNumber.Name = "txtboxContactNumber";
            txtboxContactNumber.Size = new Size(175, 23);
            txtboxContactNumber.TabIndex = 15;
            // 
            // txtboxAddress
            // 
            txtboxAddress.Location = new Point(178, 298);
            txtboxAddress.Multiline = true;
            txtboxAddress.Name = "txtboxAddress";
            txtboxAddress.Size = new Size(175, 60);
            txtboxAddress.TabIndex = 16;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(177, 368);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(176, 23);
            cmbGender.TabIndex = 17;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(379, 189);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(503, 250);
            dataGridView.TabIndex = 18;
            // 
            // txtboxSearch
            // 
            txtboxSearch.Location = new Point(480, 143);
            txtboxSearch.Name = "txtboxSearch";
            txtboxSearch.Size = new Size(402, 23);
            txtboxSearch.TabIndex = 19;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSearch.Location = new Point(379, 146);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(60, 20);
            lblSearch.TabIndex = 20;
            lblSearch.Text = "Search";
            lblSearch.Click += label1_Click_2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(907, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 554);
            Controls.Add(pictureBox1);
            Controls.Add(lblSearch);
            Controls.Add(txtboxSearch);
            Controls.Add(dataGridView);
            Controls.Add(cmbGender);
            Controls.Add(txtboxAddress);
            Controls.Add(txtboxContactNumber);
            Controls.Add(txtboxLastName);
            Controls.Add(txtboxFirstName);
            Controls.Add(txtboxContactID);
            Controls.Add(logo);
            Controls.Add(lblGender);
            Controls.Add(lblContactNumber);
            Controls.Add(lblAddress);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblContactID);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnClear;
        private Button btnDelete;
        private Label lblContactID;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblAddress;
        private Label lblContactNumber;
        private Label lblGender;
        private PictureBox logo;
        private TextBox txtboxContactID;
        private TextBox txtboxFirstName;
        private TextBox txtboxLastName;
        private TextBox txtboxContactNumber;
        private TextBox txtboxAddress;
        private ComboBox cmbGender;
        private DataGridView dataGridView;
        private TextBox txtboxSearch;
        private Label lblSearch;
        private PictureBox pictureBox1;
    }
}