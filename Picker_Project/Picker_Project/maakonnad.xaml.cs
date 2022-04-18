using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Picker_Project
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class maakonnad : ContentPage
    {
        List<string> city = new List<string> { "Tallinn", "Rakvere", "Jõhvi", "Kärdla", "Haapsalu", "Rapla", "Paide", "Jõgeva", "Kuressaare", "Pärnu", "Viljandi", "Tartu", "Põlva", "Valga", "Võru" };
        List<string> maa = new List<string> { "Harjumaa", "Lääne-Virumaa", "Ida-Virumaa", "Hiiuma", "Läänemaa", "Raplamaa", "Järvamaa", "Jõgevamaa", "Saaremaa", "Pärnumaa", "Viljandimaa", "Tartumaa", "Põlvamaa", "Valgamaa", "Võrumaa" };
        Picker pick_maa, pick_city;
        Image img;
        Label label;
        //StackLayout st;
        //WebView webView;
        Entry entry;
        public maakonnad()
        {
            pick_maa = new Picker
            {
                Title = "Maakond",
                SelectedIndex = 0
            };
            pick_maa.ItemsSource = maa;
            pick_maa.SelectedIndexChanged += Pick_selectedIndexChanged;

            pick_city = new Picker
            {
                Title = "Linn",
                SelectedIndex = 0
            };
            pick_city.ItemsSource = city;
            pick_city.SelectedIndexChanged += Pick_selectedIndexChanged;

            entry = new Entry
            {
                Placeholder = "Vvedi uezd (maakond)"
            };
            entry.Completed += Entry_Completed;

            img = new Image { Source = "maakonnad.jpg" };
            label = new Label { Text = "Maakonnad ja linnad", FontSize = 20 };

            AbsoluteLayout abs = new AbsoluteLayout
            { Children = { pick_maa, pick_city, img, label/*, entry*/ } };
            AbsoluteLayout.SetLayoutBounds(pick_maa, new Rectangle(0.1, 0, 150, 50));
            AbsoluteLayout.SetLayoutFlags(pick_maa, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(pick_city, new Rectangle(0.8, 0, 150, 50));
            AbsoluteLayout.SetLayoutFlags(pick_city, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(label, new Rectangle(0.2, 0.35, 300, 50));
            AbsoluteLayout.SetLayoutFlags(label, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(img, new Rectangle(0.5, 0.1, 150, 150));
            AbsoluteLayout.SetLayoutFlags(img, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(entry, new Rectangle(0.2, 0.4, 300, 50));
            AbsoluteLayout.SetLayoutFlags(entry, AbsoluteLayoutFlags.PositionProportional);

            Content = abs;

            //Grid grid = new Grid
            //{ RowDefinitions = { new RowDefinition() }, ColumnDefinitions = { new ColumnDefinition(), new ColumnDefinition() } };
            //grid.Children.Add(pick_maa, 0, 0);
            //grid.Children.Add(pick_city, 1, 0);

            //st = new StackLayout { Children = { grid, label, img }, HorizontalOptions = LayoutOptions.CenterAndExpand, VerticalOptions = LayoutOptions.Start };
            //Content = st;
        }

        private void Entry_Completed(object sender, EventArgs e)
        {
            //Entry используем для поиска информации о уезде и отображения картики, если выбираем вариант "да" в окне PopUp
        }

        public void Info_Check()
        {
            if (pick_city.SelectedIndex == 0 || pick_maa.SelectedIndex == 0)
            {
                img.Source = "harju.png";
                label.Text = "Tallinn, Harjumaa, Põhja-Eesti";
            }
            else if (pick_city.SelectedIndex == 1 || pick_maa.SelectedIndex == 1)
            {
                img.Source = "laaneviru.png";
                label.Text = "Rakvere, Lääne-Virumaa, Kesk-Eesti";
            }
            else if (pick_city.SelectedIndex == 2 || pick_maa.SelectedIndex == 2)
            {
                img.Source = "idaviru.png";
                label.Text = "Jõhvi, Ida-Virumaa, Kirde-Eesti";
            }
            else if (pick_city.SelectedIndex == 3 || pick_maa.SelectedIndex == 3)
            {
                img.Source = "hiiu.png";
                label.Text = "Kärdla, Hiiuma, Lääne-Eesti";
            }
            else if (pick_city.SelectedIndex == 4 || pick_maa.SelectedIndex == 4)
            {
                img.Source = "laane.png";
                label.Text = "Haapsalu, Läänemaa, Lääne-Eesti";
            }
            else if (pick_city.SelectedIndex == 5 || pick_maa.SelectedIndex == 5)
            {
                img.Source = "rapla.png";
                label.Text = "Rapla, Raplamaa, Kesk-Eesti";
            }
            else if (pick_city.SelectedIndex == 6 || pick_maa.SelectedIndex == 6)
            {
                img.Source = "jarva.png";
                label.Text = "Paide, Järvamaa, Kesk-Eesti";
            }
            else if (pick_city.SelectedIndex == 7 || pick_maa.SelectedIndex == 7)
            {
                img.Source = "jogev.png";
                label.Text = "Jõgeva, Jõgevamaa, Lõuna-Eesti";
            }
            else if (pick_city.SelectedIndex == 8 || pick_maa.SelectedIndex == 8)
            {
                img.Source = "saare.png";
                label.Text = "Kuressaare, Saaremaa, Lääne-Eesti";
            }
            else if (pick_city.SelectedIndex == 9 || pick_maa.SelectedIndex == 9)
            {
                img.Source = "parnu.png";
                label.Text = "Pärnu, Pärnumaa, Lääne-Eesti";
            }
            else if (pick_city.SelectedIndex == 10 || pick_maa.SelectedIndex == 10)
            {
                img.Source = "viljandi.png";
                label.Text = "Viljandi, Viljandimaa, Lõuna-Eesti";
            }
            else if (pick_city.SelectedIndex == 11 || pick_maa.SelectedIndex == 11)
            {
                img.Source = "tartu.png";
                label.Text = "Tartu, Tartumaa, Lõuna-Eesti";
            }
            else if (pick_city.SelectedIndex == 12 || pick_maa.SelectedIndex == 12)
            {
                img.Source = "polva.png";
                label.Text = "Põlva, Põlvamaa, Lõuna-Eesti";
            }
            else if (pick_city.SelectedIndex == 13 || pick_maa.SelectedIndex == 13)
            {
                img.Source = "valga.png";
                label.Text = "Valga, Valgamaa, Lõuna-Eesti";
            }
            else if (pick_city.SelectedIndex == 14 || pick_maa.SelectedIndex == 14)
            {
                img.Source = "voru.png";
                label.Text = "Võru, Võrumaa, Lõuna-Eesti";
            }
        }

        private void Pick_selectedIndexChanged(object sender, EventArgs e)
        {
            if(sender == pick_maa)
            {
                pick_city.SelectedIndex = pick_maa.SelectedIndex;
                Info_Check();
            }
            else if(sender == pick_city)
            {
                pick_maa.SelectedIndex = pick_city.SelectedIndex;
                Info_Check();
            }
        }
    }
}