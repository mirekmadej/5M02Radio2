namespace _5M02Radio2
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void rbRedChanged(object sender, EventArgs e)
        {
            lblNapis.TextColor = Colors.Red;
        }
        private void rbGreenChanged(object sender, EventArgs e)
        {
            lblNapis.TextColor= Colors.Green;
        }
        private void rbBlueChanged(object sender, EventArgs e)
        {
            lblNapis.TextColor = Colors.Blue;

        }


    }

}
