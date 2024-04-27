namespace GroceryManagementSystem
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            header = new Panel();
            label3 = new Label();
            ControlBox = new Panel();
            btnClose = new Button();
            btnMaximize = new Button();
            btnHide = new Button();
            panel2 = new Panel();
            LoadingBar1 = new ProgressBar();
            LoadingTimer = new System.Windows.Forms.Timer(components);
            header.SuspendLayout();
            ControlBox.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // header
            // 
            header.BackColor = Color.White;
            header.Controls.Add(label3);
            header.Controls.Add(ControlBox);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(851, 44);
            header.TabIndex = 4;
            header.Paint += header_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 12);
            label3.Name = "label3";
            label3.Size = new Size(182, 19);
            label3.TabIndex = 1;
            label3.Text = "<-Feel Fresh Application";
            // 
            // ControlBox
            // 
            ControlBox.BackColor = Color.White;
            ControlBox.Controls.Add(btnClose);
            ControlBox.Location = new Point(753, 0);
            ControlBox.Name = "ControlBox";
            ControlBox.Size = new Size(98, 41);
            ControlBox.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.IndianRed;
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(67, 7);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(28, 28);
            btnClose.TabIndex = 2;
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
            btnMaximize.Location = new Point(790, 7);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(28, 28);
            btnMaximize.TabIndex = 0;
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
            btnHide.Location = new Point(760, 7);
            btnHide.Name = "btnHide";
            btnHide.Size = new Size(28, 28);
            btnHide.TabIndex = 1;
            btnHide.UseVisualStyleBackColor = false;
            btnHide.Click += btnHide_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(LoadingBar1);
            panel2.Location = new Point(12, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(827, 355);
            panel2.TabIndex = 6;
            // 
            // LoadingBar1
            // 
            LoadingBar1.ForeColor = SystemColors.ControlDarkDark;
            LoadingBar1.Location = new Point(225, 273);
            LoadingBar1.Name = "LoadingBar1";
            LoadingBar1.Size = new Size(434, 25);
            LoadingBar1.TabIndex = 0;
            LoadingBar1.Click += LoadingBar1_Click;
            // 
            // LoadingTimer
            // 
            LoadingTimer.Tick += LoadingTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(851, 496);
            Controls.Add(panel2);
            Controls.Add(btnHide);
            Controls.Add(btnMaximize);
            Controls.Add(header);
            Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Grocery Management System";
            header.ResumeLayout(false);
            header.PerformLayout();
            ControlBox.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel header;
        private Panel ControlBox;
        private Button btnMaximize;
        private Button btnClose;
        private Button btnHide;
        private Label label3;
        private Panel panel2;
        private ProgressBar LoadingBar1;
        private System.Windows.Forms.Timer LoadingTimer;
    }
}
