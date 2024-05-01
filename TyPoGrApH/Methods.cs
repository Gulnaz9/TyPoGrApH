
using System.Text.RegularExpressions;

namespace TyPoGrApH
{
    public class Methods
    {

        /// <summary>
        /// п.9; замена cимвола «плюс-минус» на ±
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ReplacePlusMinus(string str)
        {
            if (str.Contains("(+,-)"))
            {
                str = str.Replace("(+,-)", "±");
            }
            return str;
        }

        /// <summary>
        /// п.2; замена двух пробелов одним
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ReplaceToOneSpace(string str)
        {
            if (str.Contains("  "))
            {
                str = str.Replace("  ", " ");
            }
            return str;
        }

        /// <summary>
        /// п.3; замена програмистских кавычек ёлочками
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string ReplaceQuotes(string str)
        {
            var res = Regex.Replace(str, "\"(.+?)\"", "«$1»");
            return res;
        }

        /// <summary>
        /// п.13; замена трёх точек символом многоточия
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ReplaceDots(string str)
        {
            if (str.Contains("..."))
            {
                str = str.Replace("...", "…");
            }
            return str;
        }

        /// <summary>
        /// п.1; знаки препинания слева слитно со словом, справа - пробел, скобки и кавычки - слитно со словами внутри, вокруг тире - пробел
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string WorkWithCharsAndSpaces(string str)
        {
            //если перед символом есть пробел
            string[] chars = new string[] { ",", ";", ":", "!", "?", ".", "…" };
            foreach (string c in chars)
            {
                if (str.Contains(" " + c + " "))
                    str = str.Replace(" " + c + " ", c + " ");
                if (str.Contains(" " + c))
                    str = str.Replace(" " + c, c + " ");
            }

            //если вокруг тире нет пробелов
            if (str.Contains("—"))
                str = str.Replace("—", " — ");

            //если в скобках и кавычках не слитно
            string[] firstBracket = new string[] { "(", "«" };
            foreach (string b in firstBracket)
            {
                if (str.Contains(b + " "))
                    str = str.Replace(b + " ", b);
            }

            string[] secondBracket = new string[] { ")", "»" };
            foreach (string b in secondBracket)
            {
                if (str.Contains(" " + b))
                    str = str.Replace(" " + b, b);
            }

            return str;
        }

        /// <summary>
        /// моё правило - слово хештег заменяется на шарп)
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ReplaceHashtage(string str)
        {
            if (str.Contains("хештег"))
            {
                str = str.Replace("хештег", "шарп");
            }
            return str;
        }

        /// <summary>
        /// моё правило - заменять мягкий знак на «б» как будто ошибка
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ReplaceToNearChar(string str)
        {
            if (str.Contains("ь"))
            {
                str = str.Replace("ь", "б");
            }
            return str;
        }

        /// <summary>
        /// моё правило - каждая вторая буква заменяется на заглавную
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string MakeAbsurd(string str)
        {
            string[] words = str.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    string word = words[i];
                    char[] letters = word.ToCharArray();

                    for (int j = 1; j < letters.Length; j += 2)
                    {
                        letters[j] = char.ToUpper(letters[j]);
                    }

                    words[i] = new string(letters);
                }
            }

            return string.Join(" ", words);
        }
    }
}
