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
using System.Windows.Threading;

namespace FloatApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DelayCall m_delayCall;

        public MainWindow ()
        {
            InitializeComponent ();

            m_delayCall = new DelayCall ();
            m_delayCall.m_delayMS = 200;
            m_delayCall.m_callback = UpdateViewRequest;
        }

        int m_debugCount = 0;

        private void OnValueInputChanged (object sender, TextChangedEventArgs e)
        {
            decimal v = 0;

            if (decimal.TryParse (value_input.Text, out v))
            {
                value_input.Background = Brushes.White;

                m_delayCall.Call ();
            }
            else
            {
                value_input.Background = Brushes.Red;
            }
        }

        private void UpdateViewRequest ()
        {
            Dispatcher.Invoke (UpdateView);
        }

        private void UpdateView ()
        {
            Console.WriteLine ("m_debugCount = " + m_debugCount++);
            UpdateFloatView ();
            UpdateDoubleView ();
        }

        private float GetFloat ()
        {
            float value = 0;

            if (float.TryParse (value_input.Text, out value))
            {
                return value;
            }

            return 0;
        }

        private double GetDouble ()
        {
            double value = 0;

            if (double.TryParse (value_input.Text, out value))
            {
                return value;
            }

            return 0;
        }

        private void UpdateFloatView ()
        {
            var value = GetFloat ();
            var bits = Float.SingleToInt32Bits (value);
            var bitsStr = Convert.ToString (bits, 2).PadLeft (32, '0');

            float_value.Text = Convert.ToString (Float.DecodeFloat (bits));
            float_value_bits.Text = bitsStr;
        }

        private void UpdateDoubleView ()
        {
            var value = GetDouble ();
            long bits = BitConverter.DoubleToInt64Bits (value);
            var bitsStr = Convert.ToString (bits, 2).PadLeft (64, '0');

            double_value.Text = Convert.ToString (value);
            double_value_bits.Text = bitsStr;
        }
    }
}
