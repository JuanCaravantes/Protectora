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

namespace Protectora
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string usr = "admin";
        private string pass = "root";

        private MenuPrincipal menu;
        public MainWindow()
        {
            InitializeComponent();
            txtUser.Focus();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Si no se ha introducido el login
            if (String.IsNullOrEmpty(txtUser.Text)
            || String.IsNullOrEmpty(txtPass.Password))
            {
                // feedback al usuario
                stpAdvertencia.Visibility = Visibility.Visible;
                lblAdvertencia.Foreground = Brushes.Red;
                lblAdvertencia.Content = "Introduzca el usuario \ny/o la contraseña";
            }
            else
            {
                if (txtUser.Text.Equals(usr)
                && txtPass.Password.Equals(pass))
                {
                    MessageBox.Show("Usuario: " + txtUser.Text + "\nContraseña: " + txtPass.Password + "\nFecha: " + DateTime.Now.ToShortDateString(), "Info Login", MessageBoxButton.OK, MessageBoxImage.Information);
                    
                    menu = new MenuPrincipal();
                    menu.Show();

                    loginWindow.Close();
                }
                else
                {
                    txtUser.Text = "";
                    txtPass.Password = "";
                    // feedback al usuario
                    stpAdvertencia.Visibility = Visibility.Visible;
                    lblAdvertencia.Foreground = Brushes.Red;
                    lblAdvertencia.Content = "Usuario y/o contraseña \nincorrectos";
                }
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Button_Click(sender, e);
            }
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                txtPass.Focus();
            }
        }
    }
}
