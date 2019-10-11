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
using MahApps.Metro.Controls;
using MahApps.Metro;
using System.Windows.Media;
using System.Windows.Media.Effects;

namespace Ark_Threadripper_Launcher
{
    public partial class MainWindow : MetroWindow, INotifyPropertyChanged

    {
        public MainWindow()
        {
            InitializeComponent();
            bool check = AutoUpdateCheck.IsChecked.GetValueOrDefault(false);
            AutoUpdateCheck.IsChecked = Settings.Default.CheckBox;

            ((App)Application.Current).WindowPlace.Register(this);

            if (AutoUpdate == true)
            {
                AutoUpdater.Start("https://www.dropbox.com/s/rdkn2ie547cs9kr/UpdateData.xml?dl=1");
            }
            if (buttonPressed2 > 1)
            {
                buttonPressed2 = Settings.Default.buttonPressed2 - 1;
            }
            if (buttonPressed2 == 1)
            {
                buttonPressed2 = Settings.Default.buttonPressed2;
            }
            if (buttonPressed2 < 1)
            {
                buttonPressed2 = 1;
            }
            if (buttonPressed2 == 1)
            {
                ThemeManager.ChangeAppStyle(Application.Current,
                                             ThemeManager.GetAccent("Red"),
                                             ThemeManager.GetAppTheme("BaseDark")); ;
                AutoUpdateCheck.Foreground = Brushes.Red;
                MainPlayButton.Background = Brushes.Red;
                return;
            }
            if (buttonPressed2 == 2)
            {
                ThemeManager.ChangeAppStyle(Application.Current,
                                             ThemeManager.GetAccent("Green"),
                                             ThemeManager.GetAppTheme("BaseDark")); ;
                AutoUpdateCheck.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#548E19")); ;
                MainPlayButton.Background = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#548E19")); ;
                return;
            }
            if (buttonPressed2 == 3)
            {
                ThemeManager.ChangeAppStyle(Application.Current,
                                             ThemeManager.GetAccent("Blue"),
                                             ThemeManager.GetAppTheme("BaseDark")); ;
                AutoUpdateCheck.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#1585B5"));
                MainPlayButton.Background = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#1585B5"));
                return;
            }
            if (buttonPressed2 == 4)
            {
                ThemeManager.ChangeAppStyle(Application.Current,
                                             ThemeManager.GetAccent("Purple"),
                                             ThemeManager.GetAppTheme("BaseDark")); ;
                AutoUpdateCheck.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#574EB9"));
                MainPlayButton.Background = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#574EB9"));
                return;
            }
            if (buttonPressed2 == 5)
            {
                ThemeManager.ChangeAppStyle(Application.Current,
                                             ThemeManager.GetAccent("Orange"),
                                             ThemeManager.GetAppTheme("BaseDark")); ;
                AutoUpdateCheck.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#CF5A07"));
                MainPlayButton.Background = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#CF5A07"));
                return;
            }
            if (buttonPressed2 == 6)
            {
                ThemeManager.ChangeAppStyle(Application.Current,
                                             ThemeManager.GetAccent("Lime"),
                                             ThemeManager.GetAppTheme("BaseDark")); ;
                AutoUpdateCheck.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#8AA407"));
                MainPlayButton.Background = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#8AA407"));
                return;
            }
            if (buttonPressed2 == 7)
            {
                ThemeManager.ChangeAppStyle(Application.Current,
                                             ThemeManager.GetAccent("Emerald"),
                                             ThemeManager.GetAppTheme("BaseDark")); ;
                AutoUpdateCheck.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#077507"));
                MainPlayButton.Background = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#077507"));
                return;
            }
            if (buttonPressed2 == 8)
            {
                ThemeManager.ChangeAppStyle(Application.Current,
                                             ThemeManager.GetAccent("Teal"),
                                             ThemeManager.GetAppTheme("BaseDark")); ;
                AutoUpdateCheck.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#07908E"));
                MainPlayButton.Background = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#07908E"));
                return;
            }
            if (buttonPressed2 == 9)
            {
                ThemeManager.ChangeAppStyle(Application.Current,
                                             ThemeManager.GetAccent("Cyan"),
                                             ThemeManager.GetAppTheme("BaseDark")); ;
                AutoUpdateCheck.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#1D88BC"));
                MainPlayButton.Background = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#1D88BC"));
                return;
            }
            if (buttonPressed2 == 10)
            {
                ThemeManager.ChangeAppStyle(Application.Current,
                                             ThemeManager.GetAccent("Cobalt"),
                                             ThemeManager.GetAppTheme("BaseDark")); ;
                AutoUpdateCheck.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#0747C6"));
                MainPlayButton.Background = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#0747C6"));
                return;
            }
            if (buttonPressed2 == 11)
            {
                ThemeManager.ChangeAppStyle(Application.Current,
                                             ThemeManager.GetAccent("Indigo"),
                                             ThemeManager.GetAppTheme("BaseDark")); ;
                AutoUpdateCheck.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#5C07D3"));
                MainPlayButton.Background = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#5C07D3"));
                return;
            }
            if (buttonPressed2 == 12)
            {
                ThemeManager.ChangeAppStyle(Application.Current,
                                             ThemeManager.GetAccent("Violet"),
                                             ThemeManager.GetAppTheme("BaseDark")); ;
                AutoUpdateCheck.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#8F07D3"));
                MainPlayButton.Background = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#8F07D3"));
                return;
            }
            if (buttonPressed2 == 13)
            {
                ThemeManager.ChangeAppStyle(Application.Current,
                                             ThemeManager.GetAccent("Pink"),
                                             ThemeManager.GetAppTheme("BaseDark")); ;
                AutoUpdateCheck.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#CA62AD"));
                MainPlayButton.Background = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#CA62AD"));
                return;
            }
            if (buttonPressed2 == 14)
            {
                ThemeManager.ChangeAppStyle(Application.Current,
                                             ThemeManager.GetAccent("Magenta"),
                                             ThemeManager.GetAppTheme("BaseDark")); ;
                AutoUpdateCheck.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#B40763"));
                MainPlayButton.Background = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#B40763"));
                return;
            }
            if (buttonPressed2 == 15)
            {
                ThemeManager.ChangeAppStyle(Application.Current,
                                             ThemeManager.GetAccent("Crimson"),
                                             ThemeManager.GetAppTheme("BaseDark")); ;
                AutoUpdateCheck.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#890725"));
                MainPlayButton.Background = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#890725"));
                return;
            }
            if (buttonPressed2 == 16)
            {
                ThemeManager.ChangeAppStyle(Application.Current,
                                             ThemeManager.GetAccent("Amber"),
                                             ThemeManager.GetAppTheme("BaseDark")); ;
                AutoUpdateCheck.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#C7890F"));
                MainPlayButton.Background = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#C7890F"));
                return;
            }
            if (buttonPressed2 == 17)
            {
                ThemeManager.ChangeAppStyle(Application.Current,
                                             ThemeManager.GetAccent("Yellow"),
                                             ThemeManager.GetAppTheme("BaseDark")); ;
                AutoUpdateCheck.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#D2B90C"));
                MainPlayButton.Background = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#D2B90C"));
                return;
            }
            if (buttonPressed2 == 18)
            {
                ThemeManager.ChangeAppStyle(Application.Current,
                                             ThemeManager.GetAccent("Brown"),
                                             ThemeManager.GetAppTheme("BaseDark")); ;
                AutoUpdateCheck.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#6F4F2A"));
                MainPlayButton.Background = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#6F4F2A"));
                return;
            }
            if (buttonPressed2 == 19)
            {
                ThemeManager.ChangeAppStyle(Application.Current,
                                             ThemeManager.GetAccent("Olive"),
                                             ThemeManager.GetAppTheme("BaseDark")); ;
                AutoUpdateCheck.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#5E7357"));
                MainPlayButton.Background = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#5E7357"));
                return;
            }
            if (buttonPressed2 == 20)
            {
                ThemeManager.ChangeAppStyle(Application.Current,
                                             ThemeManager.GetAccent("Steel"),
                                             ThemeManager.GetAppTheme("BaseDark")); ;
                AutoUpdateCheck.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#576573"));
                MainPlayButton.Background = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#576573"));
                return;
            }
            if (buttonPressed2 == 21)
            {
                ThemeManager.ChangeAppStyle(Application.Current,
                                             ThemeManager.GetAccent("Mauve"),
                                             ThemeManager.GetAppTheme("BaseDark")); ;
                AutoUpdateCheck.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#655475"));
                MainPlayButton.Background = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#655475"));
                return;
            }
            if (buttonPressed2 == 22)
            {
                ThemeManager.ChangeAppStyle(Application.Current,
                                             ThemeManager.GetAccent("Taupe"),
                                             ThemeManager.GetAppTheme("BaseDark")); ;
                AutoUpdateCheck.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#736845"));
                MainPlayButton.Background = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#736845"));
                return;
            }
            if (buttonPressed2 == 23)
            {
                ThemeManager.ChangeAppStyle(Application.Current,
                                             ThemeManager.GetAccent("Sienna"),
                                             ThemeManager.GetAppTheme("BaseDark")); ;
                AutoUpdateCheck.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#87492B"));
                MainPlayButton.Background = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#87492B"));
                return;
            }
        }
        bool buttonPressed = false;
        bool buttonPressed1 = false;
        int buttonPressed2 = Properties.Settings.Default.buttonPressed2 - 1;
        bool buttonPressed3 = false;
        bool AutoUpdate = false;
        public string NewURL { get; set; }
        public string Link { get; set; }
        public static string TextDir { get; set; }
        private void Button_Click(object sender, RoutedEventArgs e) //Play Button
        {
            Launcher.LaunchWebsite(Link);
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
                    Application.Current.MainWindow.Effect = new BlurEffect();
                    Error f3 = new Error();
                    f3.ShowDialog();
                    Application.Current.MainWindow.Effect = null;
                }
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e) ///Website Button
        {
            Launcher.LaunchWebsite("http://yukitsuki.com/");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e) //Mods
        {
            Application.Current.MainWindow.Effect = new BlurEffect();
            ModsWindow f3 = new ModsWindow();
            f3.ShowDialog();
            Application.Current.MainWindow.Effect = null;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e) //Clear Cache
        {
            Application.Current.MainWindow.Effect = new BlurEffect();
            Cache f2 = new Cache();
            f2.ShowDialog();
            Application.Current.MainWindow.Effect = null;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e) //Center
        {
            Background.Source = new BitmapImage(new Uri("pack://application:,,,/ArkThreadripperLauncher;component/Resources/Center.jpg", UriKind.Absolute));
            Link = "steam://connect/yukitsuki.com:27016";
            CenterButton.Margin = new Thickness(25, 267, 0, 0);
            CenterButtonBackground.Margin = new Thickness(25, 267, 0, 0);
            CenterLogo.Margin = new Thickness(1, 250, 0, 0);
            //Disable Island Button Movement
            ButtonIsland.Margin = new Thickness(0, 63, 0, 0);
            IslandButtonBackground.Margin = new Thickness(0, 63, 0, 0);
            IslandLogo.Margin = new Thickness(12, 64, 0, 0);
            //Disable Scorched Button Movement
            ScorchedButton.Margin = new Thickness(0, 103, 0, 0);
            ScorchedButtonBackground.Margin = new Thickness(0, 103, 0, 0);
            ScorchedLogo.Margin = new Thickness(14, 105, 0, 0);
            //Disable Aberration Button Movement
            AberrationButton.Margin = new Thickness(0, 143, 0, 0);
            AberrationButtonBackground.Margin = new Thickness(0, 143, 0, 0);
            AberrationLogo.Margin = new Thickness(14, 145, 0, 0);
            //Disable Extinction Button Movement
            ExtinctionButton.Margin = new Thickness(0, 183, 0, 0);
            ExtinctionButtonBackground.Margin = new Thickness(0, 183, 0, 0);
            ExtinctionLogo.Margin = new Thickness(10, 182, 0, 0);



            //Disable Ragnarok Button Movement
            RagnarokButton.Margin = new Thickness(2, 306, 0, 0);
            RagnarokButtonBackground.Margin = new Thickness(2, 306, 0, 0);
            RagnarokLogo.Margin = new Thickness(13, 306, 0, 0);
            //Disable Valguero Button Movement
            ValgueroButton.Margin = new Thickness(2, 346, 0, 0);
            ValgueroButtonBackground.Margin = new Thickness(2, 346, 0, 0);
            ValgueroLogo.Margin = new Thickness(10, 346, 0, 0);


            //Disable NoTame Button Movement
            NoTameButton.Margin = new Thickness(0, 0, 0, 130);
            NoTameButtonBackground.Margin = new Thickness(0, 0, 0, 130);
            //Disable SmallIslands Button Movement
            SmallIslandsButton.Margin = new Thickness(1, 0, 0, 90);
            SmallIslandsButtonBackground.Margin = new Thickness(1, 0, 0, 90);
        }

