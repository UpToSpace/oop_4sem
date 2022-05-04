using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using laba6_7.Commands;


namespace laba6_7
{
    class ViewModel : ViewModelBase
    {
        PicturesHandler picturesHandler = new PicturesHandler();
        private ObservableCollection<Picture> pictures;
        public ViewModel()
        {
            pictures = picturesHandler.Pictures;
            AddPictureCommand = new RelayCommand(OnAddPictureCommandExecuted);
            AddPicturePictureCommand = new RelayCommand(o =>
            {
                Picture picture = o as Picture;
                picturesHandler.AddPicturePicture(picture);
            });
            RemovePictureCommand = new RelayCommand(o =>
           {
               Picture picture = o as Picture;
               picturesHandler.RemovePicture(picture);
           });
            OpenNewCommand = new RelayCommand(o =>
            {
                picturesHandler.ShowNew();
            });
            OpenCardCommand = new RelayCommand(o =>
            {
                Picture picture = o as Picture;
                picturesHandler.MoreCard(picture, this);
            });
            EditCardCommand = new RelayCommand(o =>
            {
                picturesHandler.EditCard();
            });
            SetLanguageCommand = new RelayCommand(o =>
            {
                string str = o as string;
                picturesHandler.SetLanguage(str);
            });
            SetThemeCommand = new RelayCommand(o =>
            {
                picturesHandler.ChangeTheme();
            });
            SaveChangesCardCommand = new RelayCommand(o =>
            {
                Picture picture = o as Picture;
                System.ComponentModel.DataAnnotations.ValidationContext contex = new System.ComponentModel.DataAnnotations.ValidationContext(picture, null, null);
                List<System.ComponentModel.DataAnnotations.ValidationResult> errors = new List<System.ComponentModel.DataAnnotations.ValidationResult>();
                if (!System.ComponentModel.DataAnnotations.Validator.TryValidateObject(picture, contex, errors, true))
                {
                    foreach (var item in errors)
                    {
                        MessageBox.Show(item.ErrorMessage);
                    }
                }
                else
                {
                    picturesHandler.SaveChangesCard(picture);
                }
            });


        }
        public System.Windows.Input.ICommand AddPictureCommand { get; }
        public System.Windows.Input.ICommand AddPicturePictureCommand { get; }
        public System.Windows.Input.ICommand RemovePictureCommand { get; }
        public System.Windows.Input.ICommand OpenNewCommand { get; }
        public System.Windows.Input.ICommand OpenCardCommand { get; }
        public System.Windows.Input.ICommand EditCardCommand { get; }
        public System.Windows.Input.ICommand SaveChangesCardCommand { get; }
        public System.Windows.Input.ICommand SetLanguageCommand { get; }
        public System.Windows.Input.ICommand SetThemeCommand { get; }

        public ObservableCollection<Picture> Pictures
        {
            get 
            {
                return pictures; 
            }
        }
        private string searchText;

        public string SearchText
        {
            get { return searchText; }
            set 
            { 
                Set(ref searchText, value);                
                pictures = new ObservableCollection<Picture>(picturesHandler.Pictures.Where(e => e.Name.Contains(SearchText)));
                OnPropertyChanged("Pictures");
            }
        }
        private int filterSlider = 0;
        public int FilterSlider
        {
            get { return filterSlider; }
            set
            {
                Set(ref filterSlider, value);
                pictures = new ObservableCollection<Picture>(picturesHandler.Pictures.Where(e => Convert.ToInt32(e.Price) < filterSlider));
                OnPropertyChanged("Pictures");
            }
        }
        public Picture NewPicture => picturesHandler.NewPicture;
        public Picture SelectedPicture => picturesHandler.SelectedPicture;

        private void OnAddPictureCommandExecuted(object o)
        {
            Picture picture = o as Picture;
            System.ComponentModel.DataAnnotations.ValidationContext contex = new System.ComponentModel.DataAnnotations.ValidationContext(picture, null, null);
            List<System.ComponentModel.DataAnnotations.ValidationResult> errors = new List<System.ComponentModel.DataAnnotations.ValidationResult>();
            if (!System.ComponentModel.DataAnnotations.Validator.TryValidateObject(picture, contex, errors, true))
            {
                foreach (var item in errors)
                {
                    MessageBox.Show(item.ErrorMessage);
                }
            }
            else if (picture.Image == null)
            {
                MessageBox.Show("Add the image");
            }
            else
            {
                picturesHandler.AddPicture(picture);
                OnPropertyChanged("Pictures");
            }
        }

        //private void OnExecuted(object o)
        //{

        //}
    }
}
