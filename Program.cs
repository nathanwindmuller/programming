using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        void Start()
        {
            WoordenLijst();
            GalgjeSpel galgje = new GalgjeSpel();
            galgje.Init(SelectWoord(WoordenLijst()));
            ToonWoord(SelectWoord(WoordenLijst()));
            Console.WriteLine("Het geraden woord is: " + galgje.geradenWoord);
            SpeelGalgje(galgje);
            Console.ReadKey();
        }
        List<string> WoordenLijst()
        {
            List<string> Woordenlijst = new List<string>
            {
            "programmeren", "huis", "flat", "hardcoded", "galgje", "licht", "rgb", "keyboard", "hangman", "microsoft",
            "oneplus", "smartphone", "laptop", "school", "reizen", "visualstudio", "student", "werken", "computer", "software"
            };
            return Woordenlijst;
        }
        string SelectWoord(List <string> woorden)
        {
            Random rnd = new Random();
            int input = rnd.Next(20);
            string output = woorden[input];
            return output;
        }
        bool SpeelGalgje(GalgjeSpel galgje)
        {
                List<char> ingevoerdeLetters = new List<char>();
                ingevoerdeLetters.Add(LeesLetter(ingevoerdeLetters));
                galgje.RaadLetter(LeesLetter(ingevoerdeLetters));
                return true;
        }
        void ToonWoord(string woord)
        {
            string toonWoord = "";
            foreach (char c in woord)
            {
                toonWoord += c +" ";
            }
            Console.WriteLine(toonWoord);
        }
        void ToonLetters(List<char> letters)
        {
            string toonletters = "";
            foreach (char c in letters)
            {
                toonletters += c + " ";
            }
            Console.WriteLine(toonletters);
        }
        char LeesLetter(List<char> verbodenLetters)
        {
            char letter;
            do
            {
                Console.Write("Geef een letter: ");
                letter = Convert.ToChar(Console.ReadLine());
            }
            while (verbodenLetters.Contains(letter));
            return letter;
        }
    }
}