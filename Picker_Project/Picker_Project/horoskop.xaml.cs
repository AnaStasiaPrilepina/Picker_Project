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
    public partial class horoskop : ContentPage
    {
        DatePicker dp;
        Image img;
        Entry ent;
        //Editor editor;
        Label lbl;
        public horoskop()
        {
            dp = new DatePicker
            {
                Format = "D",
                Date = DateTime.Now,
            };
            dp.DateSelected += Dp_DateSelected;
            ent = new Entry
            {
                Placeholder = "Znak zodiaka"
            };
            ent.Completed += Ent_Completed;
            img = new Image
            {
                Source = "circle.png"
            };

            lbl = new Label
            {
                Text = "Opisanie"
            };
            StackLayout st = new StackLayout { Children = { dp, ent, img, lbl } };
            Content = st;
        }

        private void Ent_Completed(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Dp_DateSelected(object sender, DateChangedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}