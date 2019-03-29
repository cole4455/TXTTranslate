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

namespace _185909ISpeakTxtMSG
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TranslateTxt_Click(object sender, RoutedEventArgs e)
            
        {
            //Will create text box and the nretreive the text
            //button will initialize

            string input = TXTInput.Text;

            //Then use replace to replace the TXT form to english
            input = input.Replace("CUZ", "Because"); Console.WriteLine(input);
            input = input.Replace("CU", "see you"); Console.WriteLine(input);
            input = input.Replace(":-)", "I'm happy"); Console.WriteLine(input);
            input = input.Replace(":-(", "I'm unhappy"); Console.WriteLine(input);
            input = input.Replace(";-)", "Wink"); Console.WriteLine(input);
            input = input.Replace(":-P", "Stick out my tounge"); Console.WriteLine(input);
            input = input.Replace("(~.~)", "Sleepy"); Console.WriteLine(input);
            input = input.Replace("TA", "Totally Awesome"); Console.WriteLine(input);
            input = input.Replace("CCC", "Canadian Computing Competition"); Console.WriteLine(input);
            input = input.Replace("TTYL", "Talk To You Later"); Console.WriteLine(input);
            input = input.Replace("TY", "Thank-you"); Console.WriteLine(input);
            input = input.Replace("YW", "You're Welcome"); Console.WriteLine(input);


            

            //Will output to textblock

            string output = input;
            TXTOutput.Content = output;

            if (TXTInput.Text.Contains("TTYL"))
            {
                MessageBox.Show("Program is now closing");
                Environment.Exit(0);
            }
        }
    }
}
