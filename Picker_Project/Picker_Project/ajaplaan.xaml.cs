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
    public partial class ajaplaan : ContentPage
    {
        TimePicker tp;
        Image img;
        Label title, lbl, label;
        StackLayout st;
        Grid grid;
        public ajaplaan()
        {
            tp = new TimePicker { Time = new TimeSpan(12,0,0) };
            tp.PropertyChanged += Tp_PropertyChanged;
            title = new Label { Text = "Распорядок дня", FontSize = 30, HorizontalOptions = LayoutOptions.CenterAndExpand, VerticalOptions = LayoutOptions.CenterAndExpand};
            img = new Image { Source = "clock.png" };
            lbl = new Label { Text = "" };
            label = new Label { Text = "" };

            st = new StackLayout { Children = { title, tp, lbl, label } };

            grid = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(2, GridUnitType.Star) }
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(1,GridUnitType.Star) }
                }
            };
            grid.Children.Add(st, 0, 0);
            grid.Children.Add(img, 0, 1);
            Content = grid;
        }

        private void Tp_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            lbl.Text = "Oli valitud aeg: " + tp.Time;
            if (e.PropertyName == TimePicker.TimeProperty.PropertyName)
            {
                time_check();
            }
        }

        public void time_check()
        {
            var time = tp.Time.Hours;
            if (time == 0)
            {
                label.Text = "Я сплю";
                img.Source = "twelve.jpg";
            }
            else if (time == 1)
            {
                label.Text = "Всё ещё сплю";
                img.Source = "one.jpg";
            }
            else if (time == 2)
            {
                label.Text = "2 часа ночи, ещё сплю";
                img.Source = "two.jpg";
            }
            else if (time == 3)
            {
                label.Text = "Спать полезно";
                img.Source = "three.jpg";
            }
            else if (time == 4)
            {
                label.Text = "Ещё немного и подъём";
                img.Source = "four.jpg";
            }
            else if (time == 5)
            {
                label.Text = "Доброе утро!";
                img.Source = "five.jpg";
            }
            else if (time == 6)
            {
                label.Text = "Время делать зарядку";
                img.Source = "six.jpg";
            }
            else if (time == 7)
            {
                label.Text = "Пора завтракать";
                img.Source = "seven.jpg";
            }
            else if (time == 8)
            {
                label.Text = "Начало рабочего дня";
                img.Source = "eight.jpg";
            }
            else if (time == 9)
            {
                label.Text = "Распределение заданий";
                img.Source = "nine.jpg";
            }
            else if (time == 10)
            {
                label.Text = "Совещание и перекус";
                img.Source = "ten.jpg";
            }
            else if (time == 11)
            {
                label.Text = "Работа не ждёт";
                img.Source = "eleven.jpg";
            }
            else if (time == 12)
            {
                label.Text = "Время обеда";
                img.Source = "twelve.jpg";
            }
            else if (time == 13)
            {
                label.Text = "Обратно за работу";
                img.Source = "one.jpg";
            }
            else if (time == 14)
            {
                label.Text = "Время консультаций";
                img.Source = "two.jpg";
            }
            else if (time == 15)
            {
                label.Text = "Делаю вид, что работаем";
                img.Source = "three.jpg";
            }
            else if (time == 16)
            {
                label.Text = "Что нового у коллег?";
                img.Source = "four.jpg";
            }
            else if (time == 17)
            {
                label.Text = "Конец рабочего дня";
                img.Source = "five.jpg";
            }
            else if (time == 18)
            {
                label.Text = "Что на ужин?";
                img.Source = "six.jpg";
            }
            else if (time == 19)
            {
                label.Text = "Включаю кино";
                img.Source = "seven.jpg";
            }
            else if (time == 20)
            {
                label.Text = "Надо бы погулять";
                img.Source = "eight.jpg";
            }
            else if (time == 21)
            {
                label.Text = "Мммм... Свежий воздух";
                img.Source = "nine.jpg";
            }
            else if (time == 22)
            {
                label.Text = "Готовлюсь ко сну";
                img.Source = "ten.jpg";
            }
            else if (time == 23)
            {
                label.Text = "Спокойной ночи!";
                img.Source = "eleven.jpg";
            }
        }
    }
}