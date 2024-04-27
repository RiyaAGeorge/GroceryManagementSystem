namespace GroceryManagementSystem
{
    partial class UsersFunction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersFunction));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            Header = new Panel();
            ControlBox = new Panel();
            btnClose = new Button();
            btnMaximize = new Button();
            btnHide = new Button();
            ApplicationHeading = new Label();
            panel1 = new Panel();
            sidePanel = new Panel();
            CategoryButton = new Button();
            label1 = new Label();
            UsersButton = new Button();
            OrdersButton = new Button();
            ProductButton = new Button();
            LogoutButton = new Button();
            AdminProfile = new Panel();
            UserPanel = new Panel();
            SearchPic = new PictureBox();
            SearchBox = new TextBox();
            dataGridView1 = new DataGridView();
            AddUser = new Button();
            UserLabel = new Label();
            User_ID = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Isadmin = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewButtonColumn();
            Header.SuspendLayout();
            ControlBox.SuspendLayout();
            sidePanel.SuspendLayout();
            UserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SearchPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Header
            // 
            Header.BorderStyle = BorderStyle.FixedSingle;
            Header.Controls.Add(ControlBox);
            Header.Controls.Add(ApplicationHeading);
            Header.Location = new Point(2, 1);
            Header.Name = "Header";
            Header.Size = new Size(871, 36);
            Header.TabIndex = 11;
            // 
            // ControlBox
            // 
            ControlBox.Controls.Add(btnClose);
            ControlBox.Controls.Add(btnMaximize);
            ControlBox.Controls.Add(btnHide);
            ControlBox.Location = new Point(770, 0);
            ControlBox.Name = "ControlBox";
            ControlBox.Size = new Size(100, 35);
            ControlBox.TabIndex = 4;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.IndianRed;
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(68, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(28, 28);
            btnClose.TabIndex = 13;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.BackColor = Color.YellowGreen;
            btnMaximize.BackgroundImage = (Image)resources.GetObject("btnMaximize.BackgroundImage");
            btnMaximize.BackgroundImageLayout = ImageLayout.Zoom;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Location = new Point(37, 4);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(28, 28);
            btnMaximize.TabIndex = 5;
            btnMaximize.UseVisualStyleBackColor = false;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnHide
            // 
            btnHide.BackColor = Color.NavajoWhite;
            btnHide.BackgroundImage = (Image)resources.GetObject("btnHide.BackgroundImage");
            btnHide.BackgroundImageLayout = ImageLayout.Zoom;
            btnHide.FlatAppearance.BorderSize = 0;
            btnHide.FlatStyle = FlatStyle.Flat;
            btnHide.Location = new Point(5, 4);
            btnHide.Name = "btnHide";
            btnHide.Size = new Size(28, 28);
            btnHide.TabIndex = 4;
            btnHide.UseVisualStyleBackColor = false;
            btnHide.Click += btnHide_Click;
            // 
            // ApplicationHeading
            // 
            ApplicationHeading.AutoSize = true;
            ApplicationHeading.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ApplicationHeading.Location = new Point(11, 8);
            ApplicationHeading.Name = "ApplicationHeading";
            ApplicationHeading.Size = new Size(186, 19);
            ApplicationHeading.TabIndex = 3;
            ApplicationHeading.Text = "<- Feel Fresh Application";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(39, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 66);
            panel1.TabIndex = 19;
            // 
            // sidePanel
            // 
            sidePanel.BorderStyle = BorderStyle.FixedSingle;
            sidePanel.Controls.Add(CategoryButton);
            sidePanel.Controls.Add(label1);
            sidePanel.Controls.Add(UsersButton);
            sidePanel.Controls.Add(OrdersButton);
            sidePanel.Controls.Add(ProductButton);
            sidePanel.Location = new Point(2, 137);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(210, 351);
            sidePanel.TabIndex = 23;
            // 
            // CategoryButton
            // 
            CategoryButton.Location = new Point(16, 159);
            CategoryButton.Name = "CategoryButton";
            CategoryButton.Size = new Size(179, 42);
            CategoryButton.TabIndex = 12;
            CategoryButton.Text = "Category";
            CategoryButton.UseVisualStyleBackColor = true;
            CategoryButton.Click += CategoryButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(0, 64, 64);
            label1.Location = new Point(63, 313);
            label1.Name = "label1";
            label1.Size = new Size(90, 14);
            label1.TabIndex = 11;
            label1.Text = "@ragstudios.inc";
            // 
            // UsersButton
            // 
            UsersButton.Location = new Point(16, 231);
            UsersButton.Name = "UsersButton";
            UsersButton.Size = new Size(179, 42);
            UsersButton.TabIndex = 10;
            UsersButton.Text = "Users";
            UsersButton.UseVisualStyleBackColor = true;
            UsersButton.Click += UsersButton_Click;
            // 
            // OrdersButton
            // 
            OrdersButton.Location = new Point(16, 88);
            OrdersButton.Name = "OrdersButton";
            OrdersButton.Size = new Size(179, 42);
            OrdersButton.TabIndex = 1;
            OrdersButton.Text = "Orders";
            OrdersButton.UseVisualStyleBackColor = true;
            OrdersButton.Click += OrdersButton_Click;
            // 
            // ProductButton
            // 
            ProductButton.Location = new Point(16, 19);
            ProductButton.Name = "ProductButton";
            ProductButton.Size = new Size(179, 42);
            ProductButton.TabIndex = 0;
            ProductButton.Text = "Products";
            ProductButton.UseVisualStyleBackColor = true;
            ProductButton.Click += ProductButton_Click;
            // 
            // LogoutButton
            // 
            LogoutButton.Location = new Point(652, 58);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(133, 41);
            LogoutButton.TabIndex = 24;
            LogoutButton.Text = "Logout";
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // AdminProfile
            // 
            AdminProfile.BackgroundImage = (Image)resources.GetObject("AdminProfile.BackgroundImage");
            AdminProfile.BackgroundImageLayout = ImageLayout.Zoom;
            AdminProfile.Location = new Point(804, 49);
            AdminProfile.Name = "AdminProfile";
            AdminProfile.Size = new Size(65, 57);
            AdminProfile.TabIndex = 25;
            // 
            // UserPanel
            // 
            UserPanel.BorderStyle = BorderStyle.FixedSingle;
            UserPanel.Controls.Add(SearchPic);
            UserPanel.Controls.Add(SearchBox);
            UserPanel.Controls.Add(dataGridView1);
            UserPanel.Controls.Add(AddUser);
            UserPanel.Controls.Add(UserLabel);
            UserPanel.Location = new Point(227, 137);
            UserPanel.Name = "UserPanel";
            UserPanel.Size = new Size(642, 352);
            UserPanel.TabIndex = 26;
            // 
            // SearchPic
            // 
            SearchPic.BackgroundImage = (Image)resources.GetObject("SearchPic.BackgroundImage");
            SearchPic.BackgroundImageLayout = ImageLayout.Zoom;
            SearchPic.BorderStyle = BorderStyle.FixedSingle;
            SearchPic.Location = new Point(563, 19);
            SearchPic.Name = "SearchPic";
            SearchPic.Size = new Size(28, 21);
            SearchPic.TabIndex = 4;
            SearchPic.TabStop = false;
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(380, 19);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(179, 22);
            SearchBox.TabIndex = 3;
            SearchBox.TextChanged += SearchBox_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.Beige;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { User_ID, Username, Password, Isadmin, Email, Column2 });
            dataGridView1.Location = new Point(28, 61);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.Size = new Size(570, 212);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // AddUser
            // 
            AddUser.Location = new Point(14, 308);
            AddUser.Name = "AddUser";
            AddUser.Size = new Size(100, 23);
            AddUser.TabIndex = 1;
            AddUser.Text = "Add User";
            AddUser.UseVisualStyleBackColor = true;
            AddUser.Click += AddUser_Click;
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserLabel.Location = new Point(14, 16);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(116, 19);
            UserLabel.TabIndex = 0;
            UserLabel.Text = "Existing Users";
            // 
            // User_ID
            // 
            User_ID.DataPropertyName = "User_ID";
            User_ID.HeaderText = "User ID";
            User_ID.Name = "User_ID";
            User_ID.ReadOnly = true;
            // 
            // Username
            // 
            Username.DataPropertyName = "Username";
            Username.HeaderText = "Username";
            Username.Name = "Username";
            Username.ReadOnly = true;
            // 
            // Password
            // 
            Password.DataPropertyName = "Password";
            Password.HeaderText = "Password";
            Password.Name = "Password";
            Password.ReadOnly = true;
            // 
            // Isadmin
            // 
            Isadmin.DataPropertyName = "Isadmin";
            Isadmin.HeaderText = "IsAdmin";
            Isadmin.Name = "Isadmin";
            Isadmin.ReadOnly = true;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Column2
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.IndianRed;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            Column2.DefaultCellStyle = dataGridViewCellStyle1;
            Column2.FlatStyle = FlatStyle.Flat;
            Column2.HeaderText = "";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Text = "Delete";
            Column2.UseColumnTextForButtonValue = true;
            // 
            // UsersFunction
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 491);
            Controls.Add(UserPanel);
            Controls.Add(AdminProfile);
            Controls.Add(LogoutButton);
            Controls.Add(sidePanel);
            Controls.Add(panel1);
            Controls.Add(Header);
            Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UsersFunction";
            Text = "UsersFunction";
            Shown += UsersFunction_Shown;
            Header.ResumeLayout(false);
            Header.PerformLayout();
            ControlBox.ResumeLayout(false);
            sidePanel.ResumeLayout(false);
            sidePanel.PerformLayout();
            UserPanel.ResumeLayout(false);
            UserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SearchPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Header;
        private Panel ControlBox;
        private Button btnClose;
        private Button btnMaximize;
        private Button btnHide;
        private Label ApplicationHeading;
        private Panel panel1;
        private Panel sidePanel;
        private Button CategoryButton;
        private Label label1;
        private Button UsersButton;
        private Button OrdersButton;
        private Button ProductButton;
        private Button LogoutButton;
        private Panel AdminProfile;
        private Panel UserPanel;
        private Button AddUser;
        private Label UserLabel;
        private DataGridView dataGridView1;
        private TextBox SearchBox;
        private PictureBox SearchPic;
        private DataGridViewTextBoxColumn User_ID;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn Isadmin;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewButtonColumn Column2;
    }
}