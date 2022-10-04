using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            word = word.ToLower();
            var reverseWord = string.Join("", word.ToLower().Reverse());
            
            if (word == reverseWord)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
    }
}
