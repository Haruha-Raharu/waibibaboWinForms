using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace waibibaboWinForms
{
    internal class MyEncode
    {
        public static string EncodeText(string sourceText)
        {
            StringBuilder finalText = new StringBuilder();
            foreach (char sourceChar in sourceText)
            {
                finalText.Append(EncodeChar(sourceChar));
            }
            return finalText.ToString();
        }
        private static StringBuilder EncodeChar(char sourceChar)
        {
            StringBuilder encoded = new StringBuilder();
            int sourceInt = sourceChar;
            int ternaryInt = 0;
            int a = 0;
            do
            {
                ternaryInt += (sourceInt % 3) * (int)Math.Pow(10, a);
                sourceInt = sourceInt / 3;
                ++a;
            } while (sourceInt > 0);
            string ternaryString = ternaryInt.ToString();
            foreach (char item in ternaryString)
            {
                switch (item)
                {
                    case '0': encoded.Append('歪'); break;
                    case '1': encoded.Append('比'); break;
                    case '2': encoded.Append('吧'); break;
                }
            }
            return encoded.Append('卜');
        }
    }
}
