//Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
//Note: The © symbol may be displayed incorrectly at the console so you may need to change
//the console character encoding to UTF-8 and assign a Unicode-friendly font in the console.
//Note: Under old versions of Windows the © symbol may still be displayed incorrectly,
//regardless of how much effort you put to fix it.

using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        char copyRight = '\u00A9';
        Console.WriteLine("    {0}", copyRight);
        Console.WriteLine("    ");
        Console.WriteLine("   {0} {1}", copyRight, copyRight);
        Console.WriteLine("    ");
        Console.WriteLine("  {0}   {1}",copyRight, copyRight);
        Console.WriteLine("    ");
        Console.WriteLine(" {0} {1} {2} {3}",copyRight, copyRight, copyRight, copyRight);
    }
}
