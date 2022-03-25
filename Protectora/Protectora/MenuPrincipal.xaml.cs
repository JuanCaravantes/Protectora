using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml;

namespace Protectora
{
    /// <summary>
    /// Lógica de interacción para MenuPrincipal.xaml
    /// </summary>
    public partial class MenuPrincipal : Window
    {
        private List<Perro> perros;
        private List<Voluntario> voluntarios;
        private List<Socio> socios;
        private List<Padrino> padrinos;

        public MenuPrincipal()
        {
            InitializeComponent();
            CargarContenidoPadrinos();
            CargarContenidoPerros();
            CargarContenidoVoluntarios();
            CargarContenidoSocios();

            lstPerros.ItemsSource = perros;
            lstVoluntarios.ItemsSource = voluntarios;
            lstSocios.ItemsSource = socios;
        }

        private void CargarContenidoPerros()
        {
            // Cargar contenido de prueba
            perros = new List<Perro>();
            XmlDocument doc = new XmlDocument();
            var fichero = Application.GetResourceStream(new Uri("Datos/perros.xml", UriKind.Relative));
            doc.Load(fichero.Stream);
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                var nuevoPerro = new Perro("", "", "", 0, 0, DateTime.Today, false, false, false, false, "", null);
                nuevoPerro.Nombre = node.Attributes["Nombre"].Value;
                nuevoPerro.Sexo = node.Attributes["Sexo"].Value;
                nuevoPerro.Raza = node.Attributes["Raza"].Value;
                nuevoPerro.Tamaño = Convert.ToDouble(node.Attributes["Tamaño"].Value);
                nuevoPerro.Edad = Convert.ToInt32(node.Attributes["Edad"].Value);
                nuevoPerro.FechaEntrada = Convert.ToDateTime(node.Attributes["FechaEntrada"].Value);
                nuevoPerro.Cachorro = Convert.ToBoolean(node.Attributes["Cachorro"].Value);
                nuevoPerro.Ppp = Convert.ToBoolean(node.Attributes["Ppp"].Value);
                nuevoPerro.Vacunado = Convert.ToBoolean(node.Attributes["Vacunado"].Value);
                nuevoPerro.Esterilizado = Convert.ToBoolean(node.Attributes["Esterilizado"].Value);
                nuevoPerro.Padrino = node.Attributes["Padrino"].Value;
                nuevoPerro.Foto = new Uri(node.Attributes["Foto"].Value, UriKind.Relative);
                perros.Add(nuevoPerro);
            }
        }

