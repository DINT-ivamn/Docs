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

namespace Docs
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private int AnchoEditor { get; set; }
        private int AltoEditor { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            AnchoEditor = 500;
            AltoEditor = 500;
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Editor editor = new Editor();
            editor.Owner = this;
            editor.Title = $"Documento {OwnedWindows.Count}";
            editor.Width = AnchoEditor;
            editor.Height = AltoEditor;
            editor.Show();
        }

        private void ConfiguracionButton_Click(object sender, RoutedEventArgs e)
        {
            Configuracion configuracion = new Configuracion(AnchoEditor, AltoEditor);
            configuracion.Owner = this;
            if (configuracion.ShowDialog() == true)
            {
                AnchoEditor = configuracion.Ancho;
                AltoEditor = configuracion.Alto;
            }
        }
    }
}
