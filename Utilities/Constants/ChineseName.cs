using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Utilities.Models;
using Utilities.Strings;
using static System.Net.Mime.MediaTypeNames;

namespace Utilities.Constants
{
    public class ChineseName
    {
        private IEnumerable<string> FirstNames;
        private IEnumerable<string> LastMaleNames;
        private IEnumerable<string> LastFeMaleNames;
        private string FirstNameJsonFilePath;
        private string LastNameJsonFilePath;
        // 共计438个姓氏
        private ChineseName()
        {
            FirstNameJsonFilePath = Path.Join(AppDomain.CurrentDomain.BaseDirectory, "Resources/firstnames.json");
            LastNameJsonFilePath = Path.Join(AppDomain.CurrentDomain.BaseDirectory, "Resources/lastnames.json");
            FirstNames = JsonHelper.GetObjectFromJson<IEnumerable<string>>(FirstNameJsonFilePath);
            var lastName = JsonHelper.GetObjectFromJson<ChineseLastName>(LastNameJsonFilePath);
            LastFeMaleNames = lastName.FeMaleNames;
            LastMaleNames = lastName.MaleNames;
        }

        public static IEnumerable<string> GetFirstNames()
        {
            return new ChineseName().FirstNames;
        }

        public static IEnumerable<string> GetLastMaleNames()
        {
            return new ChineseName().LastMaleNames;
        }

        public static IEnumerable<string> GetLastFeMaleNames()
        {
            return new ChineseName().LastFeMaleNames;
        }


    }
}
