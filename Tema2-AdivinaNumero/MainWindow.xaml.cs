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

namespace Tema2_AdivinaNumero
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int numero;
        public MainWindow()
        {
            InitializeComponent();
            nuevoNumero();
        }
        private void nuevoNumero()
        {
            Random rnd = new Random();
            numero = rnd.Next(101);
        }
        private void reiniciarButton_Click(object sender, RoutedEventArgs e)
        {
            nuevoNumero();
            resultadoTextBlock.Text = " ";
        }

        private void comprobarButton_Click(object sender, RoutedEventArgs e)
        {
         int numUs = int.Parse(numeroUsuarioTextBox.Text);
            if (numUs < numero) resultadoTextBlock.Text = "Te has quedado corto";
            else if (numUs > numero) resultadoTextBlock.Text = "Te has pasado";
            else resultadoTextBlock.Text = "¡Has acertado";
        }
    }
}
