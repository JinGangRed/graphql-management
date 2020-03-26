using System;
using System.Linq;
using System.Text;
using Utilities.Constants;
using Utilities.Models;

namespace Utilities.Strings
{
    public static class ChineseCharacter
    {
        /// <summary>
        /// 生成中文字
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// 生成中文字
        /// </summary>
        /// <param name="num">生成中文字的个数,默认只生成一个</param>
        /// <returns></returns>
        public static string GenerateChineseWord(int num = 1)
        {
            var words = "";
            for (int i = 0; i < num; i++)
            {
                words += GenerateChineseWord();
            }
            return words;
        }
        /// <summary>
        /// 生成中文名字
        /// </summary>
        /// <param name="hasSplit">是否在姓和名之间添加间隔,默认不添加间隔</param>
        /// <returns></returns>
        public static string GenerateChineseName()
        {
            var random = new Random().Next(1,3);
            return string.Concat(GenerateFirstName(), GenerateLastName());
        }
        /// <summary>
        /// 生成中文名字
        /// </summary>
        /// <param name="gender">生成性别的名字</param>
        /// <param name="hasSplit"></param>
        /// <returns></returns>
        public static string GenerateChineseName(Gender gender = Gender.UnKnown)
        {
            var random = new Random().Next(1, 3);
            return string.Concat(GenerateFirstName(), GenerateLastName(gender));
        }
        /// <summary>
        /// 生成姓
        /// </summary>
        /// <returns></returns>
        public static string GenerateFirstName()
        {
            Random random = new Random();
            var firsteNames = ChineseName.GetFirstNames();
            return firsteNames.ElementAt(random.Next(0, firsteNames.Count()));
        }
        /// <summary>
        /// 生成名字
        /// </summary>
        /// <param name="gender"></param>
        /// <returns></returns>
        public static string GenerateLastName(Gender gender = Gender.UnKnown)
        {
            Random random = new Random();
            var lastName = "";
            var lastNames = ChineseName.GetLastMaleNames().Concat(ChineseName.GetLastFeMaleNames());
            if (gender == Gender.Male)
            {
                lastNames = ChineseName.GetLastMaleNames();
            }
            if (gender == Gender.Female)
            {
                lastNames = ChineseName.GetLastFeMaleNames();
            }
            var lastNameCountWord = new Random().Next(1, 3);
            for (int i = 0; i < lastNameCountWord; i++)
            {
                lastName += lastNames.ElementAt(random.Next(lastNames.Count()));
            }
            return lastName;
        }
    }
}
