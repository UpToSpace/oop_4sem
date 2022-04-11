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

namespace laba6_7
{
    /// <summary>
    /// Логика взаимодействия для Card.xaml
    /// </summary>
    public partial class Card : Window
    {
        public Card()
        {
            InitializeComponent();
        }
        public Card(Picture picture)
        {
            InitializeComponent();
            Image.Source = new BitmapImage(new Uri(picture.Image));
            Name.Text = picture.Name;
            Author.Text = picture.Author;
            Category.Text = picture.Category;
            Rating.Text = Convert.ToString(picture.Rating);
            Price.Text = picture.Price;
            Count.Text = Convert.ToString(picture.Count);
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            Save.Visibility = Visibility.Visible;
            Name.IsEnabled = true;
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Save.Visibility = Visibility.Hidden;
            Name.IsEnabled = false;
        }
    }
}