        private void Button_Click_8(object sender, RoutedEventArgs e) ///Island
        {
            Background.Source = new BitmapImage(new Uri("pack://application:,,,/ArkThreadripperLauncher;component/Resources/TheIsland.jpg", UriKind.Absolute));
            Link = "steam://connect/yukitsuki.com:27015";
            ButtonIsland.Margin = new Thickness(25, 63, 0, 0);
            IslandButtonBackground.Margin = new Thickness(25, 63, 0, 0);
            IslandLogo.Margin = new Thickness(25, 63, 0, 0);
            //Disable Scorched Button Movement
            ScorchedButton.Margin = new Thickness(0, 103, 0, 0);
            ScorchedButtonBackground.Margin = new Thickness(0, 103, 0, 0);
            ScorchedLogo.Margin = new Thickness(14, 105, 0, 0);
            //Disable Aberration Button Movement
            AberrationButton.Margin = new Thickness(0, 143, 0, 0);
            AberrationButtonBackground.Margin = new Thickness(0, 143, 0, 0);
            AberrationLogo.Margin = new Thickness(14, 145, 0, 0);
            //Disable Extinction Button Movement
            ExtinctionButton.Margin = new Thickness(0, 183, 0, 0);
            ExtinctionButtonBackground.Margin = new Thickness(0, 183, 0, 0);
            ExtinctionLogo.Margin = new Thickness(10, 182, 0, 0);



            //Disable Center Button Movement
            CenterButton.Margin = new Thickness(2, 267, 0, 0);
            CenterButtonBackground.Margin = new Thickness(2, 267, 0, 0);
            CenterLogo.Margin = new Thickness(-13, 250, 0, 0);
            //Disable Ragnarok Button Movement
            RagnarokButton.Margin = new Thickness(2, 306, 0, 0);
            RagnarokButtonBackground.Margin = new Thickness(2, 306, 0, 0);
            RagnarokLogo.Margin = new Thickness(13, 306, 0, 0);
            //Disable Valguero Button Movement
            ValgueroButton.Margin = new Thickness(2, 346, 0, 0);
            ValgueroButtonBackground.Margin = new Thickness(2, 346, 0, 0);
            ValgueroLogo.Margin = new Thickness(10, 346, 0, 0);


            //Disable NoTame Button Movement
            NoTameButton.Margin = new Thickness(0, 0, 0, 130);
            NoTameButtonBackground.Margin = new Thickness(0, 0, 0, 130);
            //Disable SmallIslands Button Movement
            SmallIslandsButton.Margin = new Thickness(1, 0, 0, 90);
            SmallIslandsButtonBackground.Margin = new Thickness(1, 0, 0, 90);


        }
        private void Button_Click_1(object sender, RoutedEventArgs e) ///Scorched Earth
        {
            Background.Source = new BitmapImage(new Uri("pack://application:,,,/ArkThreadripperLauncher;component/Resources/ScorchedEarth.png", UriKind.Absolute));
            Link = "steam://connect/yukitsuki.com:27017";
            ScorchedButton.Margin = new Thickness(25, 103, 0, 0);
            ScorchedButtonBackground.Margin = new Thickness(25, 103, 0, 0);
            ScorchedLogo.Margin = new Thickness(25, 103, 0, 0);
            //Disable Island Button Movement
            ButtonIsland.Margin = new Thickness(0, 63, 0, 0);
            IslandButtonBackground.Margin = new Thickness(0, 63, 0, 0);
            IslandLogo.Margin = new Thickness(12, 64, 0, 0);
            //Disable Aberration Button Movement
            AberrationButton.Margin = new Thickness(0, 143, 0, 0);
            AberrationButtonBackground.Margin = new Thickness(0, 143, 0, 0);
            AberrationLogo.Margin = new Thickness(14, 145, 0, 0);
            //Disable Extinction Button Movement
            ExtinctionButton.Margin = new Thickness(0, 183, 0, 0);
            ExtinctionButtonBackground.Margin = new Thickness(0, 183, 0, 0);
            ExtinctionLogo.Margin = new Thickness(10, 182, 0, 0);



            //Disable Center Button Movement
            CenterButton.Margin = new Thickness(2, 267, 0, 0);
            CenterButtonBackground.Margin = new Thickness(2, 267, 0, 0);
            CenterLogo.Margin = new Thickness(-13, 250, 0, 0);
            //Disable Ragnarok Button Movement
            RagnarokButton.Margin = new Thickness(2, 306, 0, 0);
            RagnarokButtonBackground.Margin = new Thickness(2, 306, 0, 0);
            RagnarokLogo.Margin = new Thickness(13, 306, 0, 0);
            //Disable Valguero Button Movement
            ValgueroButton.Margin = new Thickness(2, 346, 0, 0);
            ValgueroButtonBackground.Margin = new Thickness(2, 346, 0, 0);
            ValgueroLogo.Margin = new Thickness(10, 346, 0, 0);


            //Disable NoTame Button Movement
            NoTameButton.Margin = new Thickness(0, 0, 0, 130);
            NoTameButtonBackground.Margin = new Thickness(0, 0, 0, 130);
            //Disable SmallIslands Button Movement
            SmallIslandsButton.Margin = new Thickness(1, 0, 0, 90);
            SmallIslandsButtonBackground.Margin = new Thickness(1, 0, 0, 90);

        }

