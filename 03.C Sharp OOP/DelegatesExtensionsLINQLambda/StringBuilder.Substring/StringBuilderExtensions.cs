using System;
using System.Text;

/// <summary>
/// Implement an extension method Substring(int index, int length) for
/// the class StringBuilder that returns new StringBuilder and has
/// the same functionality as Substring in the class String.
/// </summary>
public static class StringBuilderExtensions
{
    static void Main()
    {
        var firstSB = new StringBuilder();
        firstSB.Append("Welcome to C Sharp programming, how are you?\n");
        firstSB.Append("I am great.");


        var secondSB = firstSB.Substring(19, 11);
        Console.WriteLine(firstSB);
        Console.WriteLine(secondSB);
        secondSB.Clear();
        Console.WriteLine();

        secondSB = firstSB.Substring(19);
        Console.WriteLine(secondSB);
    }

    public static StringBuilder Substring(this StringBuilder sb, int index, int length)
    {
        if (index < 0)
        {
            throw new ArgumentOutOfRangeException("Index out of range.");
        }
        if (index > sb.Length)
        {
            throw new ArgumentOutOfRangeException("Index out of range.");
        }
        if (length < 0)
        {
            throw new ArgumentOutOfRangeException("Length out of range.");
        }
        if (index > sb.Length - length)
        {
            throw new ArgumentOutOfRangeException("Length out of range.");
        }
        if (length == 0)
        {
            return sb.Clear();
        }
        if (index == 0 && length == sb.Length)
        {
            return sb;
        }

        return new StringBuilder(sb.ToString().Substring(index, length));
    }

    public static StringBuilder Substring(this StringBuilder sb, int index)
    {
        if (index < 0)
        {
            throw new ArgumentOutOfRangeException("Index out of range.");
        }
        if (index > sb.Length)
        {
            throw new ArgumentOutOfRangeException("Index out of range.");
        }

        return new StringBuilder(sb.ToString().Substring(index));
    }
}
