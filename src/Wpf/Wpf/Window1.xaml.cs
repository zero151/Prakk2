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

namespace Wpf
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private Dictionary<string, string> translations;

        public Window1()
        {
            InitializeComponent();
            InitializeTranslations();
        }

        private void InitializeTranslations()
        {
            translations = new Dictionary<string, string>
            {
                { "солнце", "sun" },
                { "дождь", "rain" },
                { "снег", "snow" },
                { "облако", "cloud" },
                { "ветер", "wind" },
                { "гроза", "thunderstorm" },
                { "туман", "fog" },
                { "светлый", "bright" },
                { "холодно", "cold" },
                { "тепло", "warm" }
            };
        }

        private void TranslateButton_Click(object sender, RoutedEventArgs e)
        {
            string userInput = InputTextBox.Text.ToLower();
            if (translations.TryGetValue(userInput, out string translation))
            {
                lb.Text = translation;
            }
            else
            {
                InputTextBox.Text = "Такого слова нет.";
            }
        }

        private void InputTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void TranslateButton_Click2(object sender, RoutedEventArgs e)
        {
            MainWindow Window = new MainWindow();
            Window.Show();
            this.Close();
        }
    }

}