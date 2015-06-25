namespace Problem17.LongestString
{
    using System;
    using System.Linq;

    public class LongestString
    {
        public static int maxLength = 0;
        private static readonly Random rnd = new Random();

        static void Main()
        {
            string[] stringArr = GenerateRandomStrings();

            var solutionWithLINQ =
                from s in stringArr
                where GetLongestString(s)
                select s;

            Console.WriteLine("LongestString: {0}", solutionWithLINQ.Last());
            Console.WriteLine("Length; {0}", maxLength);
        }

        private static bool GetLongestString(string s)
        {
            if (s.Length > maxLength)
            {
                maxLength = s.Length;
                return true;
            }

            return false;
        }

        private static string[] GenerateRandomStrings()
        {
            string[] resultArr = new string[rnd.Next(10, 40)];
            for (int i = 0; i < resultArr.Length; i++)
            {
                resultArr[i] = rnd.NextString();
            }

            return resultArr;
        }
    }
}
