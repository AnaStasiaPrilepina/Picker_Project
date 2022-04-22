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
        Image imgMaa, imgHoro, imgPlaan;
        public MainPage()
        {
            maa = new Button
            {
                Text = "Maakonnad",
                BackgroundColor = Color.BurlyWood,
                CornerRadius = 50,
                FontSize = 20,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            maa.Clicked += Button_Clicked;
            imgMaa = new Image { Source = "maakonnad.png" };
            horo = new Button
            {
                Text = "Horoskoop",
                BackgroundColor = Color.LightBlue,
                CornerRadius = 50,
                FontSize = 20,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            horo.Clicked += Button_Clicked;
            imgHoro = new Image { Source = "circle.png" };
            plaan = new Button
            {
                Text = "Ajaplaan",
                BackgroundColor = Color.LightGreen,
                CornerRadius = 50,
                FontSize = 20,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            plaan.Clicked += Button_Clicked;
            imgPlaan = new Image { Source = "clock.png" };

            Grid grid = new Grid
            {
                RowDefinitions = { new RowDefinition(), new RowDefinition(), new RowDefinition() },
                ColumnDefinitions = { new ColumnDefinition(), new ColumnDefinition() },
            };
            grid.Children.Add(maa, 0, 0);
            grid.Children.Add(horo, 0, 1);
            grid.Children.Add(plaan, 0, 2);

            grid.Children.Add(imgMaa, 1, 0);
            grid.Children.Add(imgHoro, 1, 1);
            grid.Children.Add(imgPlaan, 1, 2);
            Content = grid;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (sender == maa)
            {
                await Navigation.PushAsync(new maakonnad());
                //await Navigation.PushAsync(new Maakonnad_leht());
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
