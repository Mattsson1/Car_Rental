namespace Car_Rental
{
    partial class from_datePicker
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.to_TimePicker = new System.Windows.Forms.DateTimePicker();
            this.name_Textbox = new System.Windows.Forms.TextBox();
            this.booking_text = new System.Windows.Forms.Label();
            this.firstname_Label = new System.Windows.Forms.Label();
            this.mobilnummer_TextBox = new System.Windows.Forms.TextBox();
            this.mobilnummer_Label = new System.Windows.Forms.Label();
            this.to_Label = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.from_label = new System.Windows.Forms.Label();
            this.submit_Button = new System.Windows.Forms.Button();
            this.booking_details = new System.Windows.Forms.RichTextBox();
            this.lastname_Input = new System.Windows.Forms.TextBox();
            this.lastname_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // to_TimePicker
            // 
            this.to_TimePicker.Location = new System.Drawing.Point(149, 224);
            this.to_TimePicker.Name = "to_TimePicker";
            this.to_TimePicker.Size = new System.Drawing.Size(263, 23);
            this.to_TimePicker.TabIndex = 0;
            // 
            // name_Textbox
            // 
            this.name_Textbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name_Textbox.Location = new System.Drawing.Point(149, 74);
            this.name_Textbox.Name = "name_Textbox";
            this.name_Textbox.Size = new System.Drawing.Size(187, 25);
            this.name_Textbox.TabIndex = 1;
            // 
            // booking_text
            // 
            this.booking_text.AutoSize = true;
            this.booking_text.BackColor = System.Drawing.SystemColors.Info;
            this.booking_text.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.booking_text.ForeColor = System.Drawing.SystemColors.InfoText;
            this.booking_text.Location = new System.Drawing.Point(187, 16);
            this.booking_text.Name = "booking_text";
            this.booking_text.Size = new System.Drawing.Size(400, 25);
            this.booking_text.TabIndex = 2;
            this.booking_text.Text = "Fyll i uppgifter nedan för att boka en bil";
            // 
            // firstname_Label
            // 
            this.firstname_Label.AutoSize = true;
            this.firstname_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.firstname_Label.Location = new System.Drawing.Point(49, 74);
            this.firstname_Label.Name = "firstname_Label";
            this.firstname_Label.Size = new System.Drawing.Size(94, 25);
            this.firstname_Label.TabIndex = 3;
            this.firstname_Label.Text = "Förnamn:";
            // 
            // mobilnummer_TextBox
            // 
            this.mobilnummer_TextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mobilnummer_TextBox.Location = new System.Drawing.Point(149, 165);
            this.mobilnummer_TextBox.Name = "mobilnummer_TextBox";
            this.mobilnummer_TextBox.Size = new System.Drawing.Size(187, 25);
            this.mobilnummer_TextBox.TabIndex = 4;
            // 
            // mobilnummer_Label
            // 
            this.mobilnummer_Label.AutoSize = true;
            this.mobilnummer_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mobilnummer_Label.Location = new System.Drawing.Point(3, 165);
            this.mobilnummer_Label.Name = "mobilnummer_Label";
            this.mobilnummer_Label.Size = new System.Drawing.Size(141, 25);
            this.mobilnummer_Label.TabIndex = 5;
            this.mobilnummer_Label.Text = "Mobilnummer:";
            // 
            // to_Label
            // 
            this.to_Label.AutoSize = true;
            this.to_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.to_Label.Location = new System.Drawing.Point(88, 222);
            this.to_Label.Name = "to_Label";
            this.to_Label.Size = new System.Drawing.Size(55, 25);
            this.to_Label.TabIndex = 6;
            this.to_Label.Text = "Från:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(149, 253);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(263, 23);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // from_label
            // 
            this.from_label.AutoSize = true;
            this.from_label.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.from_label.Location = new System.Drawing.Point(101, 251);
            this.from_label.Name = "from_label";
            this.from_label.Size = new System.Drawing.Size(42, 25);
            this.from_label.TabIndex = 8;
            this.from_label.Text = "Till:";
            // 
            // submit_Button
            // 
            this.submit_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.submit_Button.Location = new System.Drawing.Point(198, 282);
            this.submit_Button.Name = "submit_Button";
            this.submit_Button.Size = new System.Drawing.Size(127, 46);
            this.submit_Button.TabIndex = 9;
            this.submit_Button.Text = "Boka";
            this.submit_Button.UseVisualStyleBackColor = true;
            this.submit_Button.Click += new System.EventHandler(this.submit_Button_Click);
            // 
            // booking_details
            // 
            this.booking_details.Location = new System.Drawing.Point(487, 74);
            this.booking_details.Name = "booking_details";
            this.booking_details.Size = new System.Drawing.Size(221, 236);
            this.booking_details.TabIndex = 10;
            this.booking_details.Text = "";
            // 
            // lastname_Input
            // 
            this.lastname_Input.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastname_Input.Location = new System.Drawing.Point(149, 121);
            this.lastname_Input.Name = "lastname_Input";
            this.lastname_Input.Size = new System.Drawing.Size(187, 25);
            this.lastname_Input.TabIndex = 11;
            // 
            // lastname_Label
            // 
            this.lastname_Label.AutoSize = true;
            this.lastname_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lastname_Label.Location = new System.Drawing.Point(36, 118);
            this.lastname_Label.Name = "lastname_Label";
            this.lastname_Label.Size = new System.Drawing.Size(107, 25);
            this.lastname_Label.TabIndex = 12;
            this.lastname_Label.Text = "Efternamn:";
            // 
            // from_datePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lastname_Label);
            this.Controls.Add(this.lastname_Input);
            this.Controls.Add(this.booking_details);
            this.Controls.Add(this.submit_Button);
            this.Controls.Add(this.from_label);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.to_Label);
            this.Controls.Add(this.mobilnummer_Label);
            this.Controls.Add(this.mobilnummer_TextBox);
            this.Controls.Add(this.firstname_Label);
            this.Controls.Add(this.booking_text);
            this.Controls.Add(this.name_Textbox);
            this.Controls.Add(this.to_TimePicker);
            this.Name = "from_datePicker";
            this.Size = new System.Drawing.Size(776, 371);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker to_TimePicker;
        private TextBox name_Textbox;
        private Label booking_text;
        private Label firstname_Label;
        private TextBox mobilnummer_TextBox;
        private Label mobilnummer_Label;
        private Label to_Label;
        private DateTimePicker dateTimePicker1;
        private Label from_label;
        private Button submit_Button;
        private RichTextBox booking_details;
        private TextBox lastname_Input;
        private Label lastname_Label;
    }
}
