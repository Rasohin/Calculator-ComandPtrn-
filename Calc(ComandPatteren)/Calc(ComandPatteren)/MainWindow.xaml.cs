using Calc_ComandPatteren_.Commands;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Calc_ComandPatteren_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Calculator mycalc = new Calculator();
        char key = ' ';
        string unDo = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            mycalc.SetCommand('+', new AdditionCommand());
            mycalc.SetCommand('-', new SubtractionCommand());
            mycalc.SetCommand('*', new MultiplicationCommand());
            mycalc.SetCommand('/', new DivisionCommand());
            mycalc.SetCommand('s', new SinusCommand());
            mycalc.SetCommand('c', new CosinusCommand());
        }

        private void NumButton_Click(object sender, RoutedEventArgs e)
        {
            Button PressBtn = (Button)sender;
            calcScreen.Text += PressBtn.Content;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            calcScreen.Text = "";
        }

        private void Equality_Click(object sender, RoutedEventArgs e)
        {
            unDo = calcScreen.Text;
            //можно реализовать мульти операции, но лень ))
            try
            {
                if (!char.IsWhiteSpace(key))
                    calcScreen.Text = mycalc.calc[key].Execute(calcScreen.Text).ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
            
        }

        private void OperationBtn_Click(object sender, RoutedEventArgs e)
        {
            Button PressBtn = (Button)sender;
            //тут, как вариант можно было еще реализовать поддержку ввода операций с клавиатуры
            //в данной версии эта фича не реализована
            calcScreen.Text += PressBtn.Content;
            if(PressBtn.Content.ToString() == "sin" || PressBtn.Content.ToString() == "cos")
            {
                key = Convert.ToChar(PressBtn.Content.ToString().Remove(1));
            }
            else
                key = Convert.ToChar(PressBtn.Content);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //не придумал что реализовать в методе UnDo в ICommands,
            //поэтому пока просто возврат к последнему вводу данных
            calcScreen.Text = unDo;
        }
    }
}
