using System;
using System.Diagnostics;
using System.IO;

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