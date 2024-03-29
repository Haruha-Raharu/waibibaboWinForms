﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace waibibaboWinForms
{
    internal class MyDecode
    {
        public static string DecodeText(string encodedText)
        {
            StringBuilder finalText = new StringBuilder();
            string[] chars = encodedText.Split('卜');
            foreach (string item in chars)
            {
                int finalChar = 0;
                for (int i = 0; i < item.Length; i++)
                {
                    switch (item[i])
                    {
                        case '歪': break;
                        case '比': finalChar += (int)Math.Pow(3, item.Length - i - 1); break;
                        case '吧': finalChar += 2 * (int)Math.Pow(3, item.Length - i - 1); break;
                    }
                }
                finalText.Append((char)finalChar);
            }
            return finalText.ToString();
        }
    }
}
