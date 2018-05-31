// --------------------------------------------------------------------------------------------------------------------
// <copyright file="KrunchProcessor.cs" company="NA">
//   NA
// </copyright>
// <summary>
//   The krunch processor.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable All
namespace Krunch.DomainLogic
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    /// <summary>
    ///     The krunch processor.
    /// </summary>
    public static class KrunchProcessor
    {
        /// <summary>
        ///     The max length.
        /// </summary>
        private static readonly int maxLength = 70;

        /// <summary>
        ///     The min length.
        /// </summary>
        private static readonly int minLength = 2;

        /// <summary>
        ///     The chars that can be used as input.
        /// </summary>
        private static readonly char[] validChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ .,?".ToCharArray();

        private static readonly char[] strippedChars = "AEOIU".ToCharArray();

        private static string fileOutputDir = "C:\\temp";

        /// <summary>
        ///     The krunch.
        /// </summary>
        /// <param name="inputString">
        ///     The string to be krunched.
        /// </param>
        /// <returns>
        ///     The <see cref="string" /> that is krunched.
        /// </returns>
        public static string Krunch(this string inputString)
        {
            if (inputString.Length < minLength)
            {
                throw new Exception($"Input string to short. Must be longer than {minLength}");
            }

            if (inputString.Length > maxLength)
            {
                throw new Exception($"Input string to Long. Must be shorter than {maxLength}");
            }

            var inputChars = inputString.ToCharArray();

            var outputChars = new List<char>();

            foreach (var inputChar in inputChars)
            {
                if (IsCharValid(inputChar) && IsNotYetMentioned(inputChar, outputChars.ToArray()) && MustNotBeStripped(inputChar))
                {
                    outputChars.Add(inputChar);
                }
            }

            return new string(outputChars.ToArray());
        }

        /// <summary>
        ///     The is char valid.
        /// </summary>
        /// <param name="character">
        ///     The character.
        /// </param>
        /// <returns>
        ///     The <see cref="bool" />.
        /// </returns>
        private static bool IsCharValid(char character)
        {
            return Array.IndexOf(validChars, character) > 0;
        }

        /// <summary>
        /// Make sure the char must not be stripped.
        /// </summary>
        /// <param name="character">
        /// The character.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        private static bool MustNotBeStripped(char character)
        {
            return Array.IndexOf(strippedChars, character) < 0;
        }

        /// <summary>
        ///     The is not yet mentioned.
        /// </summary>
        /// <param name="character">
        ///     The character.
        /// </param>
        /// <param name="outputChars">
        ///     The output chars.
        /// </param>
        /// <returns>
        ///     The <see cref="bool" />.
        /// </returns>
        private static bool IsNotYetMentioned(char character, char[] outputChars)
        {
            //// Skip the spaces
            if (character == ' ' && outputChars.Last() != ' ')
            {
                return true;
            }

            return Array.IndexOf(outputChars, character) < 0;
        }

        public static string Save(string result)
        {
            var filepath = Path.Combine(fileOutputDir, DateTime.Now.Ticks.ToString());
            if (File.Exists(filepath))
            {
                throw new Exception($"File already exist:{filepath}");
            }

            File.WriteAllText(filepath, result);
            return filepath;
        }
    }
}