using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Lógica de interacción para Editor.xaml
    /// </summary>
    public partial class Editor : Window
    {
        private bool ArchivoGuardado { get; set; }

        public Editor()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!ArchivoGuardado)
            {
                MessageBoxResult result = MessageBox.Show("¿Seguro que quiere cerrar la ventana?", "Aviso",
                                MessageBoxButton.OKCancel, MessageBoxImage.Asterisk);
                if (result == MessageBoxResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            dialog.Filter = "Archivos de texto|*.txt";
            if(dialog.ShowDialog() == true)
            {
                File.WriteAllText(dialog.FileName, TextoTextBox.Text);
                ArchivoGuardado = true;
                Close();
            }
        }
    }
}
