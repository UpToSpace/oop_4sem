using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.IO;
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
    /// Логика взаимодействия для New.xaml
    /// </summary>
    public partial class New : Window
    {
        public New()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        //private void AddPicture_Click(object sender, RoutedEventArgs e)
        //{
        //    OpenFileDialog fileDialog = new OpenFileDialog();
        //    fileDialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";
        //    fileDialog.ShowDialog();
        //    picture.Image = fileDialog.FileName;
        //    if (picture.Image != null)
        //    {
        //        AddPicture.Visibility = Visibility.Hidden;
        //        PictureImage.Source = new BitmapImage(new Uri(picture.Image));
        //    }
        //}
    }
}
