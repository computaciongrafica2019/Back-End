using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace APPCG.Helpers
{
    public static class ExcelHelper
    {

        public static int GetStringLetter(string letter)
        {

            int index = 0;
            string[] alphabet = new string[25] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "T", "U", "V", "W", "X", "Y", "Z" };

            for (int i = 0; i < 26; i++)
            {
                if (alphabet[i] == letter)
                {
                    index = i+1;
                    break;
                }

            }
            return index;
        }


    }



}