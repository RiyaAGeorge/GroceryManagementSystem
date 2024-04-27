namespace GroceryManagementSystem
{
    partial class Payments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payments));
            Header = new Panel();
            ControlBox = new Panel();
            btnMaximize = new Button();
            btnHide = new Button();
            ApplicationHeading = new Label();
            btnClose = new Button();
            panel1 = new Panel();
            CartButton = new Button();
            OrderStatusButton = new Button();
            panel2 = new Panel();
            PlaceOrder = new Button();
            CustomerIDBox = new TextBox();
            Customer_ID = new Label();
            Online = new RadioButton();
            Cash = new RadioButton();
            label2 = new Label();
            Header.SuspendLayout();
            ControlBox.SuspendLayout();
            panel2.SuspendLayout();
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
            Header.TabIndex = 4;
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
            btnClose.TabIndex = 9;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(33, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 66);
            panel1.TabIndex = 13;
            // 
            // CartButton
            // 
            CartButton.BackgroundImage = (Image)resources.GetObject("CartButton.BackgroundImage");
            CartButton.BackgroundImageLayout = ImageLayout.Zoom;
            CartButton.Location = new Point(742, 53);
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
            OrderStatusButton.Location = new Point(624, 53);
            OrderStatusButton.Name = "OrderStatusButton";
            OrderStatusButton.Size = new Size(107, 33);
            OrderStatusButton.TabIndex = 19;
            OrderStatusButton.UseVisualStyleBackColor = true;
            OrderStatusButton.Click += OrderStatusButton_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(PlaceOrder);
            panel2.Controls.Add(CustomerIDBox);
            panel2.Controls.Add(Customer_ID);
            panel2.Controls.Add(Online);
            panel2.Controls.Add(Cash);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(24, 144);
            panel2.Name = "panel2";
            panel2.Size = new Size(827, 308);
            panel2.TabIndex = 20;
            // 
            // PlaceOrder
            // 
            PlaceOrder.Location = new Point(34, 209);
            PlaceOrder.Name = "PlaceOrder";
            PlaceOrder.Size = new Size(179, 36);
            PlaceOrder.TabIndex = 30;
            PlaceOrder.Text = "Place Order";
            PlaceOrder.UseVisualStyleBackColor = true;
            PlaceOrder.Click += PlaceOrder_Click;
            // 
            // CustomerIDBox
            // 
            CustomerIDBox.Location = new Point(578, 18);
            CustomerIDBox.Name = "CustomerIDBox";
            CustomerIDBox.Size = new Size(206, 22);
            CustomerIDBox.TabIndex = 27;
            // 
            // Customer_ID
            // 
            Customer_ID.AutoSize = true;
            Customer_ID.Location = new Point(491, 26);
            Customer_ID.Name = "Customer_ID";
            Customer_ID.Size = new Size(74, 14);
            Customer_ID.TabIndex = 24;
            Customer_ID.Text = "Customer ID";
            // 
            // Online
            // 
            Online.AutoSize = true;
            Online.Location = new Point(34, 151);
            Online.Name = "Online";
            Online.Size = new Size(110, 18);
            Online.TabIndex = 23;
            Online.TabStop = true;
            Online.Text = "Online Payment";
            Online.UseVisualStyleBackColor = true;
            // 
            // Cash
            // 
            Cash.AutoSize = true;
            Cash.BackColor = SystemColors.Control;
            Cash.Location = new Point(34, 88);
            Cash.Name = "Cash";
            Cash.Size = new Size(114, 18);
            Cash.TabIndex = 22;
            Cash.TabStop = true;
            Cash.Text = "Cash on Delivery";
            Cash.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 19);
            label2.Name = "label2";
            label2.Size = new Size(217, 23);
            label2.TabIndex = 21;
            label2.Text = "Choose Payment Method";
            // 
            // Payments
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 485);
            Controls.Add(panel2);
            Controls.Add(OrderStatusButton);
            Controls.Add(CartButton);
            Controls.Add(panel1);
            Controls.Add(btnClose);
            Controls.Add(Header);
            Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Payments";
            Text = "Payments";
            Header.ResumeLayout(false);
            Header.PerformLayout();
            ControlBox.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Button CartButton;
        private Button OrderStatusButton;
        private Panel panel2;
        private Label label2;
        private Label Customer_ID;
        private RadioButton Online;
        private RadioButton Cash;
        private Button PlaceOrder;
        private TextBox CustomerIDBox;
    }
}