using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class EmailExtractor
{
    public static void Main(string[] args)
    {
        string inputText = "Para más información, envíe un correo a SuperMario1l10@gmail.com o juan.perez@example.com.";
        List<string> extractedEmails = ExtractEmails(inputText);

        Console.WriteLine("Direcciones de correo electrónico encontradas:");
        foreach (string email in extractedEmails)
        {
            Console.WriteLine(email);
        }
    }

    public static List<string> ExtractEmails(string text)
    {
        List<string> emails = new List<string>();
        string emailPattern = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b";

        MatchCollection matches = Regex.Matches(text, emailPattern, RegexOptions.IgnoreCase);
        foreach (Match match in matches)
        {
            emails.Add(match.Value);
        }

        return emails;
    }
}