        private void Button_Click_9(object sender, RoutedEventArgs e) ///Ragnarok
        {
            Background.Source = new BitmapImage(new Uri("pack://application:,,,/ArkThreadripperLauncher;component/Resources/Ragnarok.jpg", UriKind.Absolute));
            Link = "steam://connect/yukitsuki.com:27018";
            RagnarokButton.Margin = new Thickness(25, 306, 0, 0);
            RagnarokButtonBackground.Margin = new Thickness(25, 306, 0, 0);
            RagnarokLogo.Margin = new Thickness(28, 306, 0, 0);
            //Disable Island Button Movement
            ButtonIsland.Margin = new Thickness(0, 63, 0, 0);
            IslandButtonBackground.Margin = new Thickness(0, 63, 0, 0);
            IslandLogo.Margin = new Thickness(12, 64, 0, 0);
            //Disable Scorched Button Movement
            ScorchedButton.Margin = new Thickness(0, 103, 0, 0);
            ScorchedButtonBackground.Margin = new Thickness(0, 103, 0, 0);
            ScorchedLogo.Margin = new Thickness(14, 105, 0, 0);
            //Disable Aberration Button Movement
            AberrationButton.Margin = new Thickness(0, 143, 0, 0);
            AberrationButtonBackground.Margin = new Thickness(0, 143, 0, 0);
            AberrationLogo.Margin = new Thickness(14, 145, 0, 0);
            //Disable Extinction Button Movement
            ExtinctionButton.Margin = new Thickness(0, 183, 0, 0);
            ExtinctionButtonBackground.Margin = new Thickness(0, 183, 0, 0);
            ExtinctionLogo.Margin = new Thickness(10, 182, 0, 0);



            //Disable Center Button Movement
            CenterButton.Margin = new Thickness(2, 267, 0, 0);
            CenterButtonBackground.Margin = new Thickness(2, 267, 0, 0);
            CenterLogo.Margin = new Thickness(-13, 250, 0, 0);
            //Disable Valguero Button Movement
            ValgueroButton.Margin = new Thickness(2, 346, 0, 0);
            ValgueroButtonBackground.Margin = new Thickness(2, 346, 0, 0);
            ValgueroLogo.Margin = new Thickness(10, 346, 0, 0);


            //Disable NoTame Button Movement
            NoTameButton.Margin = new Thickness(0, 0, 0, 130);
            NoTameButtonBackground.Margin = new Thickness(0, 0, 0, 130);
            //Disable SmallIslands Button Movement
            SmallIslandsButton.Margin = new Thickness(1, 0, 0, 90);
            SmallIslandsButtonBackground.Margin = new Thickness(1, 0, 0, 90);
        }

