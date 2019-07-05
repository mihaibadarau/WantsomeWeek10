using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsProblem
{
    public class Solution
    {
        public static string ReverseLetters(string S)
        {
            if (S == "")
                throw new InvalidOperationException();
            StringBuilder sb_sRev = new StringBuilder();
            char[] sRev = S.ToCharArray();

            int stanga = 0;
            int dreapta = sRev.Length-1;

            while (stanga < dreapta)
            {
                if (!char.IsLetter(sRev[stanga]))
                    stanga++;

                else if (!char.IsLetter(sRev[dreapta]))
                    dreapta--;

                else
                {
                    char aux = sRev[stanga];
                    sRev[stanga] = sRev[dreapta];
                    sRev[dreapta] = aux;
                    stanga++;
                    dreapta--;
                }
            }
            sb_sRev.Append(sRev);
            return sb_sRev.ToString();
        }
    }
}
