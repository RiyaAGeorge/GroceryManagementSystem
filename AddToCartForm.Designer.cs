namespace GroceryManagementSystem
{
    partial class AddToCartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddToCartForm));
            Header = new Panel();
            ControlBox = new Panel();
            btnClose = new Button();
            btnMaximize = new Button();
            btnHide = new Button();
            ApplicationHeading = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            OrdersLabel = new Label();
            panel1 = new Panel();
            SaveButton = new Button();
            textBoxCart_ID = new TextBox();
            textBoxAmount = new TextBox();
            textBoxItemName = new TextBox();
            Cart_IDLabel = new Label();
            PriceLabel = new Label();
            ItemNameLabel = new Label();
            Header.SuspendLayout();
            ControlBox.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Header
            // 
            Header.BorderStyle = BorderStyle.FixedSingle;
            Header.Controls.Add(ControlBox);
            Header.Controls.Add(ApplicationHeading);
            Header.Location = new Point(5, 2);
            Header.Name = "Header";
            Header.Size = new Size(871, 36);
            Header.TabIndex = 10;
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
            btnClose.Location = new Point(69, 4);
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
            // panel2
            // 
            panel2.BackColor = Color.Beige;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(OrdersLabel);
            panel2.Location = new Point(1, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(879, 95);
            panel2.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Location = new Point(19, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(206, 66);
            panel3.TabIndex = 16;
            // 
            // OrdersLabel
            // 
            OrdersLabel.AutoSize = true;
            OrdersLabel.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrdersLabel.Location = new Point(392, 42);
            OrdersLabel.Name = "OrdersLabel";
            OrdersLabel.Size = new Size(100, 19);
            OrdersLabel.TabIndex = 9;
            OrdersLabel.Text = "Add To Cart";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(SaveButton);
            panel1.Controls.Add(textBoxCart_ID);
            panel1.Controls.Add(textBoxAmount);
            panel1.Controls.Add(textBoxItemName);
            panel1.Controls.Add(Cart_IDLabel);
            panel1.Controls.Add(PriceLabel);
            panel1.Controls.Add(ItemNameLabel);
            panel1.Location = new Point(51, 153);
            panel1.Name = "panel1";
            panel1.Size = new Size(778, 323);
            panel1.TabIndex = 14;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.Beige;
            SaveButton.Location = new Point(295, 221);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(207, 39);
            SaveButton.TabIndex = 8;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // textBoxCart_ID
            // 
            textBoxCart_ID.Location = new Point(230, 165);
            textBoxCart_ID.Name = "textBoxCart_ID";
            textBoxCart_ID.Size = new Size(327, 22);
            textBoxCart_ID.TabIndex = 7;
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(230, 98);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(327, 22);
            textBoxAmount.TabIndex = 5;
            // 
            // textBoxItemName
            // 
            textBoxItemName.Location = new Point(230, 32);
            textBoxItemName.Name = "textBoxItemName";
            textBoxItemName.Size = new Size(327, 22);
            textBoxItemName.TabIndex = 4;
            // 
            // Cart_IDLabel
            // 
            Cart_IDLabel.AutoSize = true;
            Cart_IDLabel.Location = new Point(46, 168);
            Cart_IDLabel.Name = "Cart_IDLabel";
            Cart_IDLabel.Size = new Size(49, 14);
            Cart_IDLabel.TabIndex = 2;
            Cart_IDLabel.Text = "Cart_ID";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new Point(49, 101);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(52, 14);
            PriceLabel.TabIndex = 1;
            PriceLabel.Text = "Amount:";
            // 
            // ItemNameLabel
            // 
            ItemNameLabel.AutoSize = true;
            ItemNameLabel.Location = new Point(44, 37);
            ItemNameLabel.Name = "ItemNameLabel";
            ItemNameLabel.Size = new Size(68, 14);
            ItemNameLabel.TabIndex = 0;
            ItemNameLabel.Text = "Item Name:";
            // 
            // AddToCartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 537);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(Header);
            Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddToCartForm";
            Text = "AddToCartForm";
            Header.ResumeLayout(false);
            Header.PerformLayout();
            ControlBox.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Header;
        private Panel ControlBox;
        private Button btnClose;
        private Button btnMaximize;
        private Button btnHide;
        private Label ApplicationHeading;
        private Panel panel2;
        private Panel panel3;
        private Label OrdersLabel;
        private Panel panel1;
        private Button SaveButton;
        private TextBox textBoxCart_ID;
        private TextBox textBoxAmount;
        private TextBox textBoxItemName;
        private Label Cart_IDLabel;
        private Label PriceLabel;
        private Label ItemNameLabel;
    }
}