namespace _64BitArray
{
    using System;
    using System.Text;

    public class SixtyFourBitArrayMain
    {
        public static void Main()
        {
            BitArray64 bits = new BitArray64(123456789999);
            Console.WriteLine(string.Join("", bits));
            Console.WriteLine("Hash code: {0}", bits.GetHashCode());

            BitArray64 anotherBits = new BitArray64(123456789999);
            Console.WriteLine(string.Join("", anotherBits));
            Console.WriteLine("Hash code: {0}", anotherBits.GetHashCode());

            Console.WriteLine("Equals: {0}", bits.Equals(anotherBits));
            Console.WriteLine(" == {0}", bits == anotherBits);
            Console.WriteLine(" != {0}", bits != anotherBits);

            Console.WriteLine("Foreach:");
            foreach (var bit in bits)
            {
                Console.Write(bit);
            }

            Console.WriteLine();

            Console.WriteLine("For:");
            for (int i = 0; i < bits.Bits.Length; i++)
            {
                Console.Write(bits.Bits[i]);
            }

            Console.WriteLine();
        }
    }
}
