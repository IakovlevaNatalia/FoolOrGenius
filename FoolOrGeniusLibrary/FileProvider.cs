using System.IO;
using System.Text;

namespace FoolOrGeniusLibrary
{
    internal class FileProvider
    {
        public static void Append(string fileName, string value)
        {
            var sw = new StreamWriter(fileName, true, Encoding.UTF8);
            sw.WriteLine(value);
            sw.Close();
        }
        public static void Replace (string fileName, string value) // перезапись файла. false означает что перезаписываем
        {
            var sw = new StreamWriter(fileName, false, Encoding.UTF8);
            sw.WriteLine(value);
            sw.Close();
        }
        public static string GetValue(string fileName)
        {
            var sr = new StreamReader(fileName, Encoding.UTF8);
            var value = sr.ReadToEnd();
            sr.Close();
            return value;
        }
        public static bool Exists(string fileName)
        {
            return File.Exists(fileName);
        }
        public static void Clear(string fileName)
        {
            File.WriteAllText(fileName, string.Empty);
        }
    }
}
