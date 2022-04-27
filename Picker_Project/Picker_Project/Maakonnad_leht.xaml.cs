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
        //TableSection fotosection;
        TableView tableView;
        string[] maa = new string [15]
        {
            "Harjumaa", "Lääne-Virumaa", "Ida-Virumaa", "Hiiuma", "Läänemaa", "Raplamaa", "Järvamaa", "Jõgevamaa", "Saaremaa", 
            "Pärnumaa", "Viljandimaa", "Tartumaa", "Põlvamaa", "Valgamaa", "Võrumaa"
        };
        string[] linn = new string[15]
        {
            "Tallinn", "Rakvere", "Jõhvi", "Kärdla", "Haapsalu", "Rapla", "Paide", "Jõgeva", "Kuressaare", 
            "Pärnu", "Viljandi", "Tartu", "Põlva", "Valga", "Võru"
        };
        string[] foto = new string[15]
        {
            "harju.png", "laaneviru.png","idaviru.png","hiiu.png","laane.png", "rapla.png","jarva.png", "jogev.png","saare.png",
            "parnu.png","viljandi.png","tartu.png","polva.png","valga.png","voru.png"
        };
        string[] opisanie = new string[15]
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
            pick_maa.ItemsSource = maa;
            pick_maa.SelectedIndexChanged += Pick_selectedIndexChanged;

            pick_city = new Picker
            {
                Title = "Linnad",
            };
            pick_city.ItemsSource = linn;
            pick_city.SelectedIndexChanged += Pick_selectedIndexChanged;

            stack = new StackLayout
            {
                Children = { pick_maa, pick_city },
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            pickerid = new ViewCell();
            pickerid.View = stack;

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

            kirjeldus = new ViewCell();
            kirjeldus.View = st;

            ic = new ImageCell();

            tableView = new TableView
            {
                RowHeight = 60,
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
                        ic
                    },
                    new TableSection("Maakonnad ja linnad")
                    {
                        kirjeldus
                    }
                }
            };
            Content = tableView;
        }

        private void Ent_Completed(object sender, EventArgs e)
        {

        }

        private void Pick_selectedIndexChanged(object sender, EventArgs e)
        {
            if (sender == pick_maa)
            {
                pick_city.SelectedIndex = pick_maa.SelectedIndex;
                ic = new ImageCell
                {
                    ImageSource = ImageSource.FromFile(foto[pick_maa.SelectedIndex])
                };
                label.Text = opisanie[pick_maa.SelectedIndex];
            }
            else if (sender == pick_city)
            {
                pick_maa.SelectedIndex = pick_city.SelectedIndex;
                //ic = new ImageCell
                //{
                //    ImageSource = ImageSource.FromFile(foto[pick_city.SelectedIndex])
                //};
                //label.Text = opisanie[pick_city.SelectedIndex];
            }
        }
        
    }
}