        private void CargarContenidoPadrinos()
        {
            // Cargar contenido de prueba
            padrinos = new List<Padrino>();
            XmlDocument doc = new XmlDocument();
            var fichero = Application.GetResourceStream(new Uri("Datos/padrinos.xml", UriKind.Relative));
            doc.Load(fichero.Stream);
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                var nuevoPadrino = new Padrino("", "", "", 0, 0, "", 0, "");
                nuevoPadrino.Dni = node.Attributes["Dni"].Value;
                nuevoPadrino.Nombre = node.Attributes["Nombre"].Value;
                nuevoPadrino.Apellidos = node.Attributes["Apellidos"].Value;
                nuevoPadrino.Edad = Convert.ToInt32(node.Attributes["Edad"].Value);
                nuevoPadrino.Telefono = Convert.ToInt64(node.Attributes["Telefono"].Value);
                nuevoPadrino.Email = node.Attributes["Email"].Value;
                nuevoPadrino.Aportacion = Convert.ToInt32(node.Attributes["Aportacion"].Value);
                nuevoPadrino.NumeroCuenta = node.Attributes["NumeroCuenta"].Value;
                padrinos.Add(nuevoPadrino);
            }
        }

        private void CargarContenidoVoluntarios()
        {
            // Cargar contenido de prueba
            voluntarios = new List<Voluntario>();
            XmlDocument doc = new XmlDocument();
            var fichero = Application.GetResourceStream(new Uri("Datos/voluntarios.xml", UriKind.Relative));
            doc.Load(fichero.Stream);
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                var nuevoVoluntario = new Voluntario("", "", "", 0, 0, "", false, false, null);
                nuevoVoluntario.Nombre = node.Attributes["Nombre"].Value;
                nuevoVoluntario.Apellidos = node.Attributes["Apellidos"].Value;
                nuevoVoluntario.Dni = node.Attributes["Dni"].Value;
                nuevoVoluntario.Edad = Convert.ToInt32(node.Attributes["Edad"].Value);
                nuevoVoluntario.Telefono = Convert.ToInt64(node.Attributes["Telefono"].Value);
                nuevoVoluntario.Horario = node.Attributes["Horario"].Value;
                nuevoVoluntario.ConocimientosVeterinarios = Convert.ToBoolean(node.Attributes["ConocimientosVeterinarios"].Value);
                nuevoVoluntario.Festivos = Convert.ToBoolean(node.Attributes["Festivos"].Value);
                nuevoVoluntario.Image = new Uri(node.Attributes["Image"].Value, UriKind.Relative);
                voluntarios.Add(nuevoVoluntario);
            }
        }

        private void CargarContenidoSocios()
        {
            // Cargar contenido de prueba
            socios = new List<Socio>();
            XmlDocument doc = new XmlDocument();
            var fichero = Application.GetResourceStream(new Uri("Datos/socios.xml", UriKind.Relative));
            doc.Load(fichero.Stream);
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                var nuevoSocio = new Socio("", "", "", 0, 0, "", 0, null);
                nuevoSocio.Nombre = node.Attributes["Nombre"].Value;
                nuevoSocio.Apellidos = node.Attributes["Apellidos"].Value;
                nuevoSocio.Dni = node.Attributes["Dni"].Value;
                nuevoSocio.Edad = Convert.ToInt32(node.Attributes["Edad"].Value);
                nuevoSocio.Telefono = Convert.ToInt64(node.Attributes["Telefono"].Value);
                nuevoSocio.CuentaBancaria = node.Attributes["CuentaBancaria"].Value;
                nuevoSocio.Cuantia = Convert.ToInt32(node.Attributes["Cuantia"].Value);
                nuevoSocio.Image = new Uri(node.Attributes["Image"].Value, UriKind.Relative);
                socios.Add(nuevoSocio);
            }
        }

        private Padrino obtenerPadrino(string dniPadrino)
        {
            foreach(Padrino p in padrinos)
            {
                if (p.Dni == dniPadrino)
                {
                    return p;
                }
            }

            return null;
        }

        private void btnAñadirPerro_Click(object sender, RoutedEventArgs e)
        {
            var nuevoPerro = new Perro("", "", "", 0, 0, DateTime.Today,false, false, false, false, "", new Uri("Imágenes/perroDefault.png", UriKind.Relative));
            perros.Add(nuevoPerro);
            lstPerros.Items.Refresh();
            lstPerros.SelectedIndex = perros.Count - 1;
            lstPerros.ScrollIntoView(lstPerros.Items.GetItemAt(perros.Count - 1));
        }

        private void btnEliminarPerro_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de querer eliminar este perro?", "Eliminar perro", MessageBoxButton.OKCancel, MessageBoxImage.Warning, MessageBoxResult.Cancel) == MessageBoxResult.OK)
            {
                perros.RemoveAt(lstPerros.SelectedIndex);
                lstPerros.SelectedIndex = lstPerros.Items.Count - 1;
                lstPerros.Items.Refresh();
            }
        }

        private void lstPerros_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Perro perro = (Perro)lstPerros.SelectedItem;

            if (perro.Padrino != "")
            {
                btnPadrino.Visibility = Visibility.Hidden;
                gbPadrino.IsEnabled = true;
                DataContext = obtenerPadrino(perro.Padrino);
            }
            else
            {
                btnPadrino.Visibility = Visibility.Visible;
                gbPadrino.IsEnabled = false;
                DataContext = null;
            }
        }

        private void btnImagenPerro_Click(object sender, RoutedEventArgs e)
        {
            var abrirDialog = new OpenFileDialog();
            abrirDialog.Filter = "Images|*.jpg;*.gif;*.bmp;*.png";
            if (abrirDialog.ShowDialog() == true)
            {
                try
                {
                    var foto = new Uri(abrirDialog.FileName, UriKind.Absolute);
                    perros.ElementAt(lstPerros.SelectedIndex).Foto = foto;
                    lstPerros.Items.Refresh();

                    int indice = lstPerros.SelectedIndex;

                    if (lstPerros.SelectedIndex != 0)
                    {
                        lstPerros.SelectedIndex = 0;
                    }
                    else
                    {
                        lstPerros.SelectedIndex = 1;
                    }

                    lstPerros.SelectedIndex = indice;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen " + ex.Message, "Fallo");
                }
            }
        }

        private void btnPadrino_Click(object sender, RoutedEventArgs e)
        {
            gbPadrino.IsEnabled = true;
            btnPadrino.Visibility = Visibility.Hidden;
            Random random = new Random();
            var nuevoPadrino = new Padrino(random.Next(10000000, 99999999).ToString() + (char)random.Next('A', 'Z'), "", "", 0, 0, "", 0, "");
            perros.ElementAt(lstPerros.SelectedIndex).Padrino = nuevoPadrino.Dni;
            padrinos.Add(nuevoPadrino);
            txtDniPadrino.Text = nuevoPadrino.Dni;
            DataContext = padrinos.ElementAt(padrinos.Count - 1);
        }

        private void btnImagenSocio_Click(object sender, RoutedEventArgs e)
        {
            var abrirDialog = new OpenFileDialog();
            abrirDialog.Filter = "Images|*.jpg;*.gif;*.bmp;*.png";
            if (abrirDialog.ShowDialog() == true)
            {
                try
                {
                    var foto = new Uri(abrirDialog.FileName, UriKind.Absolute);
                    socios.ElementAt(lstSocios.SelectedIndex).Image = foto;
                    lstSocios.Items.Refresh();

                    int indice = lstSocios.SelectedIndex;

                    if (lstSocios.SelectedIndex != 0)
                    {
                        lstSocios.SelectedIndex = 0;
                    }
                    else
                    {
                        lstSocios.SelectedIndex = 1;
                    }

                    lstSocios.SelectedIndex = indice;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen " + ex.Message, "Fallo");
                }
            }
        }

        private void btnAñadirSocio_Click(object sender, RoutedEventArgs e)
        {
            var nuevoSocio = new Socio("", "", "", 0, 0, "", 0, new Uri("Imágenes/personaDefault.jpg", UriKind.Relative));
            socios.Add(nuevoSocio);
            lstSocios.Items.Refresh();
            lstSocios.SelectedIndex = socios.Count - 1;
            lstSocios.ScrollIntoView(lstSocios.Items.GetItemAt(socios.Count - 1));
        }

        private void btnEliminarSocio_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de querer eliminar este socio?", "Eliminar socio", MessageBoxButton.OKCancel, MessageBoxImage.Warning, MessageBoxResult.Cancel) == MessageBoxResult.OK)
            { 
                socios.RemoveAt(lstSocios.SelectedIndex);
                lstSocios.SelectedIndex = lstSocios.Items.Count - 1;
                lstSocios.Items.Refresh();
            }
        }

        private void btnAñadirVoluntario_Click(object sender, RoutedEventArgs e)
        {
            var nuevoVoluntario = new Voluntario("", "", "", 0, 0, "", false, false, new Uri("Imágenes/personaDefault.jpg", UriKind.Relative));
            voluntarios.Add(nuevoVoluntario);
            lstVoluntarios.Items.Refresh();
            lstVoluntarios.SelectedIndex = voluntarios.Count - 1;
            lstVoluntarios.ScrollIntoView(lstVoluntarios.Items.GetItemAt(voluntarios.Count - 1));
        }

        private void btnEliminarVoluntario_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de querer eliminar este voluntario?", "Eliminar voluntario", MessageBoxButton.OKCancel, MessageBoxImage.Warning, MessageBoxResult.Cancel) == MessageBoxResult.OK)
            {
                voluntarios.RemoveAt(lstVoluntarios.SelectedIndex);
                lstVoluntarios.SelectedIndex = lstVoluntarios.Items.Count - 1;
                lstVoluntarios.Items.Refresh();
            }
        }

        private void btnImagenVoluntario_Click(object sender, RoutedEventArgs e)
        {
            var abrirDialog = new OpenFileDialog();
            abrirDialog.Filter = "Images|*.jpg;*.gif;*.bmp;*.png";
            if (abrirDialog.ShowDialog() == true)
            {
                try
                {
                    var foto = new Uri(abrirDialog.FileName, UriKind.Absolute);
                    voluntarios.ElementAt(lstVoluntarios.SelectedIndex).Image = foto;
                    lstVoluntarios.Items.Refresh();

                    int indice = lstVoluntarios.SelectedIndex;

                    if (lstVoluntarios.SelectedIndex != 0)
                    {
                        lstVoluntarios.SelectedIndex = 0;
                    }
                    else
                    {
                        lstVoluntarios.SelectedIndex = 1;
                    }

                    lstVoluntarios.SelectedIndex = indice;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen " + ex.Message, "Fallo");
                }
            }
        }

        private static readonly Regex regex = new Regex("[^0-9]+");
        private static bool IsTextAllowed(string text)
        {
            return regex.IsMatch(text);
        }

        private void txtEntero_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = IsTextAllowed(e.Text);
        }

        private static readonly Regex regexDecimales = new Regex("[^0-9.]+");
        private static bool IsTextAllowedDecimales(string text)
        {
            return regexDecimales.IsMatch(text);
        }

        private void txtDecimal_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = IsTextAllowedDecimales(e.Text) && e.Text != " ";
        }

        private void pulsarEspacio_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }
    }
}