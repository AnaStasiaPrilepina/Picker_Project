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
        Label lbl, sign;
        StackLayout st;
        Entry ent;
        public horoskop()
        {
            dp = new DatePicker
            {
                Format = "D",
                Date  = DateTime.Now
            };
            dp.DateSelected += Dp_DateSelected;
            ent = new Entry
            {
                Placeholder = "Vvedi znak zodiaka"
            };
            ent.Completed += Ent_Completed;
            img = new Image { Source = "circle.png" };
            lbl = new Label
            {
                Text = "Opisanie", FontSize = 20
            };
            sign = new Label { Text = "", FontSize = 25, FontAttributes = FontAttributes.Bold};


            st = new StackLayout { Children = { dp, img/*, ent*/} };
            Content = st;
        }

        private void Ent_Completed(object sender, EventArgs e)
        {
            //Если вводим название знака в Entry/Editor, то меняются картинки и описание
            ;
        }

        private void Dp_DateSelected(object sender, DateChangedEventArgs e)
        {
            lbl.Text = "Выбранная дата: " + e.NewDate.ToString("M");
            var month = e.NewDate.Month;
            var day = e.NewDate.Day;
            st.Children.Add(sign);
            st.Children.Add(lbl);
            if (month == 3 && day >= 21 || month == 4 && day <= 20)
            {
                img.Source = "aries.png";
                sign.Text = "Овен";
                lbl.Text = "Дата: 21 марта – 20 апреля\nСтихия - огонь\nХарактеристика - амбициозный, независимый, нетерпеливый\nЦвета - ярко-красный, кармин, оранжевый, голубой, сиреневый, малиновый и все блестящие (фиолетовый цвет - неудачный)";
            }
            else if (month == 4 && day >= 21 || month == 5 && day <= 20)
            {
                img.Source = "taurus.png";
                sign.Text = "Телец";
                lbl.Text = "Дата: 21 апреля – 20 мая\nСтихия - земля\nХарактеристика - основательный, музыкальный, практичный\nЦвета - лимонный, желтый, ярко голубой, глубокий оранжевый, лимонно-зеленый, оранжевый и все весенние (красный цвет неудачный)";
            }
            else if (month == 5 && day >= 21 || month == 6 && day <= 20)
            {
                img.Source = "gemini.png";
                sign.Text = "Близнецы";
                lbl.Text = "Дата: 21 мая – 20 июня\nСтихия - воздух\nХарактеристика - любопытный, нежный, добрый\nЦвета - фиолетовый, серый, светло-желтый, серо-голубой, оранжевый (зеленый цвет - неудачный)";
            }
            else if (month == 6 && day >= 21 || month == 7 && day <= 22)
            {
                img.Source = "cancer.png";
                sign.Text = "Рак";
                lbl.Text = "Дата: 21 июня – 22 июля\nСтихия - вода\nХарактеристика - интуитивный, эмоциональный, умный, страстный\nЦвета - белый, светло-голубой, синий, серебряный, цвет зеленого горошка (серый цвет - неудачный)";
            }
            else if (month == 7 && day >= 23 || month == 8 && day <= 22)
            {
                img.Source = "leo.png";
                sign.Text = "Лев";
                lbl.Text = "Дата: 23 июля – 22 августа\nСтихия - огонь\nХарактеристика - горделивый, самоуверенный\nЦвета - пурпурный, золотой, оранжевый, алый, черный (белый цвет - неудачный)";
            }
            else if (month == 8 && day >= 23 || month == 9 && day <= 22)
            {
                img.Source = "virgo.png";
                sign.Text = "Дева";
                lbl.Text = "Дата: 23 августа – 22 сентября\nСтихия - земля\nХарактеристика - элегантный, организованный, добрый\nЦвета - белый, голубой, фиолетовый, зеленый";
            }
            else if (month == 9 && day >= 23 || month == 10 && day <= 22)
            {
                img.Source = "libra.png";
                sign.Text = "Весы";
                lbl.Text = "Дата: 23 сентября – 22 октября\nСтихия - воздух\nХарактеристика - дипломатичный, артистичный, интеллигентный\nЦвета - темно-голубой, зеленый, морской волны и пастельные тона";
            }
            else if (month == 10 && day >= 23 || month == 11 && day <= 21)
            {
                img.Source = "scorpio.png";
                sign.Text = "Скорпион";
                lbl.Text = "Дата: 23 октября – 21 ноября\nСтихия - вода\nХарактеристика - чарующий, страстный, независимый\nЦвета - желтый, темно-красный, алый, малиновый";
            }
            else if (month == 11 && day >= 22 || month == 12 && day <= 21)
            {
                img.Source = "sagittarius.png";
                sign.Text = "Стрелец";
                lbl.Text = "Дата: 22 ноября – 21 декабря\nСтихия - огонь\nХарактеристика - авантюрный, творческий, волевой\nЦвета - синий, голубой, фиолетовый, багровый";
            }
            else if (month == 12 && day >= 22 || month == 1 && day <= 19)
            {
                img.Source = "capricorn.png";
                sign.Text = "Козерог";
                lbl.Text = "Дата: 22 декабря – 19 января\nСтихия - земля\nХарактеристика - дотошный, умный, деятельный\nЦвета - темно-зеленый, черный, пепельно-серый, синий, бледно-желтый, темно-коричневый и все темные тона";
            }
            else if (month == 1 && day >= 20 || month == 2 && day <= 18)
            {
                img.Source = "aquarius.png";
                sign.Text = "Водолей";
                lbl.Text = "Дата: 20 января – 18 февраля\nСтихия - воздух\nХарактеристика - одаренный воображением, идеалистический, интуитивный\nЦвета - серый, лиловый, синезеленый, фиолетовый (черный цвет - неудачный)";
            }
            else if (month == 2 && day >= 19 || month == 3 && day <= 20)
            {
                img.Source = "pisces.png";
                sign.Text = "Рыбы";
                lbl.Text = "Дата: 19 февраля – 20 марта\nСтихия - вода\nХарактеристика - творческий, чувствительный, артистичный\nЦвета - пурпурный, фиолетовый, морской зелени, синий, лиловый, морской волны, стальной";
            }
        }
    }
}