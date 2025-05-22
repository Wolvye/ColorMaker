
using System.Diagnostics;

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
            Debug.WriteLine(color.ToString());
            Container.BackgroundColor = color;
            lblHex.Text = color.ToHex();
            
        }

        private void btnRandom_Clicked(object sender, EventArgs e)
        {
            var random = new Random();
            
            var color = Color.FromRgb(random.Next(0,256),random.Next(0,256),random.Next(0,256));

            SetColor(color);

            sldRed.Value = color.Red;
            sldGreen.Value = color.Green;
            sldBlue.Value = color.Blue;
        }
    }
}
