using System;

namespace Jetespil
{


    class Program
    {

        

        static void Main(string[] args)
        {

            bool vant = false;
            bool On = true;
           
            int GangerProvd = 0;

            string StartText = ("Gjett et tall mellom 1 og 100 ");
            string FeillText = ("gjett igjen");

            while (On == true)
            {
                Random Tall = new Random(); int Svar = Tall.Next(1, 100);

              //  Console.WriteLine(Svar);

                while (vant == false)
            {

                if (GangerProvd == 0 && vant == false)
                { Console.WriteLine(StartText); };

                string textsvar = Console.ReadLine();
                int svar = int.Parse(textsvar);

                GangerProvd += 1;
        
                if (svar == Svar)
                {
                    vant = true;
                }
                if (svar <= Svar && vant == false)
                {
                    Console.WriteLine("for lite");
                }
                if (svar >= Svar && vant == false)
                {
                    Console.WriteLine("for mye");
                }

                if (GangerProvd >= 1 && vant == false)
                { Console.WriteLine(FeillText); };
            }





                if (vant == true)
                {

                    Console.WriteLine("Du vant");
                    Console.WriteLine("Du prøvde " + GangerProvd + " ganger");
                    Console.WriteLine("Skriv Play for og spille igjen. Skriv End for å slå av");

                    string VillDu = Console.ReadLine();

                    if (VillDu == "Play")
                    {
                        vant = false;

                        GangerProvd = 0;

                        VillDu = "";

                    }
                    if (VillDu == "End")
                    {
                        On = false;
                    }
                }
            }



        }
    }
}
