using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace KFC.Windows
{
    /// <summary>
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Window
    {
        public int a;
        int sum = 0;
        Label finLable;

        public Page3()
        {
            InitializeComponent();
            finLable = finSum;
        }
        public bool GainProduct(int price, string prodName)
        {
            if (price > 0)
            {
                tbfin.AppendText(Environment.NewLine + prodName + "\t\t\t\t" + price);
                sum += price;
                return true;
            }
            return false;
        }

        public bool AcceptOrder(int money, int sum)
        {
            if (money >= sum)
            {
                // Оплата принята, заказ готовится
                money -= sum;
                return true;
            }
            // Недостаточно денег
            return false;
        }

        private void oplataButton_Click(object sender, RoutedEventArgs e)
        {
            tabControl.Visibility = Visibility.Hidden;
            UpdateItog();
        }


        #region Кнопки товаров

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GainProduct(150, "Чизбургер");
            UpdateItog();
        }

        private void UpdateItog()
        {
            finLable.Content = "Итог: " + sum;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            GainProduct(200, "Лонгер");
            UpdateItog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            GainProduct(300, "Песто бургер");
            UpdateItog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            GainProduct(330, "Шефбургер");
            UpdateItog();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            GainProduct(210, "Донат карамельный");
            UpdateItog();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            GainProduct(210, "Донат клубничный");
            UpdateItog();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            GainProduct(180, "Пирожок с вишней");
            UpdateItog();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            GainProduct(60, "Рожок с мороженным");
            UpdateItog();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            GainProduct(110, "Ай твистер");
            UpdateItog();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            GainProduct(190, "Бокс мастер");
            UpdateItog();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            GainProduct(200, "Твистер джуниор");
            UpdateItog();
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            GainProduct(180, "Хэшбраун");
            UpdateItog();
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            GainProduct(180, "Картофель по деревенски");
            UpdateItog();
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            GainProduct(220, "Картофель фри");
            UpdateItog();
        }

        #endregion
    }
}
