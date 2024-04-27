namespace GroceryManagementSystem
{
    partial class FoodCupboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodCupboard));
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
            OrderStatusButton = new Button();
            CartButton = new Button();
            FoodPanel = new Panel();
            product6 = new Panel();
            cart6 = new Button();
            label8 = new Label();
            Rice = new Label();
            product5 = new Panel();
            cart5 = new Button();
            label7 = new Label();
            Yogurt = new Label();
            product4 = new Panel();
            cart4 = new Button();
            label6 = new Label();
            Eggs = new Label();
            Product3 = new Panel();
            cart3 = new Button();
            label5 = new Label();
            Bread = new Label();
            Product2 = new Panel();
            cart2 = new Button();
            label4 = new Label();
            Water = new Label();
            Product1 = new Panel();
            Cart1 = new Button();
            label3 = new Label();
            Milk = new Label();
            label2 = new Label();
            Header.SuspendLayout();
            ControlBox.SuspendLayout();
            sidePanel.SuspendLayout();
            FoodPanel.SuspendLayout();
            product6.SuspendLayout();
            product5.SuspendLayout();
            product4.SuspendLayout();
            Product3.SuspendLayout();
            Product2.SuspendLayout();
            Product1.SuspendLayout();
            SuspendLayout();
            // 
            // Header
            // 
            Header.BorderStyle = BorderStyle.FixedSingle;
            Header.Controls.Add(ControlBox);
            Header.Controls.Add(ApplicationHeading);
            Header.Location = new Point(0, 0);
            Header.Name = "Header";
            Header.Size = new Size(871, 36);
            Header.TabIndex = 1;
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
            btnMaximize.Location = new Point(34, 4);
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
            btnHide.Location = new Point(2, 4);
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
            btnClose.Location = new Point(836, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(28, 28);
            btnClose.TabIndex = 6;
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
            sidePanel.Location = new Point(3, 113);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(210, 351);
            sidePanel.TabIndex = 7;
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
            panel1.Location = new Point(32, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 66);
            panel1.TabIndex = 10;
            // 
            // OrderStatusButton
            // 
            OrderStatusButton.BackgroundImage = (Image)resources.GetObject("OrderStatusButton.BackgroundImage");
            OrderStatusButton.BackgroundImageLayout = ImageLayout.Zoom;
            OrderStatusButton.Location = new Point(636, 49);
            OrderStatusButton.Name = "OrderStatusButton";
            OrderStatusButton.Size = new Size(107, 33);
            OrderStatusButton.TabIndex = 11;
            OrderStatusButton.UseVisualStyleBackColor = true;
            OrderStatusButton.Click += OrderStatusButton_Click;
            // 
            // CartButton
            // 
            CartButton.BackgroundImage = (Image)resources.GetObject("CartButton.BackgroundImage");
            CartButton.BackgroundImageLayout = ImageLayout.Zoom;
            CartButton.Location = new Point(755, 49);
            CartButton.Name = "CartButton";
            CartButton.Size = new Size(107, 33);
            CartButton.TabIndex = 12;
            CartButton.UseVisualStyleBackColor = true;
            CartButton.Click += CartButton_Click;
            // 
            // FoodPanel
            // 
            FoodPanel.BorderStyle = BorderStyle.FixedSingle;
            FoodPanel.Controls.Add(product6);
            FoodPanel.Controls.Add(product5);
            FoodPanel.Controls.Add(product4);
            FoodPanel.Controls.Add(Product3);
            FoodPanel.Controls.Add(Product2);
            FoodPanel.Controls.Add(Product1);
            FoodPanel.Controls.Add(label2);
            FoodPanel.Location = new Point(241, 114);
            FoodPanel.Name = "FoodPanel";
            FoodPanel.Size = new Size(605, 325);
            FoodPanel.TabIndex = 13;
            // 
            // product6
            // 
            product6.BorderStyle = BorderStyle.FixedSingle;
            product6.Controls.Add(cart6);
            product6.Controls.Add(label8);
            product6.Controls.Add(Rice);
            product6.Location = new Point(413, 177);
            product6.Name = "product6";
            product6.Size = new Size(179, 75);
            product6.TabIndex = 6;
            // 
            // cart6
            // 
            cart6.Location = new Point(16, 41);
            cart6.Name = "cart6";
            cart6.Size = new Size(144, 23);
            cart6.TabIndex = 4;
            cart6.Text = "Add to Cart";
            cart6.UseVisualStyleBackColor = true;
            cart6.Click += cart6_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(133, 9);
            label8.Name = "label8";
            label8.Size = new Size(34, 19);
            label8.TabIndex = 3;
            label8.Text = "$ 10";
            // 
            // Rice
            // 
            Rice.AutoSize = true;
            Rice.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Rice.Location = new Point(14, 9);
            Rice.Name = "Rice";
            Rice.Size = new Size(39, 19);
            Rice.TabIndex = 0;
            Rice.Text = "Rice";
            // 
            // product5
            // 
            product5.BorderStyle = BorderStyle.FixedSingle;
            product5.Controls.Add(cart5);
            product5.Controls.Add(label7);
            product5.Controls.Add(Yogurt);
            product5.Location = new Point(214, 177);
            product5.Name = "product5";
            product5.Size = new Size(179, 75);
            product5.TabIndex = 5;
            // 
            // cart5
            // 
            cart5.Location = new Point(15, 41);
            cart5.Name = "cart5";
            cart5.Size = new Size(144, 23);
            cart5.TabIndex = 7;
            cart5.Text = "Add to Cart";
            cart5.UseVisualStyleBackColor = true;
            cart5.Click += cart5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(134, 9);
            label7.Name = "label7";
            label7.Size = new Size(28, 19);
            label7.TabIndex = 3;
            label7.Text = "$ 2";
            // 
            // Yogurt
            // 
            Yogurt.AutoSize = true;
            Yogurt.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Yogurt.Location = new Point(10, 9);
            Yogurt.Name = "Yogurt";
            Yogurt.Size = new Size(56, 19);
            Yogurt.TabIndex = 0;
            Yogurt.Text = "Yogurt";
            // 
            // product4
            // 
            product4.BorderStyle = BorderStyle.FixedSingle;
            product4.Controls.Add(cart4);
            product4.Controls.Add(label6);
            product4.Controls.Add(Eggs);
            product4.Location = new Point(14, 177);
            product4.Name = "product4";
            product4.Size = new Size(179, 75);
            product4.TabIndex = 4;
            // 
            // cart4
            // 
            cart4.Location = new Point(19, 41);
            cart4.Name = "cart4";
            cart4.Size = new Size(144, 23);
            cart4.TabIndex = 4;
            cart4.Text = "Add to Cart";
            cart4.UseVisualStyleBackColor = true;
            cart4.Click += cart4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(135, 9);
            label6.Name = "label6";
            label6.Size = new Size(28, 19);
            label6.TabIndex = 3;
            label6.Text = "$ 5";
            // 
            // Eggs
            // 
            Eggs.AutoSize = true;
            Eggs.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Eggs.Location = new Point(22, 9);
            Eggs.Name = "Eggs";
            Eggs.Size = new Size(40, 19);
            Eggs.TabIndex = 0;
            Eggs.Text = "Eggs";
            // 
            // Product3
            // 
            Product3.BorderStyle = BorderStyle.FixedSingle;
            Product3.Controls.Add(cart3);
            Product3.Controls.Add(label5);
            Product3.Controls.Add(Bread);
            Product3.Location = new Point(413, 75);
            Product3.Name = "Product3";
            Product3.Size = new Size(179, 75);
            Product3.TabIndex = 3;
            // 
            // cart3
            // 
            cart3.Location = new Point(16, 46);
            cart3.Name = "cart3";
            cart3.Size = new Size(144, 23);
            cart3.TabIndex = 4;
            cart3.Text = "Add to Cart";
            cart3.UseVisualStyleBackColor = true;
            cart3.Click += cart3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(133, 11);
            label5.Name = "label5";
            label5.Size = new Size(27, 19);
            label5.TabIndex = 3;
            label5.Text = "$ 3";
            // 
            // Bread
            // 
            Bread.AutoSize = true;
            Bread.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Bread.Location = new Point(14, 11);
            Bread.Name = "Bread";
            Bread.Size = new Size(50, 19);
            Bread.TabIndex = 0;
            Bread.Text = "Bread";
            // 
            // Product2
            // 
            Product2.BorderStyle = BorderStyle.FixedSingle;
            Product2.Controls.Add(cart2);
            Product2.Controls.Add(label4);
            Product2.Controls.Add(Water);
            Product2.Location = new Point(214, 75);
            Product2.Name = "Product2";
            Product2.Size = new Size(179, 75);
            Product2.TabIndex = 2;
            // 
            // cart2
            // 
            cart2.Location = new Point(15, 46);
            cart2.Name = "cart2";
            cart2.Size = new Size(144, 23);
            cart2.TabIndex = 3;
            cart2.Text = "Add to Cart";
            cart2.UseVisualStyleBackColor = true;
            cart2.Click += cart2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(134, 11);
            label4.Name = "label4";
            label4.Size = new Size(25, 19);
            label4.TabIndex = 2;
            label4.Text = "$ 1";
            // 
            // Water
            // 
            Water.AutoSize = true;
            Water.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Water.Location = new Point(10, 11);
            Water.Name = "Water";
            Water.Size = new Size(52, 19);
            Water.TabIndex = 0;
            Water.Text = "Water";
            // 
            // Product1
            // 
            Product1.BorderStyle = BorderStyle.FixedSingle;
            Product1.Controls.Add(Cart1);
            Product1.Controls.Add(label3);
            Product1.Controls.Add(Milk);
            Product1.Location = new Point(14, 75);
            Product1.Name = "Product1";
            Product1.Size = new Size(179, 75);
            Product1.TabIndex = 1;
            // 
            // Cart1
            // 
            Cart1.Location = new Point(19, 46);
            Cart1.Name = "Cart1";
            Cart1.Size = new Size(144, 23);
            Cart1.TabIndex = 2;
            Cart1.Text = "Add to Cart";
            Cart1.UseVisualStyleBackColor = true;
            Cart1.Click += Cart1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(135, 11);
            label3.Name = "label3";
            label3.Size = new Size(28, 19);
            label3.TabIndex = 1;
            label3.Text = "$ 2";
            // 
            // Milk
            // 
            Milk.AutoSize = true;
            Milk.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Milk.Location = new Point(20, 11);
            Milk.Name = "Milk";
            Milk.Size = new Size(42, 19);
            Milk.TabIndex = 0;
            Milk.Text = "Milk";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(258, 24);
            label2.Name = "label2";
            label2.Size = new Size(137, 23);
            label2.TabIndex = 0;
            label2.Text = "Food Cupboard";
            // 
            // FoodCupboard
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 468);
            Controls.Add(FoodPanel);
            Controls.Add(CartButton);
            Controls.Add(OrderStatusButton);
            Controls.Add(panel1);
            Controls.Add(sidePanel);
            Controls.Add(btnClose);
            Controls.Add(Header);
            Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FoodCupboard";
            Text = "FoodCupboard";
            Header.ResumeLayout(false);
            Header.PerformLayout();
            ControlBox.ResumeLayout(false);
            sidePanel.ResumeLayout(false);
            sidePanel.PerformLayout();
            FoodPanel.ResumeLayout(false);
            FoodPanel.PerformLayout();
            product6.ResumeLayout(false);
            product6.PerformLayout();
            product5.ResumeLayout(false);
            product5.PerformLayout();
            product4.ResumeLayout(false);
            product4.PerformLayout();
            Product3.ResumeLayout(false);
            Product3.PerformLayout();
            Product2.ResumeLayout(false);
            Product2.PerformLayout();
            Product1.ResumeLayout(false);
            Product1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Header;
        private Panel ControlBox;
        private Label ApplicationHeading;
        private Button btnHide;
        private Button btnMaximize;
        private Button btnClose;
        private Panel sidePanel;
        private Label label1;
        private Button VegetablesButton;
        private Button FruitsButton;
        private Button FoodCupboardButton;
        private Button ProductButton;
        private Panel panel1;
        private Button OrderStatusButton;
        private Button CartButton;
        private Panel FoodPanel;
        private Panel product6;
        private Button cart6;
        private Label label8;
        private Label Rice;
        private Panel product5;
        private Button cart5;
        private Label label7;
        private Label Yogurt;
        private Panel product4;
        private Button cart4;
        private Label label6;
        private Label Eggs;
        private Panel Product3;
        private Button cart3;
        private Label label5;
        private Label Bread;
        private Panel Product2;
        private Button cart2;
        private Label label4;
        private Label Water;
        private Panel Product1;
        private Button Cart1;
        private Label label3;
        private Label Milk;
        private Label label2;
    }
}