using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace laba6_7.templates
{
    public partial class Items : ResourceDictionary
    {
        private void More_Click(object sender, RoutedEventArgs e)
        {
            Picture picture = (sender as Button).DataContext as Picture;
            Card card = new Card(picture);
            card.Show();
        }
    }
}
