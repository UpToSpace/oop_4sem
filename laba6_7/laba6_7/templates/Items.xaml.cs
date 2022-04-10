using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace laba6_7.templates
{
    public partial class Items : ResourceDictionary
    {
        private void More_Click(object sender, RoutedEventArgs e)
        {
            Card card = new Card();
            card.Show();
        }
    }
}
