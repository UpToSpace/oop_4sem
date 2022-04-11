using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Xaml;

namespace laba6_7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BindingList<Picture> pictures;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void New_Click(object sender, RoutedEventArgs e)
        {
            New Card = new New();
            Card.Show();
        }

        private void mainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            pictures = new BindingList<Picture>()
            {
                new Picture(){Rating = 2, Name = "hey", Author="dali", Category="j", Count=1, Image=@"D:\University\4\oop\laba6_7\laba6_7\pictures\memory.png", Price="3000", ShortName="hey"}
            };
            PictureList.ItemsSource = pictures;

        }
    }
}
