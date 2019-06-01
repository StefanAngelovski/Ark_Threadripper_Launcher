using Ark_Threadripper_Launcher.Properties;
using AutoUpdaterDotNET;
using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;

namespace Ark_Threadripper_Launcher
{
    public partial class MainWindow : Window, INotifyPropertyChanged

    {
        public MainWindow()
        {
            InitializeComponent();
            bool check = AutoUpdateCheck.IsChecked.GetValueOrDefault(false);
            AutoUpdateCheck.IsChecked = Settings.Default.CheckBox;
            if (AutoUpdate == true)
                AutoUpdater.Start("https://www.dropbox.com/s/rdkn2ie547cs9kr/UpdateData.xml?dl=1");
        }
        bool buttonPressed = false;
        bool AutoUpdate = false;
        public string Link { get; set; }
        public static string TextDir { get; set; }

        private void Button_Click(object sender, RoutedEventArgs e) //Play Button
        {
            Launcher.LaunchWebsite(Link);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) ///Scorched Earth
        {
            Background.Source = new BitmapImage(new Uri("pack://application:,,,/ArkThreadripperLauncher;component/Resources/ScorchedEarth.png", UriKind.Absolute));
            Link = "steam://connect/yukitsuki.com:27017";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e) //Screenshots
        {
            try
            {
                var rootDir = @"C:\Program Files (x86)\Steam\userdata\";
                var userDir = Directory.EnumerateDirectories(rootDir).First();
                var userSubDir = Path.Combine(userDir, "760");
                var remoteDir = Path.Combine(userSubDir, "remote");
                var remoteSubDir = Path.Combine(remoteDir, "346110");
                var screenshotsDir = Path.Combine(remoteSubDir, "screenshots");
                Directory.Exists(screenshotsDir);
                System.Diagnostics.Process.Start(screenshotsDir);
            }
            catch
            {
                try
                {
                    var settings = new Settings();
                    SettingsTextBar.Text = settings.SettingsValue;
                    System.Diagnostics.Process.Start(TextDir);
                }
                catch (Exception)
                {
                    Error f3 = new Error();
                    f3.ShowDialog();
                }
            }
        }


        private void Button_Click_4(object sender, RoutedEventArgs e) ///Website Button
        {
            Launcher.LaunchWebsite("http://yukitsuki.com/");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e) //Mods
        {
            ModsWindow f3 = new ModsWindow();
            f3.ShowDialog();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e) //Clear Cache
        {
            GrayTransparent.Visibility = Visibility.Visible;
            Cache f2 = new Cache();
            f2.ShowDialog();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e) //Center
        {
            Background.Source = new BitmapImage(new Uri("pack://application:,,,/ArkThreadripperLauncher;component/Resources/Center.jpg", UriKind.Absolute));
            Link = "steam://connect/yukitsuki.com:27016";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e) ///Island Left Click
        {
            Background.Source = new BitmapImage(new Uri("pack://application:,,,/ArkThreadripperLauncher;component/Resources/TheIsland.jpg", UriKind.Absolute));
            Link = "steam://connect/yukitsuki.com:27015";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e) ///Ragnarok
        {
            Background.Source = new BitmapImage(new Uri("pack://application:,,,/ArkThreadripperLauncher;component/Resources/Ragnarok.jpg", UriKind.Absolute));
            Link = "steam://connect/yukitsuki.com:27018";
        }

        private void Button_Click_10(object sender, RoutedEventArgs e) ///Extinction
        {
            Background.Source = new BitmapImage(new Uri("pack://application:,,,/ArkThreadripperLauncher;component/Resources/Extinction.jpg", UriKind.Absolute));
            Link = "steam://connect/yukitsuki.com:27024";
        }

        private void Button_Click_11(object sender, RoutedEventArgs e) ///Aberration
        {
            Background.Source = new BitmapImage(new Uri("pack://application:,,,/ArkThreadripperLauncher;component/Resources/Aberration.jpg", UriKind.Absolute));
            Link = "steam://connect/yukitsuki.com:27020";
        }

