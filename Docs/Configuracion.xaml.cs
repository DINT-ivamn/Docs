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

namespace Docs
{
    /// <summary>
    /// Lógica de interacción para Configuracion.xaml
    /// </summary>
    public partial class Configuracion : Window
    {
        public int Ancho { get; set; }
        public int Alto { get; set; }

        public Configuracion()
        {
            InitializeComponent();
            Ancho = Editor.Ancho;
            Alto = Editor.Alto;
            AnchoTextBox.Text = Ancho.ToString();
            AltoTextBox.Text = Alto.ToString();
        }

        private void AceptarButton_Click(object sender, RoutedEventArgs e)
        {
            Ancho = int.Parse(AnchoTextBox.Text);
            Alto = int.Parse(AltoTextBox.Text);
            DialogResult = true;
            Close();
        }
    }
}
