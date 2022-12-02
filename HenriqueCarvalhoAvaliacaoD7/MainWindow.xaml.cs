using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
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

namespace HenriqueCarvalhoAvaliacaoD7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            db = new();
            InitializeComponent();
        }

        Database db;

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            bool auth = Handlers.LoginHandler(db, usernameInput.Text, passwordInput.Text);
            Shader.Visibility = Visibility.Visible;
            if (auth)
            {
                AuthSuccessfulPopup.Visibility = Visibility.Visible;
            }
            else
            {
                AuthFailurePopup.Visibility = Visibility.Visible;
            }
        }
    }
}
