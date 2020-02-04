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
                if(isEncrypt)
                    tempValue = (int)tempMessage[i] + shift;
                else
                    tempValue = (int)tempMessage[i] - shift;
                finalMessage += (char)tempValue;
            }
            return finalMessage;
        }
    }
}
