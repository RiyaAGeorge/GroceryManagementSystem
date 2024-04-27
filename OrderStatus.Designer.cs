namespace GroceryManagementSystem
{
    partial class OrderStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderStatus));
            Header = new Panel();
            ControlBox = new Panel();
            btnMaximize = new Button();
            btnHide = new Button();
            ApplicationHeading = new Label();
            btnClose = new Button();
            sidePanel = new Panel();
            label1 = new Label();
            VegetablesButton = new Button();
            FruitsButton = new Button();
            FoodCupboardButton = new Button();
            ProductButton = new Button();
            panel1 = new Panel();
            CartButton = new Button();
            OrderStatusButton = new Button();
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            panel4 = new Panel();
            label7 = new Label();
            label8 = new Label();
            Header.SuspendLayout();
            ControlBox.SuspendLayout();
            sidePanel.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
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
            Header.TabIndex = 5;
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
            btnClose.TabIndex = 10;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // sidePanel
            // 
            sidePanel.BorderStyle = BorderStyle.FixedSingle;
            sidePanel.Controls.Add(label1);
            sidePanel.Controls.Add(VegetablesButton);
            sidePanel.Controls.Add(FruitsButton);
            sidePanel.Controls.Add(FoodCupboardButton);
            sidePanel.Controls.Add(ProductButton);
            sidePanel.Location = new Point(3, 124);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(210, 351);
            sidePanel.TabIndex = 11;
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
            // VegetablesButton
            // 
            VegetablesButton.Location = new Point(16, 245);
            VegetablesButton.Name = "VegetablesButton";
            VegetablesButton.Size = new Size(179, 42);
            VegetablesButton.TabIndex = 10;
            VegetablesButton.Text = "Vegetables";
            VegetablesButton.UseVisualStyleBackColor = true;
            VegetablesButton.Click += VegetablesButton_Click;
            // 
            // FruitsButton
            // 
            FruitsButton.Location = new Point(16, 174);
            FruitsButton.Name = "FruitsButton";
            FruitsButton.Size = new Size(179, 42);
            FruitsButton.TabIndex = 2;
            FruitsButton.Text = "Fruits";
            FruitsButton.UseVisualStyleBackColor = true;
            FruitsButton.Click += FruitsButton_Click;
            // 
            // FoodCupboardButton
            // 
            FoodCupboardButton.Location = new Point(16, 105);
            FoodCupboardButton.Name = "FoodCupboardButton";
            FoodCupboardButton.Size = new Size(179, 42);
            FoodCupboardButton.TabIndex = 1;
            FoodCupboardButton.Text = "Food Cupboard";
            FoodCupboardButton.UseVisualStyleBackColor = true;
            FoodCupboardButton.Click += FoodCupboardButton_Click;
            // 
            // ProductButton
            // 
            ProductButton.Location = new Point(16, 38);
            ProductButton.Name = "ProductButton";
            ProductButton.Size = new Size(179, 42);
            ProductButton.TabIndex = 0;
            ProductButton.Text = "All Products";
            ProductButton.UseVisualStyleBackColor = true;
            ProductButton.Click += ProductButton_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(47, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 66);
            panel1.TabIndex = 13;
            // 
            // CartButton
            // 
            CartButton.BackgroundImage = (Image)resources.GetObject("CartButton.BackgroundImage");
            CartButton.BackgroundImageLayout = ImageLayout.Zoom;
            CartButton.Location = new Point(754, 45);
            CartButton.Name = "CartButton";
            CartButton.Size = new Size(107, 33);
            CartButton.TabIndex = 18;
            CartButton.UseVisualStyleBackColor = true;
            CartButton.Click += CartButton_Click;
            // 
            // OrderStatusButton
            // 
            OrderStatusButton.BackgroundImage = (Image)resources.GetObject("OrderStatusButton.BackgroundImage");
            OrderStatusButton.BackgroundImageLayout = ImageLayout.Zoom;
            OrderStatusButton.Location = new Point(641, 45);
            OrderStatusButton.Name = "OrderStatusButton";
            OrderStatusButton.Size = new Size(107, 33);
            OrderStatusButton.TabIndex = 19;
            OrderStatusButton.UseVisualStyleBackColor = true;
            OrderStatusButton.Click += OrderStatusButton_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(231, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(618, 113);
            panel2.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(204, 66);
            label3.Name = "label3";
            label3.Size = new Size(193, 23);
            label3.TabIndex = 1;
            label3.Text = "Thursday, on 2nd May";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(201, 14);
            label2.Name = "label2";
            label2.Size = new Size(201, 26);
            label2.TabIndex = 0;
            label2.Text = "Estimated Delivery";
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Zoom;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(231, 249);
            panel4.Name = "panel4";
            panel4.RightToLeft = RightToLeft.Yes;
            panel4.Size = new Size(618, 222);
            panel4.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(73, 65);
            label7.Name = "label7";
            label7.Size = new Size(0, 14);
            label7.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Constantia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(209, 12);
            label8.Name = "label8";
            label8.Size = new Size(136, 26);
            label8.TabIndex = 0;
            label8.Text = "Order Status";
            // 
            // OrderStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 483);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(OrderStatusButton);
            Controls.Add(CartButton);
            Controls.Add(panel1);
            Controls.Add(sidePanel);
            Controls.Add(btnClose);
            Controls.Add(Header);
            Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrderStatus";
            Text = "OrderStatus";
            Header.ResumeLayout(false);
            Header.PerformLayout();
            ControlBox.ResumeLayout(false);
            sidePanel.ResumeLayout(false);
            sidePanel.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
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
        private Button VegetablesButton;
        private Button FruitsButton;
        private Button FoodCupboardButton;
        private Button ProductButton;
        private Panel panel1;
        private Button CartButton;
        private Button OrderStatusButton;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Panel panel4;
        private Label label7;
        private Label label8;
    }
}