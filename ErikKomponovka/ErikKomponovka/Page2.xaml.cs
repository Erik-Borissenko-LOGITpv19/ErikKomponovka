using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ErikKomponovka
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        bool vkl;
        public Page2()
        {
            InitializeComponent();
        }

        private async void on_Clicked(object sender, EventArgs e)
        {
            while (vkl=false)
            {
                red.BackgroundColor = Color.Red;
                yellow.BackgroundColor = Color.Gray;
                green.BackgroundColor = Color.Gray;
                await Task.Run(() => Thread.Sleep(3000));
                for (int i = 0; i < 3; i++) ;
            
                        }
            {
                red.BackgroundColor = Color.Red;
                yellow.BackgroundColor = Color.Gray;
                green.BackgroundColor = Color.Gray;
                await Task.Run(() => Thread.Sleep(500));
                yellow.BackgroundColor = Color.Yellow;

            }
            {
                red.BackgroundColor = Color.Red;
                yellow.BackgroundColor = Color.Gray;
                green.BackgroundColor = Color.Gray;
                await Task.Run(() => Thread.Sleep(3000));

            }
        }
        Random rnd = new Random();
        private void off_Clicked(object sender, EventArgs e)
        {
            red.BackgroundColor = Color.Gray;
            yellow.BackgroundColor = Color.Gray;
            green.BackgroundColor = Color.Gray;
            vkl = false;
        }

        private void Random_Clicked(object sender, EventArgs e)
        {
            int r = rnd.Next(0, 255);
            int g = rnd.Next(0, 255);
            int b = rnd.Next(0, 255);
            red.BackgroundColor = Color.FromRgb(r, g, b);
            r = rnd.Next(0, 255);
            g = rnd.Next(0, 255);
            b = rnd.Next(0, 255);
            yellow.BackgroundColor = Color.FromRgb(r, g, b);
            r = rnd.Next(0, 255);
            g = rnd.Next(0, 255);
            b = rnd.Next(0, 255);
            green.BackgroundColor = Color.FromRgb(r, g, b);
        }
        private async void My_Clicked(object sender, EventArgs e)
        {
            red.Opacity = 0.5;
            Yelow.CornerRadius = 0;
            green.Text = "My Random choose.";
            int r = rnd.Next(0, 255);
            int g = rnd.Next(0, 255);
            int b = rnd.Next(0, 255);
            Gren.BorderColor = Color.FromRgb(r, g, b);
            Gren.HasShadow = true;
            bool answer = await DisplayAlert("Change color", "Do you want change the color? New color red:" + r.ToString() + "Green:" + g.ToString() + "blue:" + b.ToString(), "Yes", "No");
            if (answer)
            {
                Fon.BackgroundColor = Color.FromRgb(r, g, b);    
            }
            else
            {
                Fon.BackgroundColor = Color.FromRgb(r, g, b);
            }
        }
}
}
