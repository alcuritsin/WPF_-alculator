using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows;
using System.Windows.Documents;
using CalcLib;

namespace Сalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        //private CalcLogic _calc = new CalcLogic();

        private Logic _calc = new Logic();

        public MainWindow()
        {
            InitializeComponent();
            UpdateIO();
        }

        private void UpdateIO()
        {
            TextBox_IO.Text = _calc.IO;
            TextBox_History.Text = _calc.History;

            // //  Debug info
            // lb_IO.Content =
            //     $"IO: {_calc.IO}";
            // lb_history.Content =
            //     $"History: {_calc.History}";
            // lb_memory.Content =
            //     $"Memory: {_calc.Memory}";
            // lb_buffer.Content =
            //     $"Buffer: {_calc.Buffer}";
            // lb_dot.Content =
            //     $"IsDotPosible: {(_calc.IsDotPosible ? "true" : "false")}";
            // lb_new.Content =
            //     $"Operator: {_calc.Operator.ToString()}";
            // lb_oper.Content =
            //     $"Exec: {(_calc.CanExecut? "true": "false")}";
            // lb_error.Content =
            //     $"Error: {_calc.Error}";
            // //
        }

        private void Button_Add_OnClick(object sender, RoutedEventArgs e)
        {
            _calc.PushKey(KeyType.Add);
            UpdateIO();
        }

        private void Button_Sub_OnClick(object sender, RoutedEventArgs e)
        {
            _calc.PushKey(KeyType.Sub);
            UpdateIO();
        }

        private void Button_Mul_OnClick(object sender, RoutedEventArgs e)
        {
            _calc.PushKey(KeyType.Mul);
            UpdateIO();
        }

        private void Button_Div_OnClick(object sender, RoutedEventArgs e)
        {
            _calc.PushKey(KeyType.Div);
            UpdateIO();
        }

        private void Button_Enter_OnClick(object sender, RoutedEventArgs e)
        {
            _calc.PushKey(KeyType.Enter);
            UpdateIO();
        }

        private void Button_3_OnClick(object sender, RoutedEventArgs e)
        {
            _calc.PushKey(KeyType.Three);
            UpdateIO();
        }

        private void Button_6_OnClick(object sender, RoutedEventArgs e)
        {
            _calc.PushKey(KeyType.Six);
            UpdateIO();
        }

        private void Button_9_OnClick(object sender, RoutedEventArgs e)
        {
            _calc.PushKey(KeyType.Nine);
            UpdateIO();
        }

        private void Button_BackSpace_OnClick(object sender, RoutedEventArgs e)
        {
            _calc.PushKey(KeyType.BackSpace);
            UpdateIO();
        }

        private void Button_0_OnClick(object sender, RoutedEventArgs e)
        {
            _calc.PushKey(KeyType.Zero);
            UpdateIO();
        }

        private void Button_2_OnClick(object sender, RoutedEventArgs e)
        {
            _calc.PushKey(KeyType.Two);
            UpdateIO();
        }

        private void Button_5_OnClick(object sender, RoutedEventArgs e)
        {
            _calc.PushKey(KeyType.Five);
            UpdateIO();
        }

        private void Button_8_OnClick(object sender, RoutedEventArgs e)
        {
            _calc.PushKey(KeyType.Eight);
            UpdateIO();
        }

        private void Button_C_OnClick(object sender, RoutedEventArgs e)
        {
            _calc.PushKey(KeyType.C);
            UpdateIO();
        }

        private void Button_Dot_OnClick(object sender, RoutedEventArgs e)
        {
            _calc.PushKey(KeyType.Dot);
            UpdateIO();
        }

        private void Button_1_OnClick(object sender, RoutedEventArgs e)
        {
            _calc.PushKey(KeyType.One);
            UpdateIO();
        }

        private void Button_4_OnClick(object sender, RoutedEventArgs e)
        {
            _calc.PushKey(KeyType.Four);
            UpdateIO();
        }

        private void Button_7_OnClick(object sender, RoutedEventArgs e)
        {
            _calc.PushKey(KeyType.Seven);
            UpdateIO();
        }

        private void Button_CE_OnClick(object sender, RoutedEventArgs e)
        {
            _calc.PushKey(KeyType.CE);
            UpdateIO();
        }
    }
}