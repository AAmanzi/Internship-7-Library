﻿using System.Text.RegularExpressions;

namespace Library.Infrastructure.Extensions
{
    public static class StringExtensions
    {
        public static string TrimAndRemoveWhiteSpaces(this string text)
        {
            text = text.Trim();
            var regex = new Regex(@"\s{2,}");
            while (regex.IsMatch(text))
                text = regex.Replace(text, " ", 1);
            return text;
        }

        public static string FirstLetterToUpper(this string text)
        {
            text = text.Trim();
            var newText = text.ToLower().ToCharArray();
            newText[0] = char.ToUpper(newText[0]);
            return new string(newText);
        }

        public static string AllFirstLettersToUpper(this string text)
        {
            var newText = text.ToLower().ToCharArray();
            for (var i = 0; i < newText.Length; i++)
            {
                if (i == 0)
                    newText[i] = char.ToUpper(newText[i]);
                if (newText[i] == ' ')
                    newText[i + 1] = char.ToUpper(newText[i + 1]);
            }
            return new string(newText);
        }
    } 
}
