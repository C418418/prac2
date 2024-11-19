using evdokimovpractice2;
using System;
using System.Collections.Generic;
using System.Windows;

namespace WeatherTranslator
{
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
                { "ветер", "wind" },
                { "облако", "cloud" },
                { "туман", "fog" },
                { "град", "hail" },
                { "молния", "lightning" },
                { "гроза", "thunderstorm" },
                { "температура", "temperature" }
            };
        }

        private void TranslateButton_Click(object sender, RoutedEventArgs e)
        {
            string input = InputTextBox.Text.Trim().ToLower();
            if (translations.TryGetValue(input, out string translation))
            {
                TranslationTextBlock.Text = translation;
            }
            else
            {
                TranslationTextBlock.Text = "Такого слова нет.";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow svo = new MainWindow();
            svo.Show();
            Close();
        }
    }
}
