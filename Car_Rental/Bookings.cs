using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental
{
    public partial class from_datePicker : UserControl
    {
        public from_datePicker()
        {
            InitializeComponent();
        }


        private void submit_Button_Click(object sender, EventArgs e)
        {
            string firstName = name_Textbox.Text;
            string lastName = lastname_Input.Text;
            string number = mobilnummer_TextBox.Text;

            //Validation

            if(string.IsNullOrWhiteSpace(firstName)|| string.IsNullOrWhiteSpace(lastName)||string.IsNullOrWhiteSpace(number))
            {
                MessageBox.Show("Fyll i alla fält");
                return;
            }

        }
    }
}
