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
using SimpleRSS;
using System.Collections.Generic;

namespace Ark_Threadripper_Launcher
{
    public partial class MainWindow : MetroWindow, INotifyPropertyChanged
    {
        // Constructor
        public MainWindow()
        {
            InitializeComponent();
            bool check = AutoUpdateCheck.IsChecked.GetValueOrDefault(false);
            AutoUpdateCheck.IsChecked = Settings.Default.CheckBox;

            ((App)Application.Current).WindowPlace.Register(this);

            // Check for auto-update
            if (AutoUpdate)
            {
                AutoUpdater.Start("https://www.dropbox.com/s/rdkn2ie547cs9kr/UpdateData.xml?dl=1");
            }

            // Ensure buttonPressed2 stays within bounds
            buttonPressed2 = Math.Max(Settings.Default.buttonPressed2 - 1, 1);

            // Apply theme based on buttonPressed2
            ApplyTheme(buttonPressed2);
        }

        bool buttonPressed = false;
        bool buttonPressed1 = false;
        int buttonPressed2 = Properties.Settings.Default.buttonPressed2 - 1;
        bool buttonPressed3 = false;
        bool buttonPressed4 = false;
        bool buttonPressed5 = false;

        bool AutoUpdate = false;
        public string NewURL { get; set; }
        public string Link { get; set; }
        public static string TextDir { get; set; }

        // Refactored method to apply theme
        private void ApplyTheme(int buttonPressed2)
        {
            var themes = new Dictionary<int, (string Accent, string ColorCode)>
            {
                { 1, ("Red", "#FF0000") },
                { 2, ("Green", "#548E19") },
                { 3, ("Blue", "#1585B5") },
                { 4, ("Purple", "#574EB9") },
                { 5, ("Orange", "#CF5A07") },
                { 6, ("Lime", "#8AA407") },
                { 7, ("Emerald", "#077507") },
                { 8, ("Teal", "#07908E") },
                { 9, ("Cyan", "#1D88BC") },
                { 10, ("Cobalt", "#0747C6") },
                { 11, ("Indigo", "#5C07D3") },
                { 12, ("Violet", "#8F07D3") },
                { 13, ("Pink", "#CA62AD") },
                { 14, ("Magenta", "#B40763") },
                { 15, ("Crimson", "#890725") },
                { 16, ("Amber", "#C7890F") },
                { 17, ("Yellow", "#D2B90C") },
                { 18, ("Brown", "#6F4F2A") },
                { 19, ("Olive", "#5E7357") },
                { 20, ("Steel", "#576573") },
                { 21, ("Mauve", "#655475") },
                { 22, ("Taupe", "#736845") },
                { 23, ("Sienna", "#87492B") }
            };

            if (themes.TryGetValue(buttonPressed2, out var theme))
            {
                ThemeManager.ChangeAppStyle(Application.Current,
                                            ThemeManager.GetAccent(theme.Accent),
                                            ThemeManager.GetAppTheme("BaseDark"));

                var colorBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString(theme.ColorCode));
                AutoUpdateCheck.Foreground = colorBrush;
                MainPlayButton.Background = colorBrush;
            }
        }

