using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shift_Cipher
{
    class Vigenere
    {
        private static char[,] alphabeticMat = new char[26, 26];
        private static char[] alphabeticArr = new char[26];
        public static void initializeAlphabeticMatrix()
        {
            int initalChar = 65;
            for (int i = 0; i < 26; i++)
            {
                int tempChar = initalChar;
                for (int j = 0; j < 26; j++)
                {
                    if (tempChar <= 90)
                        alphabeticMat[i, j] = (char)tempChar++;
                    else
                    {
                        tempChar = 65;
                        alphabeticMat[i, j] = (char)tempChar++;
                    }
                }
                ++initalChar;
            }
        }

        public static void initializeAlphabeticArray()
        {
            int letter = 65;
            for (int i = 0; i < alphabeticArr.Length; i++)
            {
                alphabeticArr[i] = (char)letter++;
            }
        }

        public static string manipulateMessage(string message,string key,bool isEncrypt)
        {
            char[] msgArray = message.ToCharArray();
            char[] keyArray = key.ToCharArray();
            string keyString="";
            int keyIter=0;
            if (key != "")
            {
                for (int i = 0; i < msgArray.Length; i++)
                {
                    if (keyArray.Length == keyIter)
                        keyIter = 0;
                    if (msgArray[i] != ' ')
                        keyString += keyArray[keyIter++];
                    else
                        keyString += ' ';
                }
                char[] keyStringArr = keyString.ToCharArray();
                if (isEncrypt)
                    return constructMsg(keyStringArr, msgArray);
                else
                    return deConstructMsg(keyStringArr, msgArray);
            }
            else
                return "Please Insert the key";
        }

        private static string constructMsg(char[] keyStringArr, char[] msgArray)
        {
            string finalString = "";
            int row, col;
            row = col = 0;
            for (int i = 0; i < msgArray.Length; i++)
            {
                if (msgArray[i] != ' ')
                {
                    col = Array.IndexOf(alphabeticArr, char.ToUpper(msgArray[i]));
                    row = Array.IndexOf(alphabeticArr, char.ToUpper(keyStringArr[i]));
                    if (char.IsUpper(msgArray[i]))
                        finalString += alphabeticMat[row, col];
                    else if (msgArray[i] == ' ')
                        finalString += msgArray[i];
                    else
                        finalString += char.ToLower(alphabeticMat[row, col]);
                }
                else
                    finalString += ' ';
            }
            return finalString;
        }

        private static string deConstructMsg(char[] keyStringArr, char[] msgArray)
        {
            string finalString = "";
            int row;
            for (int i = 0; i < keyStringArr.Length; i++)
            {
                row = Array.IndexOf(alphabeticArr, char.ToUpper(keyStringArr[i]));
                for (int j = 0; j < alphabeticArr.Length; j++)
                {
                    if (msgArray[i] != ' ')
                    {
                        if (char.IsUpper(msgArray[i]))
                        {
                            if (alphabeticMat[row, j] == msgArray[i])
                            {
                                finalString += alphabeticArr[j];
                                break;
                            }
                        }
                        else
                        {
                            if (alphabeticMat[row, j] == char.ToUpper(msgArray[i]))
                            {
                                finalString += char.ToLower(alphabeticArr[j]);
                                break;
                            }
                        }
                    }
                    else
                    {
                        finalString += ' ';
                        break;
                    }
                }
            }
            return finalString;
        }
    }
}