        private void Button_Click_10(object sender, RoutedEventArgs e) ///Extinction
        {
            Background.Source = new BitmapImage(new Uri("pack://application:,,,/ArkThreadripperLauncher;component/Resources/Extinction.jpg", UriKind.Absolute));
            Link = "steam://connect/yukitsuki.com:27024";
            ExtinctionButton.Margin = new Thickness(25, 183, 0, 0);
            ExtinctionButtonBackground.Margin = new Thickness(25, 183, 0, 0);
            ExtinctionLogo.Margin = new Thickness(25, 183, 0, 0);
            //Disable Island Button Movement
            ButtonIsland.Margin = new Thickness(0, 63, 0, 0);
            IslandButtonBackground.Margin = new Thickness(0, 63, 0, 0);
            IslandLogo.Margin = new Thickness(12, 64, 0, 0);
            //Disable Scorched Button Movement
            ScorchedButton.Margin = new Thickness(0, 103, 0, 0);
            ScorchedButtonBackground.Margin = new Thickness(0, 103, 0, 0);
            ScorchedLogo.Margin = new Thickness(14, 105, 0, 0);
            //Disable Aberration Button Movement
            AberrationButton.Margin = new Thickness(0, 143, 0, 0);
            AberrationButtonBackground.Margin = new Thickness(0, 143, 0, 0);
            AberrationLogo.Margin = new Thickness(14, 145, 0, 0);


            //Disable Center Button Movement
            CenterButton.Margin = new Thickness(2, 267, 0, 0);
            CenterButtonBackground.Margin = new Thickness(2, 267, 0, 0);
            CenterLogo.Margin = new Thickness(-13, 250, 0, 0);
            //Disable Ragnarok Button Movement
            RagnarokButton.Margin = new Thickness(2, 306, 0, 0);
            RagnarokButtonBackground.Margin = new Thickness(2, 306, 0, 0);
            RagnarokLogo.Margin = new Thickness(13, 306, 0, 0);
            //Disable Valguero Button Movement
            ValgueroButton.Margin = new Thickness(2, 346, 0, 0);
            ValgueroButtonBackground.Margin = new Thickness(2, 346, 0, 0);
            ValgueroLogo.Margin = new Thickness(10, 346, 0, 0);


            //Disable NoTame Button Movement
            NoTameButton.Margin = new Thickness(0, 0, 0, 130);
            NoTameButtonBackground.Margin = new Thickness(0, 0, 0, 130);
            //Disable SmallIslands Button Movement
            SmallIslandsButton.Margin = new Thickness(1, 0, 0, 90);
            SmallIslandsButtonBackground.Margin = new Thickness(1, 0, 0, 90);
        }

