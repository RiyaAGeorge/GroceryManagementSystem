namespace GroceryManagementSystem
{
    partial class StaffLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffLogin));
            header = new Panel();
            ApplicationHeading = new Label();
            panel1 = new Panel();
            btnMaximize = new Button();
            btnHide = new Button();
            btnClose = new Button();
            FeelFresh = new Label();
            Email = new Label();
            EmailBox = new TextBox();
            passwordBox = new TextBox();
            Password = new Label();
            LoginButton = new Button();
            panel2 = new Panel();
            header.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // header
            // 
            header.BackColor = Color.White;
            header.Controls.Add(ApplicationHeading);
            header.Controls.Add(panel1);
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(815, 34);
            header.TabIndex = 0;
            // 
            // ApplicationHeading
            // 
            ApplicationHeading.AutoSize = true;
            ApplicationHeading.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ApplicationHeading.Location = new Point(12, 9);
            ApplicationHeading.Name = "ApplicationHeading";
            ApplicationHeading.Size = new Size(186, 19);
            ApplicationHeading.TabIndex = 2;
            ApplicationHeading.Text = "<- Feel Fresh Application";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnMaximize);
            panel1.Controls.Add(btnHide);
            panel1.Location = new Point(725, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(89, 34);
            panel1.TabIndex = 0;
            // 
            // btnMaximize
            // 
            btnMaximize.BackColor = Color.YellowGreen;
            btnMaximize.BackgroundImage = (Image)resources.GetObject("btnMaximize.BackgroundImage");
            btnMaximize.BackgroundImageLayout = ImageLayout.Zoom;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Location = new Point(31, 3);
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
            btnHide.Location = new Point(2, 3);
            btnHide.Name = "btnHide";
            btnHide.Size = new Size(28, 28);
            btnHide.TabIndex = 4;
            btnHide.UseVisualStyleBackColor = false;
            btnHide.Click += btnHide_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.IndianRed;
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(785, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(28, 28);
            btnClose.TabIndex = 6;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // FeelFresh
            // 
            FeelFresh.AutoSize = true;
            FeelFresh.Font = new Font("Constantia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FeelFresh.ForeColor = Color.Silver;
            FeelFresh.Location = new Point(308, 81);
            FeelFresh.Name = "FeelFresh";
            FeelFresh.Size = new Size(328, 36);
            FeelFresh.TabIndex = 7;
            FeelFresh.Text = "Welcome to Feel Fresh!";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Constantia", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Email.ForeColor = Color.Silver;
            Email.Location = new Point(297, 175);
            Email.Name = "Email";
            Email.Size = new Size(193, 23);
            Email.TabIndex = 8;
            Email.Text = "Enter your Staff Email:";
            Email.Click += Email_Click;
            // 
            // EmailBox
            // 
            EmailBox.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailBox.Location = new Point(298, 204);
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(360, 27);
            EmailBox.TabIndex = 9;
            EmailBox.TextChanged += EmailBox_TextChanged;
            // 
            // passwordBox
            // 
            passwordBox.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordBox.Location = new Point(297, 279);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(360, 27);
            passwordBox.TabIndex = 10;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Constantia", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password.ForeColor = Color.Silver;
            Password.Location = new Point(297, 249);
            Password.Name = "Password";
            Password.Size = new Size(182, 23);
            Password.TabIndex = 11;
            Password.Text = "Enter your password:";
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(297, 343);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(360, 37);
            LoginButton.TabIndex = 12;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(136, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(158, 105);
            panel2.TabIndex = 13;
            // 
            // StaffLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(816, 490);
            Controls.Add(panel2);
            Controls.Add(LoginButton);
            Controls.Add(Password);
            Controls.Add(passwordBox);
            Controls.Add(EmailBox);
            Controls.Add(Email);
            Controls.Add(FeelFresh);
            Controls.Add(btnClose);
            Controls.Add(header);
            Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StaffLogin";
            Text = "StaffLogin";
            header.ResumeLayout(false);
            header.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel header;
        private Panel panel1;
        private Label ApplicationHeading;
        private Button btnHide;
        private Button btnMaximize;
        private Button btnClose;
        private Label FeelFresh;
        private Label Email;
        private TextBox EmailBox;
        private TextBox passwordBox;
        private Label Password;
        private Button LoginButton;
        private Panel panel2;
    }
}