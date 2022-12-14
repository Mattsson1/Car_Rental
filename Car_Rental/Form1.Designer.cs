namespace Car_Rental
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.home_Button = new System.Windows.Forms.Button();
            this.booking_Button = new System.Windows.Forms.Button();
            this.price_Button = new System.Windows.Forms.Button();
            this.setting_button = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.homePage1 = new Car_Rental.HomePage();
            this.settings1 = new Car_Rental.Settings();
            this.prices1 = new Car_Rental.Prices1();
            this.bookings1 = new Car_Rental.from_datePicker();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // home_Button
            // 
            this.home_Button.Location = new System.Drawing.Point(12, 12);
            this.home_Button.Name = "home_Button";
            this.home_Button.Size = new System.Drawing.Size(223, 49);
            this.home_Button.TabIndex = 1;
            this.home_Button.Text = "Home";
            this.home_Button.UseVisualStyleBackColor = true;
            this.home_Button.Click += new System.EventHandler(this.home_Button_Click);
            // 
            // booking_Button
            // 
            this.booking_Button.Location = new System.Drawing.Point(241, 12);
            this.booking_Button.Name = "booking_Button";
            this.booking_Button.Size = new System.Drawing.Size(223, 49);
            this.booking_Button.TabIndex = 2;
            this.booking_Button.Text = "Booking";
            this.booking_Button.UseVisualStyleBackColor = true;
            this.booking_Button.Click += new System.EventHandler(this.booking_Button_Click);
            // 
            // price_Button
            // 
            this.price_Button.Location = new System.Drawing.Point(470, 12);
            this.price_Button.Name = "price_Button";
            this.price_Button.Size = new System.Drawing.Size(223, 49);
            this.price_Button.TabIndex = 3;
            this.price_Button.Text = "Prices";
            this.price_Button.UseVisualStyleBackColor = true;
            this.price_Button.Click += new System.EventHandler(this.price_Button_Click);
            // 
            // setting_button
            // 
            this.setting_button.Location = new System.Drawing.Point(713, 12);
            this.setting_button.Name = "setting_button";
            this.setting_button.Size = new System.Drawing.Size(75, 49);
            this.setting_button.TabIndex = 4;
            this.setting_button.Text = "Settings";
            this.setting_button.UseVisualStyleBackColor = true;
            this.setting_button.Click += new System.EventHandler(this.setting_button_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.homePage1);
            this.panelContainer.Controls.Add(this.settings1);
            this.panelContainer.Controls.Add(this.prices1);
            this.panelContainer.Controls.Add(this.bookings1);
            this.panelContainer.Location = new System.Drawing.Point(12, 67);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(776, 371);
            this.panelContainer.TabIndex = 5;
            // 
            // homePage1
            // 
            this.homePage1.Location = new System.Drawing.Point(3, 3);
            this.homePage1.Name = "homePage1";
            this.homePage1.Size = new System.Drawing.Size(776, 371);
            this.homePage1.TabIndex = 2;
            // 
            // settings1
            // 
            this.settings1.Location = new System.Drawing.Point(-3, 3);
            this.settings1.Name = "settings1";
            this.settings1.Size = new System.Drawing.Size(776, 371);
            this.settings1.TabIndex = 7;
            // 
            // prices1
            // 
            this.prices1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prices1.Location = new System.Drawing.Point(0, 0);
            this.prices1.Name = "prices1";
            this.prices1.Size = new System.Drawing.Size(776, 371);
            this.prices1.TabIndex = 1;
            // 
            // bookings1
            // 
            this.bookings1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookings1.Location = new System.Drawing.Point(0, 0);
            this.bookings1.Name = "bookings1";
            this.bookings1.Size = new System.Drawing.Size(776, 371);
            this.bookings1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.setting_button);
            this.Controls.Add(this.price_Button);
            this.Controls.Add(this.booking_Button);
            this.Controls.Add(this.home_Button);
            this.Name = "Form1";
            this.Text = "Car Rental";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private Button home_Button;
        private Button booking_Button;
        private Button price_Button;
        private Button setting_button;
        private Panel panelContainer;
        private Prices1 prices1;
        private from_datePicker bookings1;
        private HomePage homePage1;
        private Settings settings1;
    }
}