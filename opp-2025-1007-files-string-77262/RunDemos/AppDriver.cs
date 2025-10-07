using opp_2025_1007_files_string_77262.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opp_2025_1007_files_string_77262.RunDemos
{
    internal static class AppDriver
    {
        public static void Run()
        {
            ShowAppData();
        }

        public static void ShowAppData()
        {
            Console.WriteLine($"{ AppData.AppName} : { AppData.AppVersion} : { AppData.AppAuthor}");
        }
    }
}
