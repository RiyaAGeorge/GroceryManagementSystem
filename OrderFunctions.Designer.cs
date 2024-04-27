namespace GroceryManagementSystem
{
    partial class OrderFunctions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderFunctions));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            ProductPanel = new Panel();
            dataGridView1 = new DataGridView();
            Order_ID = new DataGridViewTextBoxColumn();
            Order_Date = new DataGridViewTextBoxColumn();
            Order_Status = new DataGridViewTextBoxColumn();
            Total_Amount = new DataGridViewTextBoxColumn();
            Customer_ID = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewButtonColumn();
            Column7 = new DataGridViewButtonColumn();
            SearchPic = new PictureBox();
            SearchBox = new TextBox();
            AddOrder = new Button();
            OrdersLabel = new Label();
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
            Header.TabIndex = 8;
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
            panel1.Location = new Point(41, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 66);
            panel1.TabIndex = 16;
            // 
            // sidePanel
            // 
            sidePanel.BorderStyle = BorderStyle.FixedSingle;
            sidePanel.Controls.Add(CategoryButton);
            sidePanel.Controls.Add(label1);
            sidePanel.Controls.Add(UsersButton);
            sidePanel.Controls.Add(OrdersButton);
            sidePanel.Controls.Add(ProductButton);
            sidePanel.Location = new Point(2, 122);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(210, 351);
            sidePanel.TabIndex = 17;
            // 
            // CategoryButton
            // 
            CategoryButton.Location = new Point(16, 163);
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
            UsersButton.Location = new Point(16, 235);
            UsersButton.Name = "UsersButton";
            UsersButton.Size = new Size(179, 42);
            UsersButton.TabIndex = 10;
            UsersButton.Text = "Users";
            UsersButton.UseVisualStyleBackColor = true;
            UsersButton.Click += UsersButton_Click;
            // 
            // OrdersButton
            // 
            OrdersButton.Location = new Point(16, 90);
            OrdersButton.Name = "OrdersButton";
            OrdersButton.Size = new Size(179, 42);
            OrdersButton.TabIndex = 1;
            OrdersButton.Text = "Orders";
            OrdersButton.UseVisualStyleBackColor = true;
            OrdersButton.Click += OrdersButton_Click;
            // 
            // ProductButton
            // 
            ProductButton.Location = new Point(16, 18);
            ProductButton.Name = "ProductButton";
            ProductButton.Size = new Size(179, 42);
            ProductButton.TabIndex = 0;
            ProductButton.Text = "Products";
            ProductButton.UseVisualStyleBackColor = true;
            ProductButton.Click += ProductButton_Click;
            // 
            // LogoutButton
            // 
            LogoutButton.Location = new Point(644, 66);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(133, 41);
            LogoutButton.TabIndex = 18;
            LogoutButton.Text = "Logout";
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // AdminProfile
            // 
            AdminProfile.BackgroundImage = (Image)resources.GetObject("AdminProfile.BackgroundImage");
            AdminProfile.BackgroundImageLayout = ImageLayout.Zoom;
            AdminProfile.Location = new Point(798, 54);
            AdminProfile.Name = "AdminProfile";
            AdminProfile.Size = new Size(65, 57);
            AdminProfile.TabIndex = 19;
            // 
            // ProductPanel
            // 
            ProductPanel.BorderStyle = BorderStyle.FixedSingle;
            ProductPanel.Controls.Add(dataGridView1);
            ProductPanel.Controls.Add(SearchPic);
            ProductPanel.Controls.Add(SearchBox);
            ProductPanel.Controls.Add(AddOrder);
            ProductPanel.Controls.Add(OrdersLabel);
            ProductPanel.Location = new Point(218, 122);
            ProductPanel.Name = "ProductPanel";
            ProductPanel.Size = new Size(655, 351);
            ProductPanel.TabIndex = 20;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Order_ID, Order_Date, Order_Status, Total_Amount, Customer_ID, Column6, Column7 });
            dataGridView1.Location = new Point(23, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.Size = new Size(605, 240);
            dataGridView1.TabIndex = 23;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Order_ID
            // 
            Order_ID.DataPropertyName = "Order_ID";
            Order_ID.HeaderText = "ID";
            Order_ID.Name = "Order_ID";
            Order_ID.ReadOnly = true;
            // 
            // Order_Date
            // 
            Order_Date.DataPropertyName = "Order_Date";
            Order_Date.HeaderText = "Order Date";
            Order_Date.Name = "Order_Date";
            Order_Date.ReadOnly = true;
            // 
            // Order_Status
            // 
            Order_Status.DataPropertyName = "Order_Status";
            Order_Status.HeaderText = "Order Status";
            Order_Status.Name = "Order_Status";
            Order_Status.ReadOnly = true;
            // 
            // Total_Amount
            // 
            Total_Amount.DataPropertyName = "Total_Amount";
            Total_Amount.HeaderText = "Total Amount";
            Total_Amount.Name = "Total_Amount";
            Total_Amount.ReadOnly = true;
            // 
            // Customer_ID
            // 
            Customer_ID.DataPropertyName = "Customer_ID";
            Customer_ID.HeaderText = "Customer ID";
            Customer_ID.Name = "Customer_ID";
            Customer_ID.ReadOnly = true;
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
            SearchPic.Location = new Point(566, 14);
            SearchPic.Name = "SearchPic";
            SearchPic.Size = new Size(28, 21);
            SearchPic.TabIndex = 22;
            SearchPic.TabStop = false;
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(385, 14);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(179, 22);
            SearchBox.TabIndex = 21;
            SearchBox.TextChanged += SearchBox_TextChanged;
            // 
            // AddOrder
            // 
            AddOrder.Location = new Point(14, 308);
            AddOrder.Name = "AddOrder";
            AddOrder.Size = new Size(100, 23);
            AddOrder.TabIndex = 1;
            AddOrder.Text = "Add Order";
            AddOrder.UseVisualStyleBackColor = true;
            AddOrder.Click += AddOrder_Click;
            // 
            // OrdersLabel
            // 
            OrdersLabel.AutoSize = true;
            OrdersLabel.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrdersLabel.Location = new Point(14, 16);
            OrdersLabel.Name = "OrdersLabel";
            OrdersLabel.Size = new Size(127, 19);
            OrdersLabel.TabIndex = 0;
            OrdersLabel.Text = "Existing Orders";
            // 
            // OrderFunctions
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 476);
            Controls.Add(ProductPanel);
            Controls.Add(AdminProfile);
            Controls.Add(LogoutButton);
            Controls.Add(sidePanel);
            Controls.Add(panel1);
            Controls.Add(Header);
            Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrderFunctions";
            Text = "OrderFunctions";
            Shown += OrderFunctions_Shown;
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
        private Button btnMaximize;
        private Button btnHide;
        private Label ApplicationHeading;
        private Button btnClose;
        private Panel panel1;
        private Panel sidePanel;
        private Button CategoryButton;
        private Label label1;
        private Button UsersButton;
        private Button OrdersButton;
        private Button ProductButton;
        private Button LogoutButton;
        private Panel AdminProfile;
        private Panel ProductPanel;
        private Button AddOrder;
        private Label OrdersLabel;
        private TextBox SearchBox;
        private PictureBox SearchPic;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Order_ID;
        private DataGridViewTextBoxColumn Order_Date;
        private DataGridViewTextBoxColumn Order_Status;
        private DataGridViewTextBoxColumn Total_Amount;
        private DataGridViewTextBoxColumn Customer_ID;
        private DataGridViewButtonColumn Column6;
        private DataGridViewButtonColumn Column7;
    }
}