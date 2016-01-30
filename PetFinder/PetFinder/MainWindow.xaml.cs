using System.Windows;
using PetFinder.Core.Services;

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
            // checking to see if MD5 Hash worked
            string pet = PetService.GetPet();
            MessageBox.Show(pet);
        }
    }
}
