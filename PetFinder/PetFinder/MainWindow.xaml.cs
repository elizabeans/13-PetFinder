using System.Windows;
using PetFinder.Core.Services;
using PetFinder.Core.Domain;
using System.Windows.Media.Imaging;
using System;

namespace PetFinder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void randomPetsButton_Click(object sender, RoutedEventArgs e)
        {
            Pet pet = PetService.GetPetInfo();
            randomPetOneImage.Source = GetImage(pet.image);


        }

        private BitmapImage GetImage (string imagePath)
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(imagePath, UriKind.Absolute);
            bitmap.EndInit();
            return bitmap;
        }
    }
}
