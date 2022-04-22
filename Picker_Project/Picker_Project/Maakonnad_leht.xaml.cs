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
    public partial class Maakonnad_leht : ContentPage
    {
        ViewCell pickerid, kirjeldus;
        Picker pick_maa, pick_city;
        StackLayout stack, st;
        ImageCell ic;
        EntryCell ent;
        //Image img;
        Label label;
        TableSection fotosection;
        TableView tableView;
        List<string> maa = new List<string> 
        {
            "Harjumaa", "Lääne-Virumaa", "Ida-Virumaa", "Hiiuma", "Läänemaa", "Raplamaa", "Järvamaa", "Jõgevamaa", "Saaremaa", 
            "Pärnumaa", "Viljandimaa", "Tartumaa", "Põlvamaa", "Valgamaa", "Võrumaa"
        };
        List<string> city = new List<string> 
        {
            "Tallinn", "Rakvere", "Jõhvi", "Kärdla", "Haapsalu", "Rapla", "Paide", "Jõgeva", "Kuressaare", 
            "Pärnu", "Viljandi", "Tartu", "Põlva", "Valga", "Võru"
        };
        List<string> pildid = new List<string>
        {
            "harju.png", "laaneviru.png","idaviru.png","hiiu.png","laane.png", "rapla.png","jarva.png", "jogev.png","saare.png",
            "parnu.png","viljandi.png","tartu.png","polva.png","valga.png","voru.png"
        };
        List<string> opisanie = new List<string>
        {
            "Tallinn, Harjumaa, Põhja-Eesti", "Rakvere, Lääne-Virumaa, Kesk-Eesti", "Jõhvi, Ida-Virumaa, Kirde-Eesti", "Kärdla, Hiiuma, Lääne-Eesti", "Haapsalu, Läänemaa, Lääne-Eesti",
            "Rapla, Raplamaa, Kesk-Eesti", "Paide, Järvamaa, Kesk-Eesti", "Jõgeva, Jõgevamaa, Lõuna-Eesti", "Kuressaare, Saaremaa, Lääne-Eesti", "Pärnu, Pärnumaa, Lääne-Eesti", 
            "Viljandi, Viljandimaa, Lõuna-Eesti", "Tartu, Tartumaa, Lõuna-Eesti", "Põlva, Põlvamaa, Lõuna-Eesti", "Valga, Valgamaa, Lõuna-Eesti", "Võru, Võrumaa, Lõuna-Eesti"
        };
        public Maakonnad_leht()
        {

            pick_maa = new Picker
            {
                Title = "Maakonnad"
            };
            pick_city = new Picker
            {
                Title = "Linnad"
            };
            pick_maa.ItemsSource = maa;
            pick_city.ItemsSource = city;
            pick_maa.SelectedIndexChanged += Pick_selectedIndexChanged;
            pick_city.SelectedIndexChanged += Pick_selectedIndexChanged;
            stack = new StackLayout
            {
                Children = { pick_maa, pick_city },
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.StartAndExpand

            };
            pickerid = new ViewCell();
            pickerid.View = stack;

            fotosection = new TableSection();
            ic = new ImageCell
            {
                ImageSource = ImageSource.FromFile(pildid[pick_maa.SelectedIndex]),
            };

            ent = new EntryCell
            {
                Label = "Maakond:",
                Placeholder = "sisesta maakond",
                Keyboard = Keyboard.Default
            };
            ent.Completed += Ent_Completed;

            label = new Label
            {
                Text = "Kirjeldus",
                FontSize = 25
            };
            st = new StackLayout
            {
                Children = { label },
                HorizontalOptions = LayoutOptions.CenterAndExpand

            };

            ic = new ImageCell
            {
                ImageSource = "maakonnad.png",
            };

            kirjeldus = new ViewCell();
            kirjeldus.View = st;

            tableView = new TableView
            {
                Intent = TableIntent.Form,
                Root = new TableRoot("Maakonnad")
                {
                    new TableSection("Vali maakond v]i linn:")
                    {
                        pickerid
                    },
                    new TableSection("Sisesta maakond ise:")
                    {
                        ent,
                        //ic
                    },
                    fotosection,
                    new TableSection("Maakonnad ja linnad")
                    {
                        kirjeldus
                    }
                }
            };
            Content = tableView;
        }

        private void Pick_selectedIndexChanged(object sender, EventArgs e)
        {
            if (sender == pick_maa)
            {
                pick_city.SelectedIndex = pick_maa.SelectedIndex;
                ic = new ImageCell
                {
                    ImageSource = ImageSource.FromFile(pildid[pick_maa.SelectedIndex])
                };
                label.Text = opisanie[pick_maa.SelectedIndex];
            }
            else if (sender == pick_city)
            {
                pick_maa.SelectedIndex = pick_city.SelectedIndex;
                ic = new ImageCell
                {
                    ImageSource = ImageSource.FromFile(pildid[pick_maa.SelectedIndex])
                };
                label.Text = opisanie[pick_maa.SelectedIndex];
            }
        }
        private async void Ent_Completed(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("Pop-up", "Kas soovid maakonna otsida?", "Yah", "Ei");
            if (result)
            {
                if (ent.Text != null)
                {
                    fotosection.Remove(ic);
                    ic = new ImageCell
                    {
                        ImageSource = ImageSource.FromFile(pildid[pick_maa.SelectedIndex])
                    };
                    label.Text = opisanie[pick_maa.SelectedIndex];
                    fotosection.Add(ic);
                }
                else
                {
                    await DisplayAlert("Error", "Maakonda pole listis", "OK");
                    ent.Text = "";
                }
            }
            else
                ent.Text = "";
        }
    }
}