using System;
using System.Linq;

// 🔹 Helper Class (Extension Methods)
public static class Helper
{
    public static bool IsOdd(this int number)
    {
        return number % 2 != 0;
    }

    public static bool IsEven(this int number)
    {
        return number % 2 == 0;
    }

    public static bool HasDigit(this string text)
    {
        if (string.IsNullOrEmpty(text))
            return false;

        return text.Any(char.IsDigit);
    }

    public static bool CheckPassword(this string password)
    {
        if (string.IsNullOrEmpty(password) || password.Length < 8)
            return false;

        bool hasUpper = password.Any(char.IsUpper);
        bool hasLower = password.Any(char.IsLower);
        bool hasDigit = password.Any(char.IsDigit);

        return hasUpper && hasLower && hasDigit;
    }

    public static string Capitalize(this string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return text;

        text = text.Trim();

        return char.ToUpper(text[0]) + text.Substring(1).ToLower();
    }
}

// 🔹 Program
class Program
{
    static void Main()
    {
        int num = 7;

        Console.WriteLine("IsOdd: " + num.IsOdd());
        Console.WriteLine("IsEven: " + num.IsEven());

        string text = "Arzu005";
        Console.WriteLine("HasDigit: " + text.HasDigit());

        string password = "Zeynalov0411";
        Console.WriteLine("CheckPassword: " + password.CheckPassword());

        string name = "aRZU";
        Console.WriteLine("Capitalize: " + name.Capitalize());
    }
}