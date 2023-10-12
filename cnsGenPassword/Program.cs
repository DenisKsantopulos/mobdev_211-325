using System;
using System.Text;
using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        int passwordCount = 5; // Количество паролей
        int passwordLength = 8; // Длина пароля
        bool useNumbers = true; // Использование цифр
        bool useLowercase = true; // Использование букв в нижнем регистре
        bool useUppercase = true; // Использование букв в верхнем регистре
        bool useSpecialChars = true; // Использование специальных символов

        List passwords = GeneratePasswords(passwordCount, passwordLength, useNumbers, useLowercase, useUppercase, useSpecialChars);

        foreach (string password in passwords)
        {
            Console.WriteLine(password);
        }
    }

    static List GeneratePasswords(int count, int length, bool useNumbers, bool useLowercase, bool useUppercase, bool useSpecialChars)
    {
        List passwords = new List();
        const string numbers = "0123456789";
        const string lowercaseLetters = "abcdefghijklmnopqrstuvwxyz";
        const string uppercaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string specialChars = "!@#$%^&*()";

        RandomNumberGenerator rng = RandomNumberGenerator.Create();

        for (int i = 0; i < count; i++)
        {
            StringBuilder password = new StringBuilder();

            if (useNumbers)
            {
                password.Append(numbers[new Random(GetRandomSeed()).Next(0, numbers.Length)]);
            }

            if (useLowercase)
            {
                password.Append(lowercaseLetters[new Random(GetRandomSeed()).Next(0, lowercaseLetters.Length)]);
            }

            if (useUppercase)
            {
                password.Append(uppercaseLetters[new Random(GetRandomSeed()).Next(0, uppercaseLetters.Length)]);
            }

            if (useSpecialChars)
            {
                password.Append(specialChars[new Random(GetRandomSeed()).Next(0, specialChars.Length)]);
            }

            for (int j = password.Length; j < length; j++)
            {
                string chars = "";

                if (useNumbers)
                {
                    chars += numbers;
                }

                if (useLowercase)
                {
                    chars += lowercaseLetters;
                }

                if (useUppercase)
                {
                    chars += uppercaseLetters;
                }

                if (useSpecialChars)
                {
                    chars += specialChars;
                }

                password.Append(chars[new Random(GetRandomSeed()).Next(0, chars.Length)]);
            }

            string shuffledPassword = ShuffleString(password.ToString());
            passwords.Add(shuffledPassword);
        }

        return passwords;
    }

    static string ShuffleString(string str)
    {
        char[] chars = str.ToCharArray();

        Random rng = new Random(GetRandomSeed());

        int n = chars.Length;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            char temp = chars[k];
            chars[k] = chars[n];
            chars[n] = temp;
        }

        return new string(chars);
    }

    static int GetRandomSeed()
    {
        byte[] bytes = new byte[4];
        using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
        {
            rng.GetBytes(bytes);
        }

        return BitConverter.ToInt32(bytes, 0);
    }
}