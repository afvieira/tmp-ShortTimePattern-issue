using System;
using System.Globalization;

namespace ShortTimePatternIssue // Note: actual namespace depends on the project name.
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var installedUiCulture = CultureInfo.InstalledUICulture;
            var shortTimePatternInstalledUiCult = installedUiCulture.DateTimeFormat.ShortTimePattern;

            var currentCulture = CultureInfo.CurrentCulture;
            var shortTimePatternCurrentCult = currentCulture.DateTimeFormat.ShortTimePattern;

            var invariantCulture = CultureInfo.InvariantCulture;
            var shortTimePatternInvariantCult = invariantCulture.DateTimeFormat.ShortTimePattern;

            var currentUiCulture = CultureInfo.CurrentUICulture;
            var shortTimePatternCurrentUiCult = currentUiCulture.DateTimeFormat.ShortTimePattern;

            Console.WriteLine("[shortTimePatternInstalledUICult] 2021/10/01 15:00:30 --> " + new DateTime(2021,10,1,15,0,30).ToString(shortTimePatternInstalledUiCult));
            Console.WriteLine("[shortTimePatternCurrentCult] 2021/10/01 15:00:30 ------> " + new DateTime(2021,10,1,15,0,30).ToString(shortTimePatternCurrentCult));
            Console.WriteLine("[shortTimePatternInvariantCult] 2021/10/01 15:00:30 ----> " + new DateTime(2021,10,1,15,0,30).ToString(shortTimePatternInvariantCult));
            Console.WriteLine("[shortTimePatternCurrentUICult] 2021/10/01 15:00:30 ----> " + new DateTime(2021,10,1,15,0,30).ToString(shortTimePatternCurrentUiCult));
            Console.WriteLine("[ShortTimePattern] 2021/10/01 15:00:30 -----------------> " + new DateTime(2021,10,1,15,0,30).ToString(shortTimePatternInstalledUiCult));
            Console.WriteLine("[ShortTimePattern] 2021/10/01 15:00:30 -----------------> " + new DateTime(2021,10,1,15,0,30).ToString(shortTimePatternInstalledUiCult));
        }
    }
}