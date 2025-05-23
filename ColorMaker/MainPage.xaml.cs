
using System.Diagnostics;

namespace ColorMaker
{
    public partial class MainPage : ContentPage
    {

        bool isRandom; //Einfach damit im Output kein Dauerfeuer ist
        public MainPage()
        {
            InitializeComponent();
           
        }


        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (!isRandom)
            {
                var red = (int)sldRed.Value;
                var green = (int)sldGreen.Value;
                var blue = (int)sldBlue.Value;

                lblRed.Text = red.ToString();
                lblGreen.Text = green.ToString();
                lblBlue.Text = blue.ToString();

                Color color = Color.FromRgb(red, green, blue);

                SetColor(color);
            }

        }

        private void SetColor(Color color)
        {
            Debug.WriteLine(color.ToString());
            Container.BackgroundColor = color;
            lblHex.Text = color.ToHex();

            
        }

        private void btnRandom_Clicked(object sender, EventArgs e)
        {
            isRandom = true;
            var random = new Random();

            var color = Color.FromRgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));

            SetColor(color);

            sldRed.Value = color.Red * 255;
            sldGreen.Value = color.Green * 255;
            sldBlue.Value = color.Blue * 255;
            isRandom = false;
        }
    }
}
