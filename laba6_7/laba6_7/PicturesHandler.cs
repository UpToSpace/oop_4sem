using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Threading;
using System.Windows;
using Microsoft.Win32;
using System.Windows.Media.Imaging;

namespace laba6_7
{
    class PicturesHandler : ViewModelBase
    {
        private ObservableCollection<Picture> pictures;
        private Picture selectedPicture;
        private Picture newPicture;
        private Card card;
        private New NewCard;
        private int theme;

        private string path = "pictures.json";
        public PicturesHandler()
        {
            selectedPicture = new Picture();
            newPicture = new Picture();
            pictures = new ObservableCollection<Picture>();
            theme = 0;
            GetOutOfFile();
        }

        public Picture NewPicture { get => newPicture; set => newPicture = value; }
        public Picture SelectedPicture { get => selectedPicture; set => selectedPicture = value; }

        public ObservableCollection<Picture> Pictures { get => pictures;
            set 
            {
                Set(ref pictures, value);
            } }
        public void AddPicture(Picture picture)
        {
            Pictures.Add(picture);
            
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(picture));
            }
        }
        public void ShowNew()
        {
            NewCard = new New();
            NewCard.Show();
        }
        public void AddPicturePicture(Picture picture)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";
            fileDialog.ShowDialog();
            picture.Image = fileDialog.FileName;
            //if (picture.Image != null)
            //{
            //    NewCard.AddPicture.Visibility = Visibility.Hidden; // с нью херь
            //    NewCard.PictureImage.Source = new BitmapImage(new Uri(picture.Image));
            //}
        }
        public void RemovePicture(Picture picture)
        {
            Pictures.Remove(picture);
            Application.Current.Windows[Application.Current.Windows.Count - 1].Close(); // so so thing
        }

        public void MoreCard(Picture picture, ViewModel viewModel)
        {
            card = new Card();
            selectedPicture = picture;
            card.DataContext = viewModel;
            card.Show();
        }
        public void EditCard()
        {
            card.Save.Visibility = Visibility.Visible;
            card.Name.IsEnabled = true;
            card.Author.IsEnabled = true;
            card.Price.IsEnabled = true;
            card.Category.IsEnabled = true;
            card.Count.IsEnabled = true;
            card.Rating.IsEnabled = true;
        }
        public void SaveChangesCard(Picture picture)
        {
            Pictures.Remove(selectedPicture);
            Pictures.Add(picture);
            card.Save.Visibility = Visibility.Hidden;
            card.Name.IsEnabled = false;
            card.Author.IsEnabled = false;
            card.Price.IsEnabled = false;
            card.Category.IsEnabled = false;
            card.Count.IsEnabled = false;
            card.Rating.IsEnabled = false;
        }
        public void SetLanguage(string str)
        {
            if (Thread.CurrentThread.CurrentUICulture.Name != str)
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(str);
                Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(str);
                MainWindow mainWindow = new MainWindow();
                Application.Current.MainWindow.Close();
                Application.Current.MainWindow = mainWindow;
                mainWindow.Show();
            }
        }
        public void ChangeTheme()
        {
            switch (theme)
            {
                case 0:
                    Application.Current.Resources.MergedDictionaries[1].Source = new Uri("./../dictionaries/Themes/RedTheme.xaml", UriKind.RelativeOrAbsolute);
                    theme++;
                    break;
                case 1:
                    Application.Current.Resources.MergedDictionaries[1].Source = new Uri("./../dictionaries/Themes/BlueTheme.xaml", UriKind.RelativeOrAbsolute);
                    theme = 0;
                    break;
                default:
                    break;
            }
        }
        private void GetOutOfFile()
        {
            using (StreamReader sr = new StreamReader(path, false))
            {
                while (!sr.EndOfStream)
                {
                    Pictures.Add(JsonConvert.DeserializeObject<Picture>(sr.ReadLine()));
                }
            }
        }
    }
}