        private void ToggleButton_Checked_1(object sender, RoutedEventArgs e) //Small Islands
        {
            Background.Source = new BitmapImage(new Uri("pack://application:,,,/ArkThreadripperLauncher;component/Resources/SmallIslands1.jpg", UriKind.Absolute));
            Link = "steam://connect/yukitsuki.com:27019";
        }
        private void Button_Click_12(object sender, RoutedEventArgs e) //Update
        {
            AutoUpdater.Start("https://www.dropbox.com/s/rdkn2ie547cs9kr/UpdateData.xml?dl=1");
        }
        private void Button_Click_13(object sender, RoutedEventArgs e) //Settings
        {
            if (!buttonPressed)
            {
                var settings = new Settings();
                SettingsTextBar.Text = settings.SettingsValue;
                buttonPressed = true;

                DoubleAnimation doubleanimation = new DoubleAnimation();
                doubleanimation.From = 0;
                doubleanimation.To = 300;
                doubleanimation.Duration = TimeSpan.FromSeconds(1);

                SettingsTextBar.BeginAnimation(WidthProperty, doubleanimation);
                SettingsTextBar.Visibility = Visibility.Visible;
            }
            else
            {
                DoubleAnimation doubleanimation = new DoubleAnimation();
                doubleanimation.From = 300;
                doubleanimation.To = 0;
                doubleanimation.Duration = TimeSpan.FromSeconds(0.7);
                doubleanimation.Completed += OnDoubleAnimationOnCompleted;
                buttonPressed = false;

                SettingsTextBar.BeginAnimation(WidthProperty, doubleanimation);

                var settings = new Settings();
                settings.SettingsValue = SettingsTextBar.Text;
                settings.Save();
            }
        }

        private void OnDoubleAnimationOnCompleted(object s, EventArgs e)
        {
            SettingsTextBar.Visibility = Visibility.Collapsed;
        }

        private void ToggleButton_Checked_10(object sender, RoutedEventArgs e) //No Tame
        {
            Background.Source = new BitmapImage(new Uri("pack://application:,,,/ArkThreadripperLauncher;component/Resources/SOTF.jpg", UriKind.Absolute));
            Link = "steam://connect/yukitsuki.com:27022";
        }

        private void DiscordIcon_Click(object sender, RoutedEventArgs e)
        {
            DiscordIcon.Visibility = Visibility.Collapsed;
            DiscordWidget.Visibility = Visibility.Visible;
            DoubleAnimation doubleanimation = new DoubleAnimation(0, 1, new Duration(TimeSpan.FromSeconds(1)));
            DiscordWidget.BeginAnimation(OpacityProperty, doubleanimation);
            DiscordWidgetExit.Visibility = Visibility.Visible;
        }

        private void DiscordWidgetExit_Click(object sender, RoutedEventArgs e)
        {
            DiscordWidgetExit.Visibility = Visibility.Collapsed;
            DiscordIcon.Visibility = Visibility.Visible;
            DiscordWidget.Visibility = Visibility.Collapsed;
        }

        private void SettingsTextBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextDir = SettingsTextBar.Text;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void Button_Click_14(object sender, RoutedEventArgs e) //Dumpcheckfortogglebuttons
        {
            //Do nothing
        }
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            AutoUpdate = true;
            Settings.Default.CheckBox = true;
            Properties.Settings.Default.Save();
        }
        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            AutoUpdate = false;
            Settings.Default.CheckBox = false;
            Properties.Settings.Default.Save();
        }
        private void ServerRates(object sender, RoutedEventArgs e)
        {
            if (!buttonPressed)
            {
                ScrollRates.Visibility = Visibility.Visible;
                ScrollBackground.Visibility = Visibility.Visible;
                ServerRatesExit.Visibility = Visibility.Visible;
                buttonPressed = true;
            }
            else
            {
                ScrollRates.Visibility = Visibility.Collapsed;
                ScrollBackground.Visibility = Visibility.Collapsed;
                ServerRatesExit.Visibility = Visibility.Collapsed;
                buttonPressed = false;
            }
        }

        private void ServerRatesExit_Click(object sender, RoutedEventArgs e)
        {
            ScrollRates.Visibility = Visibility.Collapsed;
            ScrollBackground.Visibility = Visibility.Collapsed;
            ServerRatesExit.Visibility = Visibility.Collapsed;
        }
        public class Example
        {
            public static void ExitBackground(object sender, RoutedEventArgs e)
            {
                
            }
        }
        //private void MoveUp(object sender, RoutedEventArgs e)
        //{
        //Background.Source = new BitmapImage(new Uri("pack://application:,,,/ArkThreadripperLauncher;component/Resources/SOTF.jpg", UriKind.Absolute));
        //}
        //private void MoveDown(object sender, RoutedEventArgs e)
        //{
        //Background.Source = new BitmapImage(new Uri("pack://application:,,,/ArkThreadripperLauncher;component/Resources/SOTF.jpg", UriKind.Absolute));
        //}
    }
}