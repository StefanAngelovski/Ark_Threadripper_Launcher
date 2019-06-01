using System.Diagnostics;
using System.Windows;

namespace Ark_Threadripper_Launcher
{
    /// <summary>
    /// Interaction logic for ModsWindow.xaml
    /// </summary>
    public partial class ModsWindow : Window
    {
        public ModsWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Launcher.LaunchWebsite("https://steamcommunity.com/sharedfiles/filedetails/?id=1726930156 ");
        }
        public static void LaunchWebsite(string url)
        {
            Process.Start(url);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //Structures Plus
        {
            Launcher.LaunchWebsite("https://steamcommunity.com/sharedfiles/filedetails/?id=731604991");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) //KRY Wardrobe
        {
            Launcher.LaunchWebsite("https://steamcommunity.com/sharedfiles/filedetails/?id=1213429840");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e) //Pimp My Home
        {
            Launcher.LaunchWebsite("https://steamcommunity.com/sharedfiles/filedetails/?id=909377464");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e) //Castles, Keeps
        {
            Launcher.LaunchWebsite("https://steamcommunity.com/sharedfiles/filedetails/?id=764755314");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e) //Domination Rex
        {
            Launcher.LaunchWebsite("https://steamcommunity.com/sharedfiles/filedetails/?id=1445395055");
        }

        private void Button_Click_6(object sender, RoutedEventArgs e) //Mysterious Mysteries
        {
            Launcher.LaunchWebsite("https://steamcommunity.com/sharedfiles/filedetails/?id=1606708617");
        }

        private void Button_Click_7(object sender, RoutedEventArgs e) //Mythical Creatures
        {
            Launcher.LaunchWebsite("https://steamcommunity.com/sharedfiles/filedetails/?id=848706943");
        }

        private void Button_Click_8(object sender, RoutedEventArgs e) //Senior Class
        {
            Launcher.LaunchWebsite("https://steamcommunity.com/sharedfiles/filedetails/?id=1662691167");
        }

        private void Button_Click_9(object sender, RoutedEventArgs e) //Small Islands
        {
            Launcher.LaunchWebsite("https://steamcommunity.com/sharedfiles/filedetails/?id=1368210526");
        }

        private void Button_Click_10(object sender, RoutedEventArgs e) //Naturalism2
        {
            Launcher.LaunchWebsite("https://steamcommunity.com/sharedfiles/filedetails/?id=797686039");
        }
    }
}
