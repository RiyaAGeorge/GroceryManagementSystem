namespace GroceryManagementSystem
{
    partial class RoleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoleForm));
            header1 = new Panel();
            label1 = new Label();
            ControlBox1 = new Panel();
            btnClose = new Button();
            btnMaximize = new Button();
            btnHide = new Button();
            panel1 = new Panel();
            RoleChoose = new Label();
            panel2 = new Panel();
            StaffButton = new Button();
            panel3 = new Panel();
            ShopperButton = new Button();
            header1.SuspendLayout();
            ControlBox1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // header1
            // 
            header1.BackColor = Color.White;
            header1.Controls.Add(label1);
            header1.Location = new Point(-3, -2);
            header1.Name = "header1";
            header1.Size = new Size(804, 41);
            header1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 12);
            label1.Name = "label1";
            label1.Size = new Size(186, 19);
            label1.TabIndex = 0;
            label1.Text = "<- Feel Fresh Application";
            // 
            // ControlBox1
            // 
            ControlBox1.BackColor = Color.White;
            ControlBox1.Controls.Add(btnClose);
            ControlBox1.Controls.Add(btnMaximize);
            ControlBox1.Controls.Add(btnHide);
            ControlBox1.Location = new Point(696, 0);
            ControlBox1.Name = "ControlBox1";
            ControlBox1.Size = new Size(104, 38);
            ControlBox1.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.IndianRed;
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(70, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(28, 28);
            btnClose.TabIndex = 4;
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
            btnMaximize.Location = new Point(38, 5);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(28, 28);
            btnMaximize.TabIndex = 3;
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
            btnHide.Location = new Point(5, 5);
            btnHide.Name = "btnHide";
            btnHide.Size = new Size(28, 28);
            btnHide.TabIndex = 2;
            btnHide.UseVisualStyleBackColor = false;
            btnHide.Click += btnHide_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Location = new Point(30, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(742, 217);
            panel1.TabIndex = 2;
            // 
            // RoleChoose
            // 
            RoleChoose.AutoSize = true;
            RoleChoose.Font = new Font("Constantia", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RoleChoose.ForeColor = Color.Silver;
            RoleChoose.Location = new Point(288, 269);
            RoleChoose.Name = "RoleChoose";
            RoleChoose.Size = new Size(238, 26);
            RoleChoose.TabIndex = 3;
            RoleChoose.Text = "Sign in to your account as";
            // 
            // panel2
            // 
            panel2.Controls.Add(StaffButton);
            panel2.Location = new Point(177, 314);
            panel2.Name = "panel2";
            panel2.Size = new Size(206, 166);
            panel2.TabIndex = 4;
            // 
            // StaffButton
            // 
            StaffButton.BackgroundImage = (Image)resources.GetObject("StaffButton.BackgroundImage");
            StaffButton.BackgroundImageLayout = ImageLayout.Zoom;
            StaffButton.Location = new Point(45, 15);
            StaffButton.Name = "StaffButton";
            StaffButton.Size = new Size(137, 137);
            StaffButton.TabIndex = 0;
            StaffButton.UseVisualStyleBackColor = true;
            StaffButton.Click += StaffButton_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(ShopperButton);
            panel3.Location = new Point(398, 315);
            panel3.Name = "panel3";
            panel3.Size = new Size(206, 166);
            panel3.TabIndex = 5;
            // 
            // ShopperButton
            // 
            ShopperButton.BackgroundImage = (Image)resources.GetObject("ShopperButton.BackgroundImage");
            ShopperButton.BackgroundImageLayout = ImageLayout.Zoom;
            ShopperButton.Location = new Point(42, 15);
            ShopperButton.Name = "ShopperButton";
            ShopperButton.Size = new Size(136, 137);
            ShopperButton.TabIndex = 1;
            ShopperButton.UseVisualStyleBackColor = true;
            ShopperButton.Click += ShopperButton_Click;
            // 
            // RoleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(798, 498);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(RoleChoose);
            Controls.Add(panel1);
            Controls.Add(ControlBox1);
            Controls.Add(header1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RoleForm";
            Text = "<- Feel Fresh Application";
            header1.ResumeLayout(false);
            header1.PerformLayout();
            ControlBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel header1;
        private Panel ControlBox1;
        private Button btnHide;
        private Button btnMaximize;
        private Label label1;
        private Button btnClose;
        private Panel panel1;
        private Label RoleChoose;
        private Panel panel2;
        private Panel panel3;
        private Button StaffButton;
        private Button ShopperButton;
    }
}