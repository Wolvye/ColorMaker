
namespace ColorMaker
{
    public partial class MainPage : ContentPage
    {
      

        public MainPage()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var red = (int)sldRed.Value;
            var green = (int)sldGreen.Value;
            var blue = (int)sldBlue.Value ;

            lblRed.Text = red.ToString();
            lblGreen.Text = green.ToString();
            lblBlue.Text = blue.ToString();

            Color color = Color.FromRgb(red, green, blue);

            SetColor(color);
            
        }

        private void SetColor(Color color)
        {
            btnRandom.BackgroundColor = color;
            Container.BackgroundColor = color;
            lblHex.Text = color.ToHex();
            
        }
    }
}
