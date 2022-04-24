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
    class PicturesHandler : BindableBase
    {
        private ObservableCollection<Picture> pictures;
        private Picture selectedPicture;
        private Picture newPicture;
        private Card card;
        private New New;

        private string path = "pictures.json";
        public PicturesHandler()
        {
            pictures = new ObservableCollection<Picture>();
            selectedPicture = new Picture();
            newPicture = new Picture();

            using (StreamReader sr = new StreamReader(path))
            {
                while(!sr.EndOfStream)
                {
                    pictures.Add(JsonConvert.DeserializeObject<Picture>(sr.ReadLine()));
                }
            }
        }

        public ObservableCollection<Picture> Pictures { get => pictures; set => pictures = value; }
        public Picture NewPicture { get => newPicture; set => newPicture = value; }
        public Picture SelectedPicture { get => selectedPicture; set => selectedPicture = value; }

        public void AddPicture(Picture picture)
        {
            pictures.Add(picture);
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(picture));
            }
            //RaisePropertyChanged("AddPicture");
        }
        public void ShowNew()
        {
            New = new New();
            New.Show();
        }
        public void AddPicturePicture(Picture picture)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";
            fileDialog.ShowDialog();
            picture.Image = fileDialog.FileName;
            if (picture.Image != null)
            {
                New.AddPicture.Visibility = Visibility.Hidden; // с нью херь
                New.PictureImage.Source = new BitmapImage(new Uri(picture.Image));
            }
        }
        public void RemovePicture(Picture picture)
        {
            pictures.Remove(picture);
            //RaisePropertyChanged("RemovePicture");
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
            pictures.Remove(selectedPicture);
            pictures.Add(picture);
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
    }
}
