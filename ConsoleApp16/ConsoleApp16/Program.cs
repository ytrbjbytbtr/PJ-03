using System;
using Xceed.Wpf.Toolkit;
using System.Windows;
using NuGet.Protocol.Core.Types;
using Windows.UI.Xaml;

namespace ConsoleApp16
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private readonly Personalizer personalizer = new Personalizer(new Repository());
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            bool successLogin = personalizer.Login(LoginTb.Text, PasswordTb.Text);
            MessageBox.Show(successLogin ? "Вы успешно вошли" : "Ошибка при входе");
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            bool successRegister = personalizer.Register(LoginTb.Text, PasswordTb.Text);
            MessageBox.Show(successRegister ? "Вы успешно зарегестрировались" : "Пользовтель с таким логином уже существует");
        }
    }
}