        private void Button_Click_11(object sender, RoutedEventArgs e) ///Aberration 
        {
            Background.Source = new BitmapImage(new Uri("pack://application:,,,/ArkThreadripperLauncher;component/Resources/Aberration.jpg", UriKind.Absolute));
            Link = "steam://connect/yukitsuki.com:27020";
            AberrationButton.Margin = new Thickness(25, 143, 0, 0);
            AberrationButtonBackground.Margin = new Thickness(25, 143, 0, 0);
            AberrationLogo.Margin = new Thickness(25, 143, 0, 0);
            //Disable Island Button Movement
            ButtonIsland.Margin = new Thickness(0, 63, 0, 0);
            IslandButtonBackground.Margin = new Thickness(0, 63, 0, 0);
            IslandLogo.Margin = new Thickness(12, 64, 0, 0);
            //Disable Scorched Button Movement
            ScorchedButton.Margin = new Thickness(0, 103, 0, 0);
            ScorchedButtonBackground.Margin = new Thickness(0, 103, 0, 0);
            ScorchedLogo.Margin = new Thickness(14, 105, 0, 0);
            //Disable Extinction Button Movement
            ExtinctionButton.Margin = new Thickness(0, 183, 0, 0);
            ExtinctionButtonBackground.Margin = new Thickness(0, 183, 0, 0);
            ExtinctionLogo.Margin = new Thickness(10, 182, 0, 0);


            //Disable Center Button Movement
            CenterButton.Margin = new Thickness(2, 267, 0, 0);
            CenterButtonBackground.Margin = new Thickness(2, 267, 0, 0);
            CenterLogo.Margin = new Thickness(-13, 250, 0, 0);
            //Disable Ragnarok Button Movement
            RagnarokButton.Margin = new Thickness(2, 306, 0, 0);
            RagnarokButtonBackground.Margin = new Thickness(2, 306, 0, 0);
            RagnarokLogo.Margin = new Thickness(13, 306, 0, 0);
            //Disable Valguero Button Movement
            ValgueroButton.Margin = new Thickness(2, 346, 0, 0);
            ValgueroButtonBackground.Margin = new Thickness(2, 346, 0, 0);
            ValgueroLogo.Margin = new Thickness(10, 346, 0, 0);


            //Disable NoTame Button Movement
            NoTameButton.Margin = new Thickness(0, 0, 0, 130);
            NoTameButtonBackground.Margin = new Thickness(0, 0, 0, 130);
            //Disable SmallIslands Button Movement
            SmallIslandsButton.Margin = new Thickness(1, 0, 0, 90);
            SmallIslandsButtonBackground.Margin = new Thickness(1, 0, 0, 90);
        }

        private void Button_Click_14(object sender, RoutedEventArgs e) //Small Islands
        {
            Background.Source = new BitmapImage(new Uri("pack://application:,,,/ArkThreadripperLauncher;component/Resources/SmallIslands1.jpg", UriKind.Absolute));
            Link = "steam://connect/yukitsuki.com:27019";
            SmallIslandsButton.Margin = new Thickness(25, 0, 0, 90);
            SmallIslandsButtonBackground.Margin = new Thickness(25, 0, 0, 90);
            //Disable Island Button Movement
            ButtonIsland.Margin = new Thickness(0, 63, 0, 0);
            IslandButtonBackground.Margin = new Thickness(0, 63, 0, 0);
            IslandLogo.Margin = new Thickness(12, 64, 0, 0);
            //Disable Scorched Button Movement
            ScorchedButton.Margin = new Thickness(0, 103, 0, 0);
            ScorchedButtonBackground.Margin = new Thickness(0, 103, 0, 0);
            ScorchedLogo.Margin = new Thickness(14, 105, 0, 0);
            //Disable Aberration Button Movement
            AberrationButton.Margin = new Thickness(0, 143, 0, 0);
            AberrationButtonBackground.Margin = new Thickness(0, 143, 0, 0);
            AberrationLogo.Margin = new Thickness(14, 145, 0, 0);
            //Disable Extinction Button Movement
            ExtinctionButton.Margin = new Thickness(0, 183, 0, 0);
            ExtinctionButtonBackground.Margin = new Thickness(0, 183, 0, 0);
            ExtinctionLogo.Margin = new Thickness(10, 182, 0, 0);



            //Disable Center Button Movement
            CenterButton.Margin = new Thickness(2, 267, 0, 0);
            CenterButtonBackground.Margin = new Thickness(2, 267, 0, 0);
            CenterLogo.Margin = new Thickness(-13, 250, 0, 0);
            //Disable Ragnarok Button Movement
            RagnarokButton.Margin = new Thickness(2, 306, 0, 0);
            RagnarokButtonBackground.Margin = new Thickness(2, 306, 0, 0);
            RagnarokLogo.Margin = new Thickness(13, 306, 0, 0);
            //Disable Valguero Button Movement
            ValgueroButton.Margin = new Thickness(2, 346, 0, 0);
            ValgueroButtonBackground.Margin = new Thickness(2, 346, 0, 0);
            ValgueroLogo.Margin = new Thickness(10, 346, 0, 0);


            //Disable NoTame Button Movement
            NoTameButton.Margin = new Thickness(0, 0, 0, 130);
            NoTameButtonBackground.Margin = new Thickness(0, 0, 0, 130);
        }

