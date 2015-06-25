using System;
using System.Text;

public static class RandomMethodExtensions
{
    public static string NextString(this Random r, int length)
    {
        var data = new byte[length];
        for (int i = 0; i < data.Length; i++)
        {
            data[i] = (byte)r.Next(35, 150);
        }

        var encoding = new ASCIIEncoding();
        return encoding.GetString(data);
    }

    public static string NextString(this Random r)
    {
        int length = r.Next(10, 40);
        return NextString(r, length);
    }
}
