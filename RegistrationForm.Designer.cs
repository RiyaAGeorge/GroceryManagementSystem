namespace GroceryManagementSystem
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            Header = new Panel();
            panel1 = new Panel();
            ApplicationHeading = new Label();
            btnHide = new Button();
            btnMaximize = new Button();
            btnClose = new Button();
            label1 = new Label();
            NameLabel = new Label();
            EmailLabel = new Label();
            AddressLabel = new Label();
            PhoneLabel = new Label();
            PasswordLabel = new Label();
            RegisterButton = new Button();
            NameTextBox = new TextBox();
            EmailTextBox = new TextBox();
            AddressTextBox = new TextBox();
            PhoneTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            Header.SuspendLayout();
            SuspendLayout();
            // 
            // Header
            // 
            Header.BackColor = Color.White;
            Header.Controls.Add(panel1);
            Header.Controls.Add(ApplicationHeading);
            Header.Location = new Point(2, 0);
            Header.Name = "Header";
            Header.Size = new Size(827, 39);
            Header.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Location = new Point(732, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(93, 39);
            panel1.TabIndex = 3;
            // 
            // ApplicationHeading
            // 
            ApplicationHeading.AutoSize = true;
            ApplicationHeading.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ApplicationHeading.Location = new Point(10, 9);
            ApplicationHeading.Name = "ApplicationHeading";
            ApplicationHeading.Size = new Size(186, 19);
            ApplicationHeading.TabIndex = 2;
            ApplicationHeading.Text = "<- Feel Fresh Application";
            // 
            // btnHide
            // 
            btnHide.BackColor = Color.NavajoWhite;
            btnHide.BackgroundImage = (Image)resources.GetObject("btnHide.BackgroundImage");
            btnHide.BackgroundImageLayout = ImageLayout.Zoom;
            btnHide.FlatAppearance.BorderSize = 0;
            btnHide.FlatStyle = FlatStyle.Flat;
            btnHide.Location = new Point(738, 6);
            btnHide.Name = "btnHide";
            btnHide.Size = new Size(28, 28);
            btnHide.TabIndex = 2;
            btnHide.UseVisualStyleBackColor = false;
            btnHide.Click += btnHide_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.BackColor = Color.YellowGreen;
            btnMaximize.BackgroundImage = (Image)resources.GetObject("btnMaximize.BackgroundImage");
            btnMaximize.BackgroundImageLayout = ImageLayout.Zoom;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Location = new Point(769, 6);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(28, 28);
            btnMaximize.TabIndex = 3;
            btnMaximize.UseVisualStyleBackColor = false;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.IndianRed;
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(800, 6);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(28, 28);
            btnClose.TabIndex = 4;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(358, 58);
            label1.Name = "label1";
            label1.Size = new Size(107, 29);
            label1.TabIndex = 5;
            label1.Text = "Register";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameLabel.ForeColor = Color.Silver;
            NameLabel.Location = new Point(238, 131);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(51, 19);
            NameLabel.TabIndex = 6;
            NameLabel.Text = "Name";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailLabel.ForeColor = Color.Silver;
            EmailLabel.Location = new Point(239, 187);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(50, 19);
            EmailLabel.TabIndex = 7;
            EmailLabel.Text = "Email";
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddressLabel.ForeColor = Color.Silver;
            AddressLabel.Location = new Point(239, 236);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(64, 19);
            AddressLabel.TabIndex = 8;
            AddressLabel.Text = "Address";
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PhoneLabel.ForeColor = Color.Silver;
            PhoneLabel.Location = new Point(239, 289);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(81, 19);
            PhoneLabel.TabIndex = 9;
            PhoneLabel.Text = "Phone No.";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordLabel.ForeColor = Color.Silver;
            PasswordLabel.Location = new Point(239, 340);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(74, 19);
            PasswordLabel.TabIndex = 10;
            PasswordLabel.Text = "Password";
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(277, 392);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(280, 37);
            RegisterButton.TabIndex = 11;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(358, 128);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(247, 22);
            NameTextBox.TabIndex = 12;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(358, 181);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(247, 22);
            EmailTextBox.TabIndex = 13;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(358, 231);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(247, 22);
            AddressTextBox.TabIndex = 14;
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(358, 282);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(247, 22);
            PhoneTextBox.TabIndex = 15;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(358, 337);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(247, 22);
            PasswordTextBox.TabIndex = 16;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(829, 466);
            Controls.Add(PasswordTextBox);
            Controls.Add(PhoneTextBox);
            Controls.Add(AddressTextBox);
            Controls.Add(EmailTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(RegisterButton);
            Controls.Add(PasswordLabel);
            Controls.Add(PhoneLabel);
            Controls.Add(AddressLabel);
            Controls.Add(EmailLabel);
            Controls.Add(NameLabel);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(btnMaximize);
            Controls.Add(btnHide);
            Controls.Add(Header);
            Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            Header.ResumeLayout(false);
            Header.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Header;
        private Label ApplicationHeading;
        private Panel panel1;
        private Button btnHide;
        private Button btnMaximize;
        private Button btnClose;
        private Label label1;
        private Label NameLabel;
        private Label EmailLabel;
        private Label AddressLabel;
        private Label PhoneLabel;
        private Label PasswordLabel;
        private Button RegisterButton;
        private TextBox NameTextBox;
        private TextBox EmailTextBox;
        private TextBox AddressTextBox;
        private TextBox PhoneTextBox;
        private TextBox PasswordTextBox;
    }
}