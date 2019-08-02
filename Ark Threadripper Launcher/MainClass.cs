using System.Diagnostics;

namespace Ark_Threadripper_Launcher
{
    class Launcher
    {
        public static void LaunchWebsite(string url)
        {
            Process.Start(url);
        }
    }

}