        private void Button_Click_111(object sender, RoutedEventArgs e) //Valguero
        {
            Background.Source = new BitmapImage(new Uri("pack://application:,,,/ArkThreadripperLauncher;component/Resources/Valguero.jpg", UriKind.Absolute));
            Link = "steam://connect/yukitsuki.com:27025";
            ValgueroButton.Margin = new Thickness(25, 346, 0, 0);
            ValgueroButtonBackground.Margin = new Thickness(25, 346, 0, 0);
            ValgueroLogo.Margin = new Thickness(25, 346, 0, 0);
            //Disable Island Button Movement
            ButtonIsland.Margin = new Thickness(0, 63, 0, 0);
            IslandButtonBackground.Margin = new Thickness(0, 63, 0, 0);
            IslandLogo.Margin = new Thickness(12, 64, 0, 0);
            //Disable Scorched Button Movement
            ScorchedButton.Margin = new Thickness(0, 103, 0, 0);
            ScorchedButtonBackground.Margin = new Thickness(0, 103, 0, 0);
            ScorchedLogo.Margin = new Thickness(14, 105, 0, 0);
            //Disable Aberration Button Movement
            AberrationButton.Margin = new Thickness(0, 143, 0, 0);
            AberrationButtonBackground.Margin = new Thickness(0, 143, 0, 0);
            AberrationLogo.Margin = new Thickness(14, 145, 0, 0);
            //Disable Extinction Button Movement
            ExtinctionButton.Margin = new Thickness(0, 183, 0, 0);
            ExtinctionButtonBackground.Margin = new Thickness(0, 183, 0, 0);
            ExtinctionLogo.Margin = new Thickness(10, 182, 0, 0);



            //Disable Center Button Movement
            CenterButton.Margin = new Thickness(2, 267, 0, 0);
            CenterButtonBackground.Margin = new Thickness(2, 267, 0, 0);
            CenterLogo.Margin = new Thickness(-13, 250, 0, 0);
            //Disable Ragnarok Button Movement
            RagnarokButton.Margin = new Thickness(2, 306, 0, 0);
            RagnarokButtonBackground.Margin = new Thickness(2, 306, 0, 0);
            RagnarokLogo.Margin = new Thickness(13, 306, 0, 0);


            //Disable NoTame Button Movement
            NoTameButton.Margin = new Thickness(0, 0, 0, 130);
            NoTameButtonBackground.Margin = new Thickness(0, 0, 0, 130);
            //Disable SmallIslands Button Movement
            SmallIslandsButton.Margin = new Thickness(1, 0, 0, 90);
            SmallIslandsButtonBackground.Margin = new Thickness(1, 0, 0, 90);

        }

