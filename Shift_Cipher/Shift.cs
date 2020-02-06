using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shift_Cipher
{
    class Shift
    {
        public static string manipulateMessage(string message,int shift,bool isEncrypt)
        {
            string finalMessage=null;
            Char[] tempMessage = message.ToCharArray();
            int tempValue;
            for (int i = 0; i < message.Length; i++)
            {
                if (tempMessage[i] != ' ')
                {
                    if (isEncrypt)
                    {
                        if (Char.IsUpper(tempMessage[i]))
                            tempValue = manageCapitalLetters(tempMessage[i], shift, isEncrypt);
                        else
                            tempValue = manageSmallLetters(tempMessage[i], shift, isEncrypt);
                    }
                    else
                    {
                        if (Char.IsUpper(tempMessage[i]))
                            tempValue = manageCapitalLetters(tempMessage[i], shift, isEncrypt);
                        else
                            tempValue = manageSmallLetters(tempMessage[i], shift, isEncrypt);
                    }
                }
                else
                    tempValue = tempMessage[i];
                finalMessage += (char)tempValue;
            }
            return finalMessage;
        }

        private static int manageCapitalLetters(char letter,int shift,bool isEncryption)
        {
            int charAsciVal = (int)letter;
            int i = 0;
            if (isEncryption)
            {
                while (i < shift)
                {
                    if (charAsciVal == 90)
                    {
                        charAsciVal = 65;
                    }
                    else
                    {
                        charAsciVal++;
                    }
                    ++i;
                }
            }
            else
            {
                while (i < shift)
                {
                    if (charAsciVal == 65)
                    {
                        charAsciVal = 90;
                    }
                    else
                    {
                            charAsciVal--;
                    }
                    ++i;
                }
            }
            return charAsciVal;
        }

        private static int manageSmallLetters(char letter, int shift,bool isEncryption)
        {
            int charAsciVal = (int)letter;
            int i = 0;
            if (isEncryption)
            {
                while (i < shift)
                {
                    if (charAsciVal == 122)
                    {
                        charAsciVal = 97;
                    }
                    else
                    {
                        charAsciVal++;
                    }
                    ++i;
                }
            }
            else
            {
                while (i < shift)
                {
                    if (charAsciVal == 97)
                    {
                        charAsciVal = 122;
                    }
                    else
                    {
                            charAsciVal--;
                    }
                    ++i;
                }
            }
            return charAsciVal;
        }
    }
}
//tempValue = (int) tempMessage[i] + shift;
//if (charAsciVal == 90)
//                    {
//                        charAsciVal = 65;
//                    }
//                    else
//                    {
//                        if (charAsciVal == 65)
//                            charAsciVal=90;
//                        else
//                            charAsciVal--;
//                    }
//                    ++i;