namespace GroceryManagementSystem
{
    partial class StaffPortal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffPortal));
            Header = new Panel();
            ControlBox = new Panel();
            btnMaximize = new Button();
            btnHide = new Button();
            ApplicationHeading = new Label();
            btnClose = new Button();
            sidePanel = new Panel();
            CategoryButton = new Button();
            label1 = new Label();
            UsersButton = new Button();
            OrdersButton = new Button();
            ProductButton = new Button();
            panel1 = new Panel();
            AdminProfile = new Panel();
            LogoutButton = new Button();
            mainPanel = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            Header.SuspendLayout();
            ControlBox.SuspendLayout();
            sidePanel.SuspendLayout();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // Header
            // 
            Header.BorderStyle = BorderStyle.FixedSingle;
            Header.Controls.Add(ControlBox);
            Header.Controls.Add(ApplicationHeading);
            Header.Location = new Point(1, 0);
            Header.Name = "Header";
            Header.Size = new Size(871, 36);
            Header.TabIndex = 6;
            // 
            // ControlBox
            // 
            ControlBox.Controls.Add(btnMaximize);
            ControlBox.Controls.Add(btnHide);
            ControlBox.Location = new Point(770, 0);
            ControlBox.Name = "ControlBox";
            ControlBox.Size = new Size(100, 35);
            ControlBox.TabIndex = 4;
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
            // btnClose
            // 
            btnClose.BackColor = Color.IndianRed;
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(840, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(28, 28);
            btnClose.TabIndex = 11;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // sidePanel
            // 
            sidePanel.BorderStyle = BorderStyle.FixedSingle;
            sidePanel.Controls.Add(CategoryButton);
            sidePanel.Controls.Add(label1);
            sidePanel.Controls.Add(UsersButton);
            sidePanel.Controls.Add(OrdersButton);
            sidePanel.Controls.Add(ProductButton);
            sidePanel.Location = new Point(2, 125);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(210, 351);
            sidePanel.TabIndex = 12;
            // 
            // CategoryButton
            // 
            CategoryButton.Location = new Point(16, 151);
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
            UsersButton.Location = new Point(16, 222);
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
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(37, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 66);
            panel1.TabIndex = 14;
            // 
            // AdminProfile
            // 
            AdminProfile.BackgroundImage = (Image)resources.GetObject("AdminProfile.BackgroundImage");
            AdminProfile.BackgroundImageLayout = ImageLayout.Zoom;
            AdminProfile.Location = new Point(800, 48);
            AdminProfile.Name = "AdminProfile";
            AdminProfile.Size = new Size(65, 57);
            AdminProfile.TabIndex = 15;
            // 
            // LogoutButton
            // 
            LogoutButton.Location = new Point(640, 57);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(133, 41);
            LogoutButton.TabIndex = 16;
            LogoutButton.Text = "Logout";
            LogoutButton.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(panel2);
            mainPanel.Controls.Add(label2);
            mainPanel.Location = new Point(222, 125);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(638, 350);
            mainPanel.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(71, 57);
            label2.Name = "label2";
            label2.Size = new Size(493, 45);
            label2.TabIndex = 0;
            label2.Text = "Welcome to the Staff Portal";
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(179, 153);
            panel2.Name = "panel2";
            panel2.Size = new Size(304, 165);
            panel2.TabIndex = 1;
            // 
            // StaffPortal
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 480);
            Controls.Add(mainPanel);
            Controls.Add(LogoutButton);
            Controls.Add(AdminProfile);
            Controls.Add(panel1);
            Controls.Add(sidePanel);
            Controls.Add(btnClose);
            Controls.Add(Header);
            Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StaffPortal";
            Text = "StaffPortal";
            Header.ResumeLayout(false);
            Header.PerformLayout();
            ControlBox.ResumeLayout(false);
            sidePanel.ResumeLayout(false);
            sidePanel.PerformLayout();
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Header;
        private Panel ControlBox;
        private Button btnMaximize;
        private Button btnHide;
        private Label ApplicationHeading;
        private Button btnClose;
        private Panel sidePanel;
        private Label label1;
        private Button UsersButton;
        private Button OrdersButton;
        private Button ProductButton;
        private Panel panel1;
        private Panel AdminProfile;
        private Button LogoutButton;
        private Button CategoryButton;
        private Panel mainPanel;
        private Label label2;
        private Panel panel2;
    }
}