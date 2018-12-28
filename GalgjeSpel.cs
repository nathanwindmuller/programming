using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2
{
    class GalgjeSpel
    {
        public string geheimWoord;
        public string geradenWoord;
        public void Init(string geheimWoordInvoer)
        {
            geheimWoord = geheimWoordInvoer;
            foreach (char c in geheimWoord)
            {
                geradenWoord += ". ";
            }
        }
        public bool RaadLetter(char letter)
        {
            foreach (char c in geheimWoord)
            {
                if (geheimWoord.Contains(letter))
                {
                    geradenWoord += letter;
                    Console.Write(geradenWoord);
                    return true;
                }
            }
            return false;
        }
        public bool IsGeraden()
        {
            return true;
        }
    }
}