        private void ToggleButton_Checked_10(object sender, RoutedEventArgs e) //No Tame
        {
            Background.Source = new BitmapImage(new Uri("pack://application:,,,/ArkThreadripperLauncher;component/Resources/SOTF.jpg", UriKind.Absolute));
            Link = "steam://connect/yukitsuki.com:27022";
            NoTameButton.Margin = new Thickness(25, 0, 0, 130);
            NoTameButtonBackground.Margin = new Thickness(25, 0, 0, 130);
            //Disable Island Button Movement
            ButtonIsland.Margin = new Thickness(0, 63, 0, 0);
            IslandButtonBackground.Margin = new Thickness(0, 63, 0, 0);
            IslandLogo.Margin = new Thickness(12, 64, 0, 0);
            //Disable Scorched Button Movement
            ScorchedButton.Margin = new Thickness(0, 103, 0, 0);
            ScorchedButtonBackground.Margin = new Thickness(0, 103, 0, 0);
            ScorchedLogo.Margin = new Thickness(14, 105, 0, 0);
            //Disable Aberration Button Movement
            AberrationButton.Margin = new Thickness(0, 143, 0, 0);
            AberrationButtonBackground.Margin = new Thickness(0, 143, 0, 0);
            AberrationLogo.Margin = new Thickness(14, 145, 0, 0);
            //Disable Extinction Button Movement
            ExtinctionButton.Margin = new Thickness(0, 183, 0, 0);
            ExtinctionButtonBackground.Margin = new Thickness(0, 183, 0, 0);
            ExtinctionLogo.Margin = new Thickness(10, 182, 0, 0);



            //Disable Center Button Movement
            CenterButton.Margin = new Thickness(2, 267, 0, 0);
            CenterButtonBackground.Margin = new Thickness(2, 267, 0, 0);
            CenterLogo.Margin = new Thickness(-13, 250, 0, 0);
            //Disable Valguero Button Movement
            ValgueroButton.Margin = new Thickness(2, 346, 0, 0);
            ValgueroButtonBackground.Margin = new Thickness(2, 346, 0, 0);
            ValgueroLogo.Margin = new Thickness(10, 346, 0, 0);
            //Disable Ragnarok Button Movement
            RagnarokButton.Margin = new Thickness(2, 306, 0, 0);
            RagnarokButtonBackground.Margin = new Thickness(2, 306, 0, 0);
            RagnarokLogo.Margin = new Thickness(13, 306, 0, 0);


            //Disable SmallIslands Button Movement
            SmallIslandsButton.Margin = new Thickness(1, 0, 0, 90);
            SmallIslandsButtonBackground.Margin = new Thickness(1, 0, 0, 90);
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

        private void Button_Click_122(object sender, RoutedEventArgs e) //Dumpcheckfortogglebuttons
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
            if (!buttonPressed1)
            {
                ScrollRates.Visibility = Visibility.Visible;
                ScrollBackground.Visibility = Visibility.Visible;
                ServerRatesExit.Visibility = Visibility.Visible;
                buttonPressed1 = true;
            }
            else
            {
                ScrollRates.Visibility = Visibility.Collapsed;
                ScrollBackground.Visibility = Visibility.Collapsed;
                ServerRatesExit.Visibility = Visibility.Collapsed;
                buttonPressed1 = false;
            }
        }
        private void Button_Click_15(object sender, RoutedEventArgs e) //ListDown
        {
            if (!buttonPressed3)
            {
                DownList.Visibility = Visibility.Visible;
                buttonPressed3 = true;
            }
            else
            {
                DownList.Visibility = Visibility.Collapsed;
                buttonPressed3 = false;
            }
        }
        private void Button_Click_19(object sender, RoutedEventArgs e) //Color Menu
        {
            if (buttonPressed2 == 1)
            {
                ThemeManager.ChangeAppStyle(Application.Current,
                                             ThemeManager.GetAccent("Red"),
                                             ThemeManager.GetAppTheme("BaseDark")); ;
                buttonPressed2 = 2;
                AutoUpdateCheck.Foreground = Brushes.Red;
                MainPlayButton.Background = Brushes.Red;
                Properties.Settings.Default.buttonPressed2 = buttonPressed2;
                Properties.Settings.Default.Save();
                return;
            }
            if (buttonPressed2 == 2)
            {
                ThemeManager.ChangeAppStyle(Application.Current,
                                             ThemeManager.GetAccent("Green"),
                                             ThemeManager.GetAppTheme("BaseDark")); ;
                buttonPressed2 = 3;
                AutoUpdateCheck.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#548E19")); ;
                MainPlayButton.Background = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#548E19")); ;
                Properties.Settings.Default.buttonPressed2 = buttonPressed2;
                Properties.Settings.Default.Save();
                return;
            }
            if (buttonPressed2 == 3)
            {
                ThemeManager.ChangeAppStyle(Application.Current,
                                             ThemeManager.GetAccent("Blue"),
                                             ThemeManager.GetAppTheme("BaseDark")); ;
                AutoUpdateCheck.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#1585B5"));
                MainPlayButton.Background = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#1585B5"));
                buttonPressed2 = 4;
                Properties.Settings.Default.buttonPressed2 = buttonPressed2;
                Properties.Settings.Default.Save();
                return;
            }
            if (buttonPressed2 == 4)
            {
                ThemeManager.ChangeAppStyle(Application.Current,
                                             ThemeManager.GetAccent("Purple"),
                                             ThemeManager.GetAppTheme("BaseDark")); ;
                AutoUpdateCheck.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#574EB9"));
                MainPlayButton.Background = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#574EB9"));
                buttonPressed2 = 5;
                Properties.Settings.Default.buttonPressed2 = buttonPressed2;
                Properties.Settings.Default.Save();
                return;
            }
            if (buttonPressed2 == 5)
            {
                ThemeManager.ChangeAppStyle(Application.Current,
                                             ThemeManager.GetAccent("Orange"),
                                             ThemeManager.GetAppTheme("BaseDark")); ;
                AutoUpdateCheck.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#CF5A07"));
                MainPlayButton.Background = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#CF5A07"));
                buttonPressed2 = 6;
                Properties.Settings.Default.buttonPressed2 = buttonPressed2;
                Properties.Settings.Default.Save();
                return;
            }
            if (buttonPressed2 == 6)
            {
                ThemeManager.ChangeAppStyle(Application.Current,
                                             ThemeManager.GetAccent("Lime"),
                                             ThemeManager.GetAppTheme("BaseDark")); ;
                AutoUpdateCheck.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#8AA407"));
                MainPlayButton.Background = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#8AA407"));
                buttonPressed2 = 7;
                Properties.Settings.Default.buttonPressed2 = buttonPressed2;
                Properties.Settings.Default.Save();
                return;
            }
            if (buttonPressed2 == 7)
            {
                ThemeManager.ChangeAppStyle(Application.Current,
                                             ThemeManager.GetAccent("Emerald"),
                                             ThemeManager.GetAppTheme("BaseDark")); ;
                AutoUpdateCheck.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#077507"));
                MainPlayButton.Background = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#077507"));
                buttonPressed2 = 8;
                Properties.Settings.Default.buttonPressed2 = buttonPressed2;
                Properties.Settings.Default.Save();
                return;
            }
            if (buttonPressed2 == 8)
            {
                ThemeManager.ChangeAppStyle(Application.Current,
                                             ThemeManager.GetAccent("Teal"),
                                             ThemeManager.GetAppTheme("BaseDark")); ;
                AutoUpdateCheck.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#07908E"));
                MainPlayButton.Background = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#07908E"));
                buttonPressed2 = 9;
                Properties.Settings.Default.buttonPressed2 = buttonPressed2;
                Properties.Settings.Default.Save();
                return;
            }
            if (buttonPressed2 == 9)
            {
                ThemeManager.ChangeAppStyle(Application.Current,
                                             ThemeManager.GetAccent("Cyan"),
                                             ThemeManager.GetAppTheme("BaseDark")); ;
                AutoUpdateCheck.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#1D88BC"));
                MainPlayButton.Background = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#1D88BC"));
                buttonPressed2 = 10;
                Properties.Settings.Default.buttonPressed2 = buttonPressed2;
                Properties.Settings.Default.Save();
                return;
            }
            if (buttonPressed2 == 10)
            {
                ThemeManager.ChangeAppStyle(Application.Current,
                                             ThemeManager.GetAccent("Cobalt"),
                                             ThemeManager.GetAppTheme("BaseDark")); ;
                AutoUpdateCheck.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#0747C6"));
                MainPlayButton.Background = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#0747C6"));
                buttonPressed2 = 11;
                Properties.Settings.Default.buttonPressed2 = buttonPressed2;
                Properties.Settings.Default.Save();
                return;
            }
            if (buttonPressed2 == 11)
            {
                ThemeManager.ChangeAppStyle(Application.Current,
                                             ThemeManager.GetAccent("Indigo"),
                                             ThemeManager.GetAppTheme("BaseDark")); ;
                AutoUpdateCheck.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#5C07D3"));
                MainPlayButton.Background = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#5C07D3"));
                buttonPressed2 = 12;
                Properties.Settings.Default.buttonPressed2 = buttonPressed2;
                Properties.Settings.Default.Save();
                return;
            }
            if (buttonPressed2 == 12)
            {
                ThemeManager.ChangeAppStyle(Application.Current,
                                             ThemeManager.GetAccent("Violet"),
                                             ThemeManager.GetAppTheme("BaseDark")); ;
                AutoUpdateCheck.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#8F07D3"));
                MainPlayButton.Background = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#8F07D3"));
                buttonPressed2 = 13;
                Properties.Settings.Default.buttonPressed2 = buttonPressed2;
                Properties.Settings.Default.Save();
                return;
            }
            if (buttonPressed2 == 13)
            {
                ThemeManager.ChangeAppStyle(Application.Current,
                                             ThemeManager.GetAccent("Pink"),
                                             ThemeManager.GetAppTheme("BaseDark")); ;
                AutoUpdateCheck.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#CA62AD"));
                MainPlayButton.Background = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#CA62AD"));
                buttonPressed2 = 14;
                Properties.Settings.Default.buttonPressed2 = buttonPressed2;
                Properties.Settings.Default.Save();
                return;
            }
            if (buttonPressed2 == 14)
            {
                ThemeManager.ChangeAppStyle(Application.Current,
                                             ThemeManager.GetAccent("Magenta"),
                                             ThemeManager.GetAppTheme("BaseDark")); ;
                AutoUpdateCheck.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#B40763"));
                MainPlayButton.Background = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#B40763"));
                buttonPressed2 = 15;
                Properties.Settings.Default.buttonPressed2 = buttonPressed2;
                Properties.Settings.Default.Save();
                return;
            }
            if (buttonPressed2 == 15)
            {
                ThemeManager.ChangeAppStyle(Application.Current,
                                             ThemeManager.GetAccent("Crimson"),
                                             ThemeManager.GetAppTheme("BaseDark")); ;
                AutoUpdateCheck.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#890725"));
                MainPlayButton.Background = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#890725"));
                buttonPressed2 = 16;
                Properties.Settings.Default.buttonPressed2 = buttonPressed2;
                Properties.Settings.Default.Save();
                return;
            }
            if (buttonPressed2 == 16)
            {
                ThemeManager.ChangeAppStyle(Application.Current,
                                             ThemeManager.GetAccent("Amber"),
                                             ThemeManager.GetAppTheme("BaseDark")); ;
                AutoUpdateCheck.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#C7890F"));
                MainPlayButton.Background = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#C7890F"));
                buttonPressed2 = 17;
                Properties.Settings.Default.buttonPressed2 = buttonPressed2;
                Properties.Settings.Default.Save();
                return;
            }
            if (buttonPressed2 == 17)
            {
                ThemeManager.ChangeAppStyle(Application.Current,
                                             ThemeManager.GetAccent("Yellow"),
                                             ThemeManager.GetAppTheme("BaseDark")); ;
                AutoUpdateCheck.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#D2B90C"));
                MainPlayButton.Background = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#D2B90C"));
                buttonPressed2 = 18;
                Properties.Settings.Default.buttonPressed2 = buttonPressed2;
                Properties.Settings.Default.Save();
                return;
            }
            if (buttonPressed2 == 18)
            {
                ThemeManager.ChangeAppStyle(Application.Current,
                                             ThemeManager.GetAccent("Brown"),
                                             ThemeManager.GetAppTheme("BaseDark")); ;
                AutoUpdateCheck.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#6F4F2A"));
                MainPlayButton.Background = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#6F4F2A"));
                buttonPressed2 = 19;
                Properties.Settings.Default.buttonPressed2 = buttonPressed2;
                Properties.Settings.Default.Save();
                return;
            }
            if (buttonPressed2 == 19)
            {
                ThemeManager.ChangeAppStyle(Application.Current,
                                             ThemeManager.GetAccent("Olive"),
                                             ThemeManager.GetAppTheme("BaseDark")); ;
                AutoUpdateCheck.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#5E7357"));
                MainPlayButton.Background = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#5E7357"));
                buttonPressed2 = 20;
                Properties.Settings.Default.buttonPressed2 = buttonPressed2;
                Properties.Settings.Default.Save();
                return;
            }
            if (buttonPressed2 == 20)
            {
                ThemeManager.ChangeAppStyle(Application.Current,
                                             ThemeManager.GetAccent("Steel"),
                                             ThemeManager.GetAppTheme("BaseDark")); ;
                AutoUpdateCheck.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#576573"));
                MainPlayButton.Background = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#576573"));
                buttonPressed2 = 21;
                Properties.Settings.Default.buttonPressed2 = buttonPressed2;
                Properties.Settings.Default.Save();
                return;
            }
            if (buttonPressed2 == 21)
            {
                ThemeManager.ChangeAppStyle(Application.Current,
                                             ThemeManager.GetAccent("Mauve"),
                                             ThemeManager.GetAppTheme("BaseDark")); ;
                AutoUpdateCheck.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#655475"));
                MainPlayButton.Background = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#655475"));
                buttonPressed2 = 22;
                Properties.Settings.Default.buttonPressed2 = buttonPressed2;
                Properties.Settings.Default.Save();
                return;
            }
            if (buttonPressed2 == 22)
            {
                ThemeManager.ChangeAppStyle(Application.Current,
                                             ThemeManager.GetAccent("Taupe"),
                                             ThemeManager.GetAppTheme("BaseDark")); ;
                AutoUpdateCheck.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#736845"));
                MainPlayButton.Background = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#736845"));
                buttonPressed2 = 23;
                Properties.Settings.Default.buttonPressed2 = buttonPressed2;
                Properties.Settings.Default.Save();
                return;
            }
            if (buttonPressed2 == 23)
            {
                ThemeManager.ChangeAppStyle(Application.Current,
                                             ThemeManager.GetAccent("Sienna"),
                                             ThemeManager.GetAppTheme("BaseDark")); ;
                AutoUpdateCheck.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#87492B"));
                MainPlayButton.Background = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#87492B"));
                buttonPressed2 = 1;
                Properties.Settings.Default.buttonPressed2 = buttonPressed2;
                Properties.Settings.Default.Save();
                return;
            }
        }

        private void Button_Click_16(object sender, RoutedEventArgs e) //LoginAndRegister
        {
            Launcher.LaunchWebsite("http://yukitsuki.com/?p=login");
            buttonPressed3 = false;
            DownList.Visibility = Visibility.Collapsed;
        }

        private void Button_Click_17(object sender, RoutedEventArgs e) //Help
        {
            Launcher.LaunchWebsite("http://yukitsuki.com/?p=forum&sf=92");
            buttonPressed3 = false;
            DownList.Visibility = Visibility.Collapsed;
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)//Forum
        {
            Launcher.LaunchWebsite("http://yukitsuki.com/?p=forum");
            buttonPressed3 = false;
            DownList.Visibility = Visibility.Collapsed;
        }

        private void ServerRatesExit_Click(object sender, RoutedEventArgs e)
        {
            ScrollRates.Visibility = Visibility.Collapsed;
            ScrollBackground.Visibility = Visibility.Collapsed;
            ServerRatesExit.Visibility = Visibility.Collapsed;
        }
    }
}