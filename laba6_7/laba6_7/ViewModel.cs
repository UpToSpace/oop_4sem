using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace laba6_7
{
    class ViewModel : BindableBase
    {
        readonly PicturesHandler picturesHandler = new PicturesHandler();

        public ViewModel()
        {
            picturesHandler.PropertyChanged += (s, e) => { RaisePropertyChanged(e.PropertyName); };

            AddPictureCommand = new DelegateCommand<Picture>(picture => // проверка на валидность
            {
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
                }
            });
            AddPicturePictureCommand = new DelegateCommand<Picture>(picture =>
            {

            });
             RemovePictureCommand = new DelegateCommand<Picture>(picture =>
            {
                picturesHandler.RemovePicture(picture);
            });
            OpenNewCommand = new DelegateCommand<New>(picture =>
            {
                picturesHandler.ShowNew();
            });
            OpenCardCommand = new DelegateCommand<Picture>(picture =>
            {
                picturesHandler.MoreCard(picture, this);
            });
            EditCardCommand = new DelegateCommand<Picture>(picture =>
            {
                picturesHandler.EditCard();
            });
            SetLanguageCommand = new DelegateCommand<string>(str =>
            {
                picturesHandler.SetLanguage(str);
            });
            SaveChangesCardCommand = new DelegateCommand<Picture>(picture =>
            {
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
        public DelegateCommand<Picture> AddPictureCommand { get; }
        public DelegateCommand<Picture> AddPicturePictureCommand { get; }
        public DelegateCommand<Picture> RemovePictureCommand { get; }
        public DelegateCommand<New> OpenNewCommand { get; }
        public DelegateCommand<Picture> OpenCardCommand { get; }
        public DelegateCommand<Picture> EditCardCommand { get; }
        public DelegateCommand<Picture> SaveChangesCardCommand { get; }
        public DelegateCommand<string> SetLanguageCommand { get; }

        public ObservableCollection<Picture> Pictures => picturesHandler.Pictures;
        public Picture NewPicture => picturesHandler.NewPicture;
        public Picture SelectedPicture => picturesHandler.SelectedPicture;
    }
}
