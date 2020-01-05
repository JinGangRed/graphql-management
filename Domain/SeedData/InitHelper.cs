using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.SeedData
{
    public class InitHelper
    {
        public static string GenerateChineseWord()
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

        public static string GenerateChineseWord(int num)
        {
            var words = "";
            for (int i = 0; i < num; i++)
            {
                words += GenerateChineseWord();
            }
            return words;
        }

    }
}
