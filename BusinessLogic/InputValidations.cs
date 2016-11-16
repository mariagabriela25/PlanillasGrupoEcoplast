using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class InputValidations
    {

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
