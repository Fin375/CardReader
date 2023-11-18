using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace czytnik_kart_magnetycznych
{
    class ByteParser
    {
        static public string DumpBytesToString(byte[] bytes)
        {
            string result = "";

            foreach (byte b in bytes)
            {
                byte lowerNibble = (byte)(b & 0x0F);
                byte higherNibble = (byte)((b >> 4) & 0x0F);

                result += NibbleToString(higherNibble) + NibbleToString(lowerNibble) + " ";
            }

            return result;
        }

        static private string NibbleToString(byte b)
        {
            if (b < 0x0A)
                return ((char)(b + (byte)('0'))).ToString();
            return ((char)(b - 10 + (byte)('A'))).ToString();
        }
    }
}
