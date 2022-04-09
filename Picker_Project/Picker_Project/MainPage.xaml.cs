using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Picker_Project
{
    public partial class MainPage : ContentPage
    {
        Button maa, horo, plaan;
        public MainPage()
        {
            maa = new Button
            {
                Text = "Maakonnad",
                BackgroundColor = Color.BurlyWood,
                CornerRadius = 50,
            };
            maa.Clicked += Button_Clicked;
            horo = new Button
            {
                Text = "Horoskoop",
                BackgroundColor = Color.LightBlue,
                CornerRadius = 50,
            };
            horo.Clicked += Button_Clicked;
            plaan = new Button
            {
                Text = "Ajaplaan",
                BackgroundColor = Color.LightGreen,
                CornerRadius = 50,
            };
            plaan.Clicked += Button_Clicked;
            //StackLayout st = new StackLayout
            //{
            //    Children = { maa, horo, plaan },
            //};
            //Content = st;

            AbsoluteLayout abs = new AbsoluteLayout
            { Children = { maa, horo, plaan } };
            AbsoluteLayout.SetLayoutBounds(maa, new Rectangle(0.5, 0.2, 200, 100));
            AbsoluteLayout.SetLayoutFlags(maa, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(horo, new Rectangle(0.5, 0.5, 200, 100));
            AbsoluteLayout.SetLayoutFlags(horo, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(plaan, new Rectangle(0.5, 0.8, 200, 100));
            AbsoluteLayout.SetLayoutFlags(plaan, AbsoluteLayoutFlags.PositionProportional);
            Content = abs;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (sender == maa)
            {
                await Navigation.PushAsync(new maakonnad());
            }
            else if (sender == horo)
            {
                await Navigation.PushAsync(new horoskop());

            }
            else if (sender == plaan)
            {
                await Navigation.PushAsync(new ajaplaan());

            }
        }
    }
}
