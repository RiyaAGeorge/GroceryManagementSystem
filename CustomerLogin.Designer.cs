namespace GroceryManagementSystem
{
    partial class CustomerLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerLogin));
            Header = new Panel();
            ApplicationHeading = new Label();
            ControlBox = new Panel();
            btnClose = new Button();
            btnMaximize = new Button();
            btnHide = new Button();
            logo = new Panel();
            FeelFresh = new Label();
            Email = new Label();
            Password = new Label();
            EmailBox = new TextBox();
            PasswordBox = new TextBox();
            LoginButton = new Button();
            RegisterButton = new Button();
            label1 = new Label();
            label2 = new Label();
            Header.SuspendLayout();
            ControlBox.SuspendLayout();
            SuspendLayout();
            // 
            // Header
            // 
            Header.BackColor = Color.White;
            Header.Controls.Add(ApplicationHeading);
            Header.Controls.Add(ControlBox);
            Header.Location = new Point(-3, 0);
            Header.Name = "Header";
            Header.Size = new Size(838, 37);
            Header.TabIndex = 0;
            // 
            // ApplicationHeading
            // 
            ApplicationHeading.AutoSize = true;
            ApplicationHeading.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ApplicationHeading.Location = new Point(9, 9);
            ApplicationHeading.Name = "ApplicationHeading";
            ApplicationHeading.Size = new Size(186, 19);
            ApplicationHeading.TabIndex = 1;
            ApplicationHeading.Text = "<- Feel Fresh Application";
            // 
            // ControlBox
            // 
            ControlBox.Controls.Add(btnClose);
            ControlBox.Controls.Add(btnMaximize);
            ControlBox.Controls.Add(btnHide);
            ControlBox.Location = new Point(738, 0);
            ControlBox.Name = "ControlBox";
            ControlBox.Size = new Size(100, 36);
            ControlBox.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.IndianRed;
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(67, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(28, 28);
            btnClose.TabIndex = 5;
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
            btnMaximize.Location = new Point(36, 4);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(28, 28);
            btnMaximize.TabIndex = 4;
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
            btnHide.TabIndex = 3;
            btnHide.UseVisualStyleBackColor = false;
            btnHide.Click += btnHide_Click;
            // 
            // logo
            // 
            logo.BackgroundImage = (Image)resources.GetObject("logo.BackgroundImage");
            logo.BackgroundImageLayout = ImageLayout.Zoom;
            logo.Location = new Point(130, 49);
            logo.Name = "logo";
            logo.Size = new Size(154, 103);
            logo.TabIndex = 1;
            // 
            // FeelFresh
            // 
            FeelFresh.AutoSize = true;
            FeelFresh.Font = new Font("Constantia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FeelFresh.ForeColor = Color.Silver;
            FeelFresh.Location = new Point(308, 79);
            FeelFresh.Name = "FeelFresh";
            FeelFresh.Size = new Size(328, 36);
            FeelFresh.TabIndex = 2;
            FeelFresh.Text = "Welcome to Feel Fresh!";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Constantia", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Email.ForeColor = Color.Silver;
            Email.Location = new Point(288, 179);
            Email.Name = "Email";
            Email.Size = new Size(150, 23);
            Email.TabIndex = 3;
            Email.Text = "Enter your Email:";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Constantia", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password.ForeColor = Color.Silver;
            Password.Location = new Point(288, 257);
            Password.Name = "Password";
            Password.Size = new Size(182, 23);
            Password.TabIndex = 4;
            Password.Text = "Enter your password:";
            // 
            // EmailBox
            // 
            EmailBox.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailBox.Location = new Point(292, 212);
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(360, 27);
            EmailBox.TabIndex = 5;
            // 
            // PasswordBox
            // 
            PasswordBox.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordBox.Location = new Point(292, 286);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(360, 27);
            PasswordBox.TabIndex = 6;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(292, 352);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(360, 37);
            LoginButton.TabIndex = 7;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // RegisterButton
            // 
            RegisterButton.FlatStyle = FlatStyle.Flat;
            RegisterButton.ForeColor = SystemColors.ActiveCaption;
            RegisterButton.Location = new Point(364, 416);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(68, 32);
            RegisterButton.TabIndex = 8;
            RegisterButton.Text = "register";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(438, 425);
            label1.Name = "label1";
            label1.Size = new Size(160, 14);
            label1.TabIndex = 9;
            label1.Text = ", if you don't have an account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(328, 425);
            label2.Name = "label2";
            label2.Size = new Size(22, 14);
            label2.TabIndex = 10;
            label2.Text = "Or";
            // 
            // CustomerLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(835, 501);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(RegisterButton);
            Controls.Add(LoginButton);
            Controls.Add(PasswordBox);
            Controls.Add(EmailBox);
            Controls.Add(Password);
            Controls.Add(Email);
            Controls.Add(FeelFresh);
            Controls.Add(logo);
            Controls.Add(Header);
            Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerLogin";
            Text = "CustomerLogin";
            Header.ResumeLayout(false);
            Header.PerformLayout();
            ControlBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Header;
        private Panel ControlBox;
        private Button btnHide;
        private Button btnMaximize;
        private Button btnClose;
        private Label ApplicationHeading;
        private Panel logo;
        private Label FeelFresh;
        private Label Email;
        private Label Password;
        private TextBox EmailBox;
        private TextBox PasswordBox;
        private Button LoginButton;
        private Button RegisterButton;
        private Label label1;
        private Label label2;
    }
}