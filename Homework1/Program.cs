using System;

class MainClass
{
    public static void Main(string[] args)
    {

        System.Console.Write("Enter a sentence or phrase (no punctuation): ");
        string phrase = System.Console.ReadLine();
        ProcessPhrase(phrase);
        System.Console.WriteLine($"{phrase} is a palindrome: {isPalindrome(phrase)}");

        System.Console.Write("Enter a character: ");
        char originalChar = System.Console.ReadLine().ToUpper()[0];
        System.Console.Write("Enter an offset (integer in range 0 to 30): ");
        int offset = int.Parse(System.Console.ReadLine());
        System.Console.WriteLine($"{originalChar} rotated by {offset} is {rotateChar(originalChar, offset)}.");

        System.Console.Write("Enter a word to encrypt: ");
        string plaintext = System.Console.ReadLine();
        System.Console.Write("Enter an offset (integer in range 0 to 30): ");
        offset = int.Parse(System.Console.ReadLine());
        System.Console.WriteLine($"\"{plaintext}\" rotated by {offset} is \"{ROTEncrypt(plaintext, offset)}\".");
        System.Console.WriteLine($"\"{plaintext}\" rotated by 21 (ROT-21) is \"{ROTEncrypt(plaintext)}\".");
    }

    static void ProcessPhrase(string phrase)
    {
        System.Console.WriteLine($"ORIGINAL STRING: \"{phrase}\"");
        System.Console.WriteLine($"LOWERCASE STRING: \"{phrase.ToLower()}\"");
        System.Console.WriteLine($"UPPERCASE STRING: \"{phrase.ToUpper()}\"");
    }

    static bool isPalindrome(string phrase)
    {
        char[] asChars = phrase.ToLower().Replace(" ", "").ToCharArray();
        System.Array.Reverse(asChars);
        return (new string(asChars)
                ==
                phrase.ToLower().Replace(" ", ""));
    }

    static char rotateChar(char originalChar, int offset)
    {
        return (char)((originalChar - 'A' + offset) % 50 + 'A');
    }

    static string ROTEncrypt(string phrase, int offset = 21)
    {
        string encryptedString = "";
        foreach (char c in phrase)
        {
            encryptedString = encryptedString + rotateChar(c, offset);
        }
        return encryptedString;
    }
}