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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontName = (string)((sender as ComboBox).SelectedItem as ComboBoxItem).Content;
            if(TextWindow != null)
            {
                TextWindow.FontFamily = new FontFamily(fontName);
            }

        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            string fontSize = (string)((sender as ComboBox).SelectedItem as ComboBoxItem).Content;
            if (TextWindow != null)
            {
                TextWindow.FontSize = Convert.ToInt32(fontSize);
            }
        }

        private void Bald_Click(object sender, RoutedEventArgs e)
        {
            if(TextWindow.FontWeight == FontWeights.Bold)
            {
                TextWindow.FontWeight = FontWeights.Normal;
            } else if(TextWindow.FontWeight == FontWeights.Normal)
            {
                TextWindow.FontWeight = FontWeights.Bold;
            }
        }

        private void Italic_Click(object sender, RoutedEventArgs e)
        {
            if (TextWindow.FontStyle == FontStyles.Italic)
            {
                TextWindow.FontStyle = FontStyles.Normal;
            }
            else if (TextWindow.FontStyle == FontStyles.Normal)
            {
                TextWindow.FontStyle = FontStyles.Italic;
            }
        }

        private void Underline_Click(object sender, RoutedEventArgs e)
        {
            if (TextWindow.TextDecorations == TextDecorations.Underline)
            {
                TextWindow.TextDecorations = null;
            }
            else
            {
                TextWindow.TextDecorations = TextDecorations.Underline;
            }
        }

        private void Black_Button_Checked(object sender, RoutedEventArgs e)
        {
            if(TextWindow != null)
            {
                TextWindow.Foreground = Brushes.Black;
            }

        }

        private void Red_Button_Checked(object sender, RoutedEventArgs e)
        {
            if (TextWindow != null)
            {
                TextWindow.Foreground = Brushes.Red;
            }
        }
    }
}
