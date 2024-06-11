using System;

namespace Simple_validation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string testUsername = "Abcd";

            Console.WriteLine(UserValidation(testUsername));
        }

        /* static bool UserValidation(string username)
         {
             int badLetter = 0;
             bool isValid = false;
             char[]usernameArray = username.ToCharArray();
             char[] validLetter = {'a', 'b', 'c', 'd', 'e',
                                     'f', 'g', 'h', 'i', 'j',
                                     'k', 'l', 'm', 'n', 'o',
                                     'p', 'q', 'r', 's', 't', 
                                     'u', 'v', 'w', 'x', 'y',
                                     'z', '1', '2', '3', '4',
                                     '5', '6', '7', '8', '9',
                                     '0', '_'};
             if (username.Length >= 4 && username.Length <= 16)
             {
                 for (int i = 0; i < usernameArray.Length; i++)
                 {
                     for (int j = 0; j < validLetter.Length; j++)
                     {
                         if (usernameArray[i] == validLetter[j])
                         {
                             continue;
                         }
                         else
                         {
                             badLetter += 1;
                         }
                     }
                 }
                 if (badLetter == 0)
                 {
                     isValid = true;
                 }
                 else
                 {
                     isValid = false;
                 }
             }

             return isValid;
         }*/

        static bool UserValidation(string username)
        {
            int goodLetterCount = 0;
            bool isValid = false;
            char[] validLetter = {'a', 'b', 'c', 'd', 'e',
                                    'f', 'g', 'h', 'i', 'j',
                                    'k', 'l', 'm', 'n', 'o',
                                    'p', 'q', 'r', 's', 't',
                                    'u', 'v', 'w', 'x', 'y',
                                    'z', '1', '2', '3', '4',
                                    '5', '6', '7', '8', '9',
                                    '0', '_'};

            char[] usernameArr = username.ToCharArray();

            if (username.Length < 4 || username.Length > 16)
            {
                return isValid;
            }
            else
            {
                for (int i = 0; i < usernameArr.Length; i++)
                {
                    for (int j = 0; j < validLetter.Length; j++)
                    {
                        if (usernameArr[i] == validLetter[j])
                        {
                            goodLetterCount++;
                        }
                    }
                }

                if (goodLetterCount == username.Length)
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                }

                return isValid;
            }
        }
    }
}