namespace RangeExceptions
{
    using System;
    using System.Globalization;

    public class RangeExceptionsMain
    {
        public static void Main()
        {
            Console.WriteLine("Insert number:");
            int number = int.Parse(Console.ReadLine());

            if (number < 1 || number > 100)
            {
                throw new InvalidRangeException<int>("Number must be in rage [1...100", 1, 100);
            }

            Console.WriteLine("Insert date dd/MM/yyyy format:");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            var startDate = new DateTime(1980, 1, 1);
            var endDate = new DateTime(2013, 12, 31);

            if (date < startDate || date > endDate)
            {
                throw new InvalidRangeException<DateTime>("Date must be in range [1.1.1980] - [31.12.2013]", startDate, endDate);
            }
        }
    }
}