        // Play Button Click Event
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Launcher.LaunchWebsite(Link);
        }

        // Screenshot Button Click Event
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                // Try to access Steam screenshots directory
                OpenScreenshotsDirectory(@"C:\Program Files (x86)\Steam\userdata\", "760", "remote", "346110", "screenshots");
            }
            catch
            {
                try
                {
                    // Handle settings directory if Steam screenshots directory fails
                    var settings = new Settings();
                    SettingsTextBar.Text = settings.SettingsValue;
                    System.Diagnostics.Process.Start(TextDir);
                }
                catch (Exception)
                {
                    // Show error window in case of failure
                    ShowErrorDialog();
                }
            }
        }

        // Method to open screenshots directory
        private void OpenScreenshotsDirectory(string rootDir, string subDir1, string subDir2, string subDir3, string screenshotsFolder)
        {
            var userDir = Directory.EnumerateDirectories(rootDir).First();
            var screenshotsDir = Path.Combine(userDir, subDir1, subDir2, subDir3, screenshotsFolder);

            if (Directory.Exists(screenshotsDir))
            {
                System.Diagnostics.Process.Start(screenshotsDir);
            }
            else
            {
                throw new DirectoryNotFoundException();
            }
        }

        // Method to show error dialog with blur effect
        private void ShowErrorDialog()
        {
            Application.Current.MainWindow.Effect = new BlurEffect();
            Error errorDialog = new Error();
            errorDialog.ShowDialog();
            Application.Current.MainWindow.Effect = null;
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

        private Dictionary<string, (FrameworkElement Button, FrameworkElement Background, FrameworkElement Logo)> buttonElements;
        private Dictionary<string, (Thickness ButtonMargin, Thickness LogoMargin)> initialMargins;
        private string steamConnectionLink;

        private void InitializeButtonElements()
        {
            buttonElements = new Dictionary<string, (FrameworkElement, FrameworkElement, FrameworkElement)>
        {
            {"Island", (ButtonIsland, IslandButtonBackground, IslandLogo)},
            {"Scorched", (ScorchedButton, ScorchedButtonBackground, ScorchedLogo)},
            {"Aberration", (AberrationButton, AberrationButtonBackground, AberrationLogo)},
            {"Extinction", (ExtinctionButton, ExtinctionButtonBackground, ExtinctionLogo)},
            {"Center", (CenterButton, CenterButtonBackground, CenterLogo)},
            {"Ragnarok", (RagnarokButton, RagnarokButtonBackground, RagnarokLogo)},
            {"Valguero", (ValgueroButton, ValgueroButtonBackground, ValgueroLogo)},
            {"NoTame", (NoTameButton, NoTameButtonBackground, null)},
            {"SmallIslands", (SmallIslandsButton, SmallIslandsButtonBackground, null)}
        };
        }

        private void InitializeInitialMargins()
        {
            initialMargins = new Dictionary<string, (Thickness ButtonMargin, Thickness LogoMargin)>
        {
            {"Island", (new Thickness(0, 63, 0, 0), new Thickness(12, 64, 0, 0))},
            {"Scorched", (new Thickness(0, 103, 0, 0), new Thickness(14, 105, 0, 0))},
            {"Aberration", (new Thickness(0, 143, 0, 0), new Thickness(14, 145, 0, 0))},
            {"Extinction", (new Thickness(0, 183, 0, 0), new Thickness(10, 182, 0, 0))},
            {"Center", (new Thickness(2, 267, 0, 0), new Thickness(-13, 250, 0, 0))},
            {"Ragnarok", (new Thickness(2, 306, 0, 0), new Thickness(13, 306, 0, 0))},
            {"Valguero", (new Thickness(2, 346, 0, 0), new Thickness(10, 346, 0, 0))},
            {"NoTame", (new Thickness(0, 0, 0, 130), new Thickness(0, 0, 0, 130))},
            {"SmallIslands", (new Thickness(1, 0, 0, 90), new Thickness(1, 0, 0, 90))}
        };
        }

        private void ResetButtonsToInitialPosition(string exceptButton)
        {
            if (buttonElements == null || initialMargins == null)
            {
                InitializeButtonElements();
                InitializeInitialMargins();
            }

            foreach (var kvp in buttonElements)
            {
                if (kvp.Key != exceptButton)
                {
                    var margins = initialMargins[kvp.Key];
                    kvp.Value.Button.Margin = margins.ButtonMargin;
                    kvp.Value.Background.Margin = margins.ButtonMargin;
                    if (kvp.Value.Logo != null)
                    {
                        kvp.Value.Logo.Margin = margins.LogoMargin;
                    }
                }
            }
        }

        private void UpdateSelectedButton(string buttonName, Thickness newButtonMargin, Thickness newLogoMargin, string backgroundImageUri, string steamLink)
        {
            if (buttonElements == null || initialMargins == null)
            {
                InitializeButtonElements();
                InitializeInitialMargins();
            }

            Background.Source = new BitmapImage(new Uri(backgroundImageUri, UriKind.Absolute));
            steamConnectionLink = steamLink;

            var (button, background, logo) = buttonElements[buttonName];
            button.Margin = newButtonMargin;
            background.Margin = newButtonMargin;
            if (logo != null)
            {
                logo.Margin = newLogoMargin;
            }

            ResetButtonsToInitialPosition(buttonName);

            if (buttonName == "NoTame" || buttonName == "SmallIslands")
            {
                SelectedButDown.Margin = new Thickness(6, 0, 0, newButtonMargin.Bottom + 16);
                SelectedBut.Margin = new Thickness(-200, 437, 0, 0);
            }
            else
            {
                SelectedBut.Margin = new Thickness(6, newButtonMargin.Top + 16, 0, 0);
                SelectedButDown.Margin = new Thickness(-200, 0, 0, 136);
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e) // Center
        {
            UpdateSelectedButton("Center", new Thickness(25, 267, 0, 0), new Thickness(1, 250, 0, 0),
                "pack://application:,,,/ArkThreadripperLauncher;component/Resources/Center.jpg",
                "steam://connect/27.33.160.254:27016");
        }

        private void Button_Click_8(object sender, RoutedEventArgs e) // Island
        {
            UpdateSelectedButton("Island", new Thickness(25, 63, 0, 0), new Thickness(25, 63, 0, 0),
                "pack://application:,,,/ArkThreadripperLauncher;component/Resources/TheIsland.jpg",
                "steam://connect/27.33.160.254:27015");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) // Scorched Earth
        {
            UpdateSelectedButton("Scorched", new Thickness(25, 103, 0, 0), new Thickness(25, 103, 0, 0),
                "pack://application:,,,/ArkThreadripperLauncher;component/Resources/ScorchedEarth.png",
                "steam://connect/27.33.160.254:27017");
        }

        private void Button_Click_9(object sender, RoutedEventArgs e) // Ragnarok
        {
            UpdateSelectedButton("Ragnarok", new Thickness(25, 306, 0, 0), new Thickness(28, 306, 0, 0),
                "pack://application:,,,/ArkThreadripperLauncher;component/Resources/Ragnarok.jpg",
                "steam://connect/27.33.160.254:27018");
        }

        private void Button_Click_10(object sender, RoutedEventArgs e) // Extinction
        {
            UpdateSelectedButton("Extinction", new Thickness(25, 183, 0, 0), new Thickness(25, 183, 0, 0),
                "pack://application:,,,/ArkThreadripperLauncher;component/Resources/Extinction.jpg",
                "steam://connect/27.33.160.254:27024");
        }

        private void Button_Click_11(object sender, RoutedEventArgs e) // Aberration
        {
            UpdateSelectedButton("Aberration", new Thickness(25, 143, 0, 0), new Thickness(25, 143, 0, 0),
                "pack://application:,,,/ArkThreadripperLauncher;component/Resources/Aberration.jpg",
                "steam://connect/27.33.160.254:27020");
        }

        private void Button_Click_14(object sender, RoutedEventArgs e) // Small Islands
        {
            UpdateSelectedButton("SmallIslands", new Thickness(25, 0, 0, 90), new Thickness(25, 0, 0, 90),
                "pack://application:,,,/ArkThreadripperLauncher;component/Resources/SmallIslands1.jpg",
                "steam://connect/27.33.160.254:27019");
        }

        private void Button_Click_111(object sender, RoutedEventArgs e) // Valguero
        {
            UpdateSelectedButton("Valguero", new Thickness(25, 346, 0, 0), new Thickness(25, 346, 0, 0),
                "pack://application:,,,/ArkThreadripperLauncher;component/Resources/Valguero.jpg",
                "steam://connect/yukitsuki.com:27025");
        }

        private void ToggleButton_Checked_10(object sender, RoutedEventArgs e) // No Tame
        {
            UpdateSelectedButton("NoTame", new Thickness(25, 0, 0, 130), new Thickness(25, 0, 0, 130),
                "pack://application:,,,/ArkThreadripperLauncher;component/Resources/SOTF.jpg",
                "steam://connect/27.33.160.254:27022");
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
            if (!buttonPressed5)
            {
                DiscordWidget.Visibility = Visibility.Visible;
                DoubleAnimation doubleanimation = new DoubleAnimation(0, 1, new Duration(TimeSpan.FromSeconds(1)));
                DiscordWidget.BeginAnimation(OpacityProperty, doubleanimation);
            buttonPressed5 = true;
            }
            else
            {
                DiscordWidget.Visibility = Visibility.Collapsed;
            buttonPressed5 = false;
            }
        }

        private void SettingsTextBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextDir = SettingsTextBar.Text;
        }

        public event PropertyChangedEventHandler PropertyChanged;

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

        private void Button_Click_19(object sender, RoutedEventArgs e) // Color Menu
        {
            ApplyTheme(buttonPressed2);

            // Update buttonPressed2 for next color in sequence
            buttonPressed2 = buttonPressed2 == 23 ? 1 : buttonPressed2 + 1;

            // Save the new buttonPressed2 value in the settings
            Properties.Settings.Default.buttonPressed2 = buttonPressed2;
            Properties.Settings.Default.Save();
        }

        private void ServerRatesExit_Click(object sender, RoutedEventArgs e)
        {
            ScrollRates.Visibility = Visibility.Collapsed;
            ScrollBackground.Visibility = Visibility.Collapsed;
            ServerRatesExit.Visibility = Visibility.Collapsed;
        }

        private void News_Click(object sender, RoutedEventArgs e)
        {
            if (!buttonPressed4)
            {
                RSSbrowser.Visibility = Visibility.Visible;
                RSSTitle.Visibility = Visibility.Visible;
                RSSTitleBackground.Visibility = Visibility.Visible;
                buttonPressed4 = true;
                DoubleAnimation doubleanimation = new DoubleAnimation(0, 1, new Duration(TimeSpan.FromSeconds(1)));
                RSSbrowser.BeginAnimation(OpacityProperty, doubleanimation);
                RSSTitle.BeginAnimation(OpacityProperty, doubleanimation);
                RSSTitleBackground.BeginAnimation(OpacityProperty, doubleanimation);
            }
            else
            {
                RSSbrowser.Visibility = Visibility.Hidden;
                RSSTitle.Visibility = Visibility.Hidden;
                RSSTitleBackground.Visibility = Visibility.Hidden;
                buttonPressed4 = false;
            }

            List<SimpleRSS.feed> FeedList = new List<SimpleRSS.feed>();
            List<string> FeedURLs = new List<string>();

            //Ark RSS
            FeedURLs.Add("https://survivetheark.com/index.php?/rss/3-ark-news.xml/");

            //Creates combined feed list from each feed supplied
            FeedList = RSS.getFeeds(FeedURLs);

            foreach (SimpleRSS.feed newsItem in FeedList)
            {
                RSSTitle.Text = newsItem.title;
                RSSbrowser.Address = newsItem.link;
            }
        }
    }
}