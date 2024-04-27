namespace GroceryManagementSystem
{
    partial class CategoryFunctions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryFunctions));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            Header = new Panel();
            ControlBox = new Panel();
            btnClose = new Button();
            btnMaximize = new Button();
            btnHide = new Button();
            ApplicationHeading = new Label();
            panel1 = new Panel();
            LogoutButton = new Button();
            AdminProfile = new Panel();
            sidePanel = new Panel();
            CategoryButton = new Button();
            label1 = new Label();
            UsersButton = new Button();
            OrdersButton = new Button();
            ProductButton = new Button();
            ProductPanel = new Panel();
            dataGridView1 = new DataGridView();
            Category_ID = new DataGridViewTextBoxColumn();
            CategoryName = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewButtonColumn();
            Column7 = new DataGridViewButtonColumn();
            SearchPic = new PictureBox();
            SearchBox = new TextBox();
            AddCategory = new Button();
            CategoryLabel = new Label();
            Header.SuspendLayout();
            ControlBox.SuspendLayout();
            sidePanel.SuspendLayout();
            ProductPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SearchPic).BeginInit();
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
            Header.TabIndex = 9;
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
            panel1.Location = new Point(48, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 66);
            panel1.TabIndex = 17;
            // 
            // LogoutButton
            // 
            LogoutButton.Location = new Point(644, 52);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(133, 41);
            LogoutButton.TabIndex = 19;
            LogoutButton.Text = "Logout";
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // AdminProfile
            // 
            AdminProfile.BackgroundImage = (Image)resources.GetObject("AdminProfile.BackgroundImage");
            AdminProfile.BackgroundImageLayout = ImageLayout.Zoom;
            AdminProfile.Location = new Point(798, 45);
            AdminProfile.Name = "AdminProfile";
            AdminProfile.Size = new Size(65, 57);
            AdminProfile.TabIndex = 20;
            // 
            // sidePanel
            // 
            sidePanel.BorderStyle = BorderStyle.FixedSingle;
            sidePanel.Controls.Add(CategoryButton);
            sidePanel.Controls.Add(label1);
            sidePanel.Controls.Add(UsersButton);
            sidePanel.Controls.Add(OrdersButton);
            sidePanel.Controls.Add(ProductButton);
            sidePanel.Location = new Point(4, 124);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(210, 351);
            sidePanel.TabIndex = 21;
            // 
            // CategoryButton
            // 
            CategoryButton.Location = new Point(16, 152);
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
            UsersButton.Location = new Point(16, 228);
            UsersButton.Name = "UsersButton";
            UsersButton.Size = new Size(179, 42);
            UsersButton.TabIndex = 10;
            UsersButton.Text = "Users";
            UsersButton.UseVisualStyleBackColor = true;
            UsersButton.Click += UsersButton_Click;
            // 
            // OrdersButton
            // 
            OrdersButton.Location = new Point(16, 80);
            OrdersButton.Name = "OrdersButton";
            OrdersButton.Size = new Size(179, 42);
            OrdersButton.TabIndex = 1;
            OrdersButton.Text = "Orders";
            OrdersButton.UseVisualStyleBackColor = true;
            OrdersButton.Click += OrdersButton_Click;
            // 
            // ProductButton
            // 
            ProductButton.Location = new Point(16, 14);
            ProductButton.Name = "ProductButton";
            ProductButton.Size = new Size(179, 42);
            ProductButton.TabIndex = 0;
            ProductButton.Text = "Products";
            ProductButton.UseVisualStyleBackColor = true;
            ProductButton.Click += ProductButton_Click;
            // 
            // ProductPanel
            // 
            ProductPanel.BorderStyle = BorderStyle.FixedSingle;
            ProductPanel.Controls.Add(dataGridView1);
            ProductPanel.Controls.Add(SearchPic);
            ProductPanel.Controls.Add(SearchBox);
            ProductPanel.Controls.Add(AddCategory);
            ProductPanel.Controls.Add(CategoryLabel);
            ProductPanel.Location = new Point(220, 124);
            ProductPanel.Name = "ProductPanel";
            ProductPanel.Size = new Size(643, 351);
            ProductPanel.TabIndex = 22;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Category_ID, CategoryName, Column6, Column7 });
            dataGridView1.Location = new Point(37, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.Size = new Size(538, 215);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Category_ID
            // 
            Category_ID.DataPropertyName = "Category_ID";
            Category_ID.HeaderText = "Category ID";
            Category_ID.Name = "Category_ID";
            Category_ID.ReadOnly = true;
            // 
            // CategoryName
            // 
            CategoryName.DataPropertyName = "CategoryName";
            CategoryName.HeaderText = "Category Name";
            CategoryName.Name = "CategoryName";
            CategoryName.ReadOnly = true;
            // 
            // Column6
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.SandyBrown;
            dataGridViewCellStyle1.Font = new Font("Constantia", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.SandyBrown;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            Column6.DefaultCellStyle = dataGridViewCellStyle1;
            Column6.FlatStyle = FlatStyle.Flat;
            Column6.HeaderText = "";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Text = "Update";
            Column6.UseColumnTextForButtonValue = true;
            // 
            // Column7
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.IndianRed;
            dataGridViewCellStyle2.Font = new Font("Constantia", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            Column7.DefaultCellStyle = dataGridViewCellStyle2;
            Column7.FlatStyle = FlatStyle.Flat;
            Column7.HeaderText = "";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Text = "Delete";
            Column7.UseColumnTextForButtonValue = true;
            // 
            // SearchPic
            // 
            SearchPic.BackgroundImage = (Image)resources.GetObject("SearchPic.BackgroundImage");
            SearchPic.BackgroundImageLayout = ImageLayout.Zoom;
            SearchPic.BorderStyle = BorderStyle.FixedSingle;
            SearchPic.Location = new Point(575, 16);
            SearchPic.Name = "SearchPic";
            SearchPic.Size = new Size(28, 21);
            SearchPic.TabIndex = 14;
            SearchPic.TabStop = false;
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(394, 16);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(179, 22);
            SearchBox.TabIndex = 13;
            SearchBox.TextChanged += SearchBox_TextChanged;
            // 
            // AddCategory
            // 
            AddCategory.Location = new Point(14, 308);
            AddCategory.Name = "AddCategory";
            AddCategory.Size = new Size(100, 23);
            AddCategory.TabIndex = 1;
            AddCategory.Text = "Add Category";
            AddCategory.UseVisualStyleBackColor = true;
            AddCategory.Click += AddCategory_Click;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CategoryLabel.Location = new Point(14, 16);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(143, 19);
            CategoryLabel.TabIndex = 0;
            CategoryLabel.Text = "Existing Category";
            // 
            // CategoryFunctions
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 482);
            Controls.Add(ProductPanel);
            Controls.Add(sidePanel);
            Controls.Add(AdminProfile);
            Controls.Add(LogoutButton);
            Controls.Add(panel1);
            Controls.Add(Header);
            Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CategoryFunctions";
            Text = "CategoryFunctions";
            Shown += CategoryFunctions_Shown;
            Header.ResumeLayout(false);
            Header.PerformLayout();
            ControlBox.ResumeLayout(false);
            sidePanel.ResumeLayout(false);
            sidePanel.PerformLayout();
            ProductPanel.ResumeLayout(false);
            ProductPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)SearchPic).EndInit();
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
        private Button LogoutButton;
        private Panel AdminProfile;
        private Panel sidePanel;
        private Button CategoryButton;
        private Label label1;
        private Button UsersButton;
        private Button OrdersButton;
        private Button ProductButton;
        private Panel ProductPanel;
        private Button AddCategory;
        private Label CategoryLabel;
        private TextBox SearchBox;
        private PictureBox SearchPic;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Category_ID;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewButtonColumn Column6;
        private DataGridViewButtonColumn Column7;
    }
}