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

        private string randomPetOneAge;
        private string randomPetTwoAge;
        private string randomPetThreeAge;
        private string randomPetFourAge;
        private string randomPetOneEmail;
        private string randomPetTwoEmail;
        private string randomPetThreeEmail;
        private string randomPetFourEmail;

        private void randomPetsButton_Click(object sender, RoutedEventArgs e)
        {
            randomPetsButton.Content = "Click for more pets";
            Pet randomPetOne = PetService.GetPetInfo();
            if (randomPetOne.contact.email != null)
            {
                randomPetOneEmail = randomPetOne.contact.email;
            }
            randomPetOneImage.Source = GetImage(randomPetOne.image);
            randomPetOneButton.Content = randomPetOne.name;
            randomPetOneAge = randomPetOne.age;

            Pet randomPetTwo = PetService.GetPetInfo();
            if (randomPetTwo.contact.email != null)
            {
                randomPetTwoEmail = randomPetTwo.contact.email;
            }
            randomPetTwoImage.Source = GetImage(randomPetTwo.image);
            randomPetTwoButton.Content = randomPetTwo.name;
            randomPetTwoAge = randomPetTwo.age;

            Pet randomPetThree = PetService.GetPetInfo();
            if (randomPetThree.contact.email != null)
            {
                randomPetThreeEmail = randomPetThree.contact.email;
            }
            randomPetThreeImage.Source = GetImage(randomPetThree.image);
            randomPetThreeButton.Content = randomPetThree.name;
            randomPetThreeAge = randomPetThree.age;


            Pet randomPetFour = PetService.GetPetInfo();
            if (randomPetFour.contact.email != null)
            {
                randomPetFourEmail = randomPetFour.contact.email;
            }
            randomPetFourImage.Source = GetImage(randomPetFour.image);
            randomPetFourButton.Content = randomPetFour.name;
            randomPetFourAge = randomPetFour.age;
            
        }

        private BitmapImage GetImage (string imagePath)
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(imagePath, UriKind.Absolute);
            bitmap.EndInit();
            return bitmap;
        }

        private void randomPetOneButton_Click(object sender, RoutedEventArgs e)
        {

            string message = "Hello, the pet you are interested in is named " + randomPetOneButton.Content 
                             + " , and it's age is " + randomPetOneAge + " , the contact e-mail address is " + randomPetOneEmail;
            SmsService.SendSMS("+17038640171", message);
        }

        private void randomPetTwoButton_Click(object sender, RoutedEventArgs e)
        {
            string message = "Hello, the pet you are interested in is named " + randomPetTwoButton.Content 
                             + " , and it's age is " + randomPetTwoAge + " , the contact e-mail address is " + randomPetTwoEmail;
            SmsService.SendSMS("+17038640171", message);
        }

        private void randomPetThreeButton_Click(object sender, RoutedEventArgs e)
        {
            string message = "Hello, the pet you are interested in is named " + randomPetThreeButton.Content 
                             + " , and it's age is " + randomPetThreeAge + " , the contact e-mail address is " + randomPetThreeEmail;
            SmsService.SendSMS("+17038640171", message);
        }

        private void randomPetFourButton_Click(object sender, RoutedEventArgs e)
        {
            string message = "Hello, the pet you are interested in is named " + randomPetFourButton.Content 
                             + " , and it's age is " + randomPetFourAge + " , the contact e-mail address is " + randomPetFourEmail;
            SmsService.SendSMS("+17038640171", message);
        }
    }
}
