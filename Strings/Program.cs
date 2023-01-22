namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string string1 = "bacd";
            string string2 = "bacd";
            string string3 = "abCab1%";
            Console.WriteLine(Compare(string1, string2));
            Console.WriteLine(Compare(string1, string3));
            Analyze(string3);
            Console.WriteLine(Sort(string1));
            Dublicate(string3);
        }
        public static bool Compare(string str, string str1)
        {            
            if(str == str1)
                return true;
            else return false;            
        }
        public static string Analyze(string str)
        {
            Console.WriteLine(Char.IsLetterOrDigit(str, 2));

            str.ToCharArray();
            for (int i=0; i<str.Length; i++)
            {
                if (Char.IsLetterOrDigit(str[i]))
                {
                    if (Char.IsLetter(str[i]))
                        Console.WriteLine(str[i] + " is letter");
                    else Console.WriteLine(str[i] + " is number");
                }
                else Console.WriteLine(str[i] + " is symbol");
            }
            return str;
        }
        public static string Sort(string str)
        {
            char[] strr = str.ToCharArray();
            Array.Sort(strr);
            return new string(strr);
        }
        public static void Dublicate(string str)
        {            
            var duplicates = new List<char>();
            foreach (var i in str)
            {
                if (str.IndexOf(i) != str.LastIndexOf(i) && !duplicates.Contains(i))
                {
                    duplicates.Add(i);
                }
            }
            Console.WriteLine(string.Join(",", duplicates));
           
        }
    }
}