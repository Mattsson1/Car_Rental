namespace Car_Rental
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetActivePanel(homePage1);
        }

        private void home_Button_Click(object sender, EventArgs e)
        {
            SetActivePanel(homePage1);
        }

        public void SetActivePanel(UserControl control)
        {
            bookings1.Visible = false;
            prices1.Visible = false;
            homePage1.Visible = false;
            settings1.Visible = false;
            control.Visible = true;

        }

        private void booking_Button_Click(object sender, EventArgs e)
        {
            SetActivePanel(bookings1);
        }

        private void price_Button_Click(object sender, EventArgs e)
        {
            SetActivePanel(prices1);
        }

        private void setting_button_Click(object sender, EventArgs e)
        {
            SetActivePanel(settings1);
        }
    }
}