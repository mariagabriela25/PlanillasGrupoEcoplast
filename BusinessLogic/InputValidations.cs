
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLogic
{
    /// <summary>
    /// Class InputValidations. Validates all the inputs from the user.
    /// </summary>
    public class InputValidations
    {

        /// <summary>
        /// validates an input text based on regular expressions
        /// </summary>
        /// <param name="input">The input text from the user</param>
        /// <returns>true if the validation is correct, false if not</returns>
        public Boolean wordsValidation(String input)
        {
            string patternWord = "[A-Za-z]";
            try
            {

                return Regex.IsMatch(input, patternWord, RegexOptions.IgnoreCase);
                    }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// validates the numbers ingressed by the user
        /// </summary>
        /// <param name="input">The input from the user</param>
        /// <returns>true if the validation is correct, false if not</returns>
        public Boolean numbersValidation(String input)
        {
            string patternWord = "[0-9]";
            try
            {

                return Regex.IsMatch(input, patternWord, RegexOptions.IgnoreCase);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
