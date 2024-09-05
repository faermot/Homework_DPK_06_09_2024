using System.Diagnostics.Eventing.Reader;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
        }
        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            string userLogin = "admin";
            string userPassword = "admin1234";

            if (string.IsNullOrEmpty(TbLogin.Text) && string.IsNullOrEmpty(PbPSW.Password))
            {
                MessageBox.Show("Логин или пароль неверный!");

            }
            else
            {
                if (TbLogin.Text == userLogin && PbPSW.Password == userPassword)
                {
                    MessageBox.Show("Вы успешно авторизованны!");
                }
                else
                {
                    MessageBox.Show("Произошла неизвестная ошибка!");
                }








            }
        }
    }
}
