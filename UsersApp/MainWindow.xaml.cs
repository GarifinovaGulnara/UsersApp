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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UsersApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = tbLogin.Text.Trim();
            string parol = pwbParol.Password.Trim();
            string parol_2 = pwbParol_2.Password.Trim();
            string email = tbEmail.Text.Trim();

            if (login.Length < 8)
            {
                tbLogin.ToolTip = "Зполните ВСЕ поля КОРРЕКТНЫМИ данными";
                tbLogin.Background = Brushes.Gray;
            }
            else if (parol.Length < 8)
            {
                pwbParol.ToolTip = "Зполните ВСЕ поля КОРРЕКТНЫМИ данными";
                pwbParol.Background = Brushes.Gray;
            }
            else if (parol != parol_2)
            {
                pwbParol_2.ToolTip = "Пароль не совпадает";
                pwbParol_2.Background = Brushes.Gray;
            }
            else if (email.Length < 5 || !email.Contains("@") || !email.Contains("."))
            {
                tbEmail.ToolTip = "Зполните ВСЕ поля КОРРЕКТНЫМИ данными";
                tbEmail.Background = Brushes.Gray;
            }
            else
            {
                tbLogin.ToolTip = "";
                tbLogin.Background = Brushes.Transparent;
                pwbParol.ToolTip = "";
                pwbParol.Background = Brushes.Transparent;
                pwbParol_2.ToolTip = "";
                pwbParol_2.Background = Brushes.Transparent;
                tbEmail.ToolTip = "";
                tbEmail.Background = Brushes.Transparent;

                MessageBox.Show("Всё хорошо");
            }
        }
    }
}
