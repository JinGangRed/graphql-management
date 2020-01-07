using System;
using System.Linq;
using System.Text;
using Utilities.Constants;

namespace Utilities.Strings
{
    public static partial class StringExtensions
    {
        private static string GenerateChineseWord()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var rnd = new Random();
            // 区码
            var regionCode = rnd.Next(16, 56);
            // 位码
            var positionCode = rnd.Next(1, regionCode > 55 ? 90 : 95);
            var bytesCode = new byte[] { (byte)(regionCode + 160), (byte)(positionCode + 160) };
            return Encoding.GetEncoding("GB2312").GetString(bytesCode);
        }

        public static string GenerateChineseName(bool hasSplit = true)
        {
            var random = new Random().Next(1,3);
            return string.Concat(GetRandomSurname(), hasSplit?" ":"", GenerateChineseWord(random).Trim());
        }
        public static string GenerateChineseWord(int num)
        {
            var words = "";
            for (int i = 0; i < num; i++)
            {
                words += GenerateChineseWord();
            }
            return words;
        }

        public static string GetRandomSurname()
        {
            Random random = new Random();
            var surnames = ChineseSurname.GetSurname();
            return surnames.ElementAt(random.Next(0, surnames.Count()));
        }
    }
}
