﻿namespace GroceryManagementSystem
{
    partial class EditOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditOrder));
            Header = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            OrdersLabel = new Label();
            ControlBox = new Panel();
            btnClose = new Button();
            btnMaximize = new Button();
            btnHide = new Button();
            ApplicationHeading = new Label();
            panel1 = new Panel();
            panel4 = new Panel();
            EditOrdersLabel = new Label();
            panel5 = new Panel();
            SaveButton = new Button();
            textBoxTotAmount = new TextBox();
            textBoxCustomer_ID = new TextBox();
            textBoxStatus = new TextBox();
            textBoxDate = new TextBox();
            CustomerIDLabel = new Label();
            TotalAmountLabel = new Label();
            OrderStatusLabel = new Label();
            OrdDateLabel = new Label();
            Header.SuspendLayout();
            panel2.SuspendLayout();
            ControlBox.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // Header
            // 
            Header.BorderStyle = BorderStyle.FixedSingle;
            Header.Controls.Add(panel2);
            Header.Controls.Add(ControlBox);
            Header.Controls.Add(ApplicationHeading);
            Header.Location = new Point(1, 0);
            Header.Name = "Header";
            Header.Size = new Size(871, 36);
            Header.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Beige;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(OrdersLabel);
            panel2.Location = new Point(-5, 54);
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
            OrdersLabel.Size = new Size(90, 19);
            OrdersLabel.TabIndex = 9;
            OrdersLabel.Text = "Add Order";
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
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(EditOrdersLabel);
            panel1.Location = new Point(-3, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(879, 95);
            panel1.TabIndex = 13;
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Zoom;
            panel4.Location = new Point(19, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(206, 66);
            panel4.TabIndex = 16;
            // 
            // EditOrdersLabel
            // 
            EditOrdersLabel.AutoSize = true;
            EditOrdersLabel.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditOrdersLabel.Location = new Point(392, 42);
            EditOrdersLabel.Name = "EditOrdersLabel";
            EditOrdersLabel.Size = new Size(90, 19);
            EditOrdersLabel.TabIndex = 9;
            EditOrdersLabel.Text = "Edit Order";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(SaveButton);
            panel5.Controls.Add(textBoxTotAmount);
            panel5.Controls.Add(textBoxCustomer_ID);
            panel5.Controls.Add(textBoxStatus);
            panel5.Controls.Add(textBoxDate);
            panel5.Controls.Add(CustomerIDLabel);
            panel5.Controls.Add(TotalAmountLabel);
            panel5.Controls.Add(OrderStatusLabel);
            panel5.Controls.Add(OrdDateLabel);
            panel5.Location = new Point(47, 147);
            panel5.Name = "panel5";
            panel5.Size = new Size(778, 323);
            panel5.TabIndex = 14;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.Beige;
            SaveButton.Location = new Point(302, 233);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(207, 39);
            SaveButton.TabIndex = 8;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // textBoxTotAmount
            // 
            textBoxTotAmount.Location = new Point(230, 126);
            textBoxTotAmount.Name = "textBoxTotAmount";
            textBoxTotAmount.Size = new Size(327, 22);
            textBoxTotAmount.TabIndex = 7;
            // 
            // textBoxCustomer_ID
            // 
            textBoxCustomer_ID.Location = new Point(230, 170);
            textBoxCustomer_ID.Name = "textBoxCustomer_ID";
            textBoxCustomer_ID.Size = new Size(327, 22);
            textBoxCustomer_ID.TabIndex = 6;
            // 
            // textBoxStatus
            // 
            textBoxStatus.Location = new Point(230, 79);
            textBoxStatus.Name = "textBoxStatus";
            textBoxStatus.Size = new Size(327, 22);
            textBoxStatus.TabIndex = 5;
            // 
            // textBoxDate
            // 
            textBoxDate.Location = new Point(230, 32);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.Size = new Size(327, 22);
            textBoxDate.TabIndex = 4;
            // 
            // CustomerIDLabel
            // 
            CustomerIDLabel.AutoSize = true;
            CustomerIDLabel.Location = new Point(44, 178);
            CustomerIDLabel.Name = "CustomerIDLabel";
            CustomerIDLabel.Size = new Size(77, 14);
            CustomerIDLabel.TabIndex = 3;
            CustomerIDLabel.Text = "Customer ID:";
            // 
            // TotalAmountLabel
            // 
            TotalAmountLabel.AutoSize = true;
            TotalAmountLabel.Location = new Point(44, 134);
            TotalAmountLabel.Name = "TotalAmountLabel";
            TotalAmountLabel.Size = new Size(80, 14);
            TotalAmountLabel.TabIndex = 2;
            TotalAmountLabel.Text = "Total Amount:";
            // 
            // OrderStatusLabel
            // 
            OrderStatusLabel.AutoSize = true;
            OrderStatusLabel.Location = new Point(44, 87);
            OrderStatusLabel.Name = "OrderStatusLabel";
            OrderStatusLabel.Size = new Size(78, 14);
            OrderStatusLabel.TabIndex = 1;
            OrderStatusLabel.Text = "Order Status:";
            // 
            // OrdDateLabel
            // 
            OrdDateLabel.AutoSize = true;
            OrdDateLabel.Location = new Point(44, 37);
            OrdDateLabel.Name = "OrdDateLabel";
            OrdDateLabel.Size = new Size(71, 14);
            OrdDateLabel.TabIndex = 0;
            OrdDateLabel.Text = "Order Date:";
            // 
            // EditOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 486);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(Header);
            Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditOrder";
            Text = "EditOrder";
            Header.ResumeLayout(false);
            Header.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ControlBox.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
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
        private Panel panel4;
        private Label EditOrdersLabel;
        private Panel panel5;
        private Button SaveButton;
        private TextBox textBoxTotAmount;
        private TextBox textBoxCustomer_ID;
        private TextBox textBoxStatus;
        private TextBox textBoxDate;
        private Label CustomerIDLabel;
        private Label TotalAmountLabel;
        private Label OrderStatusLabel;
        private Label OrdDateLabel;
    }
}