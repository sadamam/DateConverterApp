using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("أدخل التاريخ بصيغة YYYY/MM/DD (مثل 2025/6/22):");
        string inputDate = Console.ReadLine();

        // تحويل التاريخ
        DateTime parsedDate;
        if (DateTime.TryParse(inputDate, out parsedDate))
        {
            // عرض التاريخ المحول
            Console.WriteLine($"التاريخ المدخل: {parsedDate}");
            Console.WriteLine($"التاريخ بالميلي ثانية: {GetMilliseconds(parsedDate)}");
            Console.WriteLine($"التاريخ بصيغة Hex: {GetHex(parsedDate)}");
        }
        else
        {
            Console.WriteLine("تنسيق التاريخ غير صحيح.");
        }

        Console.WriteLine("اضغط على [Enter] للخروج...");
        Console.ReadLine();
    }

    // دالة للحصول على الميلي ثانية
    static long GetMilliseconds(DateTime date)
    {
        return new DateTimeOffset(date).ToUnixTimeMilliseconds();
    }

    // دالة لتحويل التاريخ إلى Hex
    static string GetHex(DateTime date)
    {
        long milliseconds = GetMilliseconds(date);
        return milliseconds.ToString("X"); // تحويل الرقم إلى Hex
    }
}
