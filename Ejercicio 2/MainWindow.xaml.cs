using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Ejercicio_2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        { 
            
            InitializeComponent();
        }

        private void CalcularBoton_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                switch (operadorTextBox.Text)
                {
                    case "+":
                        resultadoTextBox.Text = int.Parse(operando1TextBox.Text) + int.Parse(operando2TextBox.Text) + "";
                        break;
                    case "-":
                        resultadoTextBox.Text = int.Parse(operando1TextBox.Text) - int.Parse(operando2TextBox.Text) + "";
                        break;
                    case "*":
                        resultadoTextBox.Text = int.Parse(operando1TextBox.Text) * int.Parse(operando2TextBox.Text) + "";
                        break;
                    case "/":
                        resultadoTextBox.Text = int.Parse(operando1TextBox.Text) / int.Parse(operando2TextBox.Text) + "";
                        break;
                }
            }catch(Exception)
            {
                MessageBox.Show("Se ha producido un error. Revise los comandos");
            }
            
        }

        
        private void limpiarBoton_Click(object sender, RoutedEventArgs e)
        {
            operando1TextBox.Text = "";
            operando2TextBox.Text = "";
            operadorTextBox.Text = "";
            resultadoTextBox.Text = "";

        }

        private void operadorTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (operadorTextBox.Text == "+" || operadorTextBox.Text == "-" || operadorTextBox.Text == "*" || operadorTextBox.Text == "/")
            {
                calcularBoton.IsEnabled = true;
            }
            else 
            {
                calcularBoton.IsEnabled = false;
            }
        }
    }
}
