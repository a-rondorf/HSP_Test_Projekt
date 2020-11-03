﻿using System;

namespace Test_Projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Double m;       //m = Modul
            Double p;       //p = Teilung
            Double d;       //d = Teilkreisdurchmesser
            Double da;      //da = Kopfkreisdurchmesser
            Double df;      //df = Fußkreisdurchmesser
            Double z;       //z = Zähnezahl
            Double h;       //h = Zahnhöhe   
            Double ha;      //ha = Zahnkopfhöhe
            Double hf;      //hf = Zahnfußhöhe
            Double c;       //c = Kopfspiel
            Double a;       //a = Achsenabstand
            Double alpha;   //Nachnorm 20°
            Double dg;      //dg = Grundkreisdurchmesser
            Double Br;      //Br = Breite des Zahnrades


            string eingabe; //Eingabe als string deklarieren
            int eingabeInt = 0;     //späterer Speicherort für die Eingabe als Int

            do
            {
                Console.WriteLine("\n\t\t\tZahnradkonfigurator von Gruppe H");
                Console.WriteLine("\n\t\tWollen sie das Modul und den Teilkreisdurchmesser vorgeben? press: 1");
                Console.WriteLine("\n\t\tWollen sie das Modul und die Zähnezahl vorgeben? press: 2");
                Console.WriteLine("\n\t\tWollen sie die Zähnezahl und den Teilkreisdurchmesser vorgeben? press: 3");
                Console.WriteLine("\n\t\t\tBestätigen sie ihre Eingabe mit Enter");

                eingabe = Console.ReadLine();    // Eingabe und convert
                Int32.TryParse(eingabe, out eingabeInt);

                if (eingabeInt >= 4 || eingabeInt <= 0) //Fehlermeldung
                {
                    Console.Clear();
                    Console.WriteLine("\n\t\t\t\tFehler! Falsche Eingabe!\n\t\t\t\tEingabe Wiederholen!\n");
                }
            }
            while (eingabeInt >= 4 || eingabeInt <= 0); //Wenn Eingabe Falsch: Neustart

            if (eingabeInt == 1)
            {
                modul();
                teilkreisdurchmesser();
                z = d / m;

                Winkel();
                Kopfspiel();
                berechnung();
                ausgabe();
            }
            else if (eingabeInt == 2)
            {
                modul();
                zaehnezahl();
                d = m * z;

                Winkel();
                Kopfspiel();
                berechnung();
                ausgabe();
            }
            else if (eingabeInt == 3)
            {
                teilkreisdurchmesser();
                zaehnezahl();
                m = d / z;

                Winkel();
                Kopfspiel();
                berechnung();
                ausgabe();
            }
            //Eingabe der Breite des Zahnrades
            Console.Write("\t\t\tGeben Sie die Breite des Zahnrades an:");
            Br = Convert.ToDouble(Console.ReadLine());

            //Eingabe Material
            Console.Write("\t\t\tBitte geben Sie das Material ein:");
            string Material = Console.ReadLine();

            //Unterprogramme
            void ausgabe()
            {
                Console.WriteLine("\t\t\tZähnezahl: " + z);
                Console.WriteLine("\t\t\tTeilkreisdurchmesser: " + d);
                Console.WriteLine("\t\t\tModul: " + m);
                Console.WriteLine("\t\t\tTeilung: " + p);
                Console.WriteLine("\t\t\tFußkreisdurchmesser: " + df);
                Console.WriteLine("\t\t\tZahnhöhe: " + h);
                Console.WriteLine("\t\t\tGrundkreisdurchmesser: " + dg);
            }

            void berechnung()
            {
                //Zahnhöhe
                h = 2 * m + c;
                //Teilung
                p = Math.PI * m;
                //Fußkreisdurchmesser
                df = d - (2 * (m + c));
                //Grundkreisdurchmesser
                alpha = Math.PI / 180 * alpha; // Winkel in Radiant umrechnen
                dg = d * Math.Cos(alpha);
            }
            Console.ReadKey();


            void Kopfspiel()
            {

                string gg; //Eingabe als string deklarieren
                int ggInt = 0;     //späterer Speicherort für die Eingabe als Int

                do
                {
                    Console.WriteLine("\n\t\tWollen Sie das Kopfspiel selbstbesimmen? press: 1");
                    Console.WriteLine("\n\t\tOder wollen sie, dass für das Kopfspiel der Normwert = 0,167mm angenommen wird? press: 2");

                    Console.WriteLine("\n\t\t\tBestätigen sie ihre Eingabe mit Enter");

                    gg = Console.ReadLine();    // Eingabe und convert
                    Int32.TryParse(gg, out ggInt);

                    if (ggInt >= 3 || ggInt <= 0) //Fehlermeldung
                    {
                        Console.WriteLine("\n\t\t\t\tFehler! Falsche Eingabe!\n\t\t\t\tEingabe Wiederholen!\n");
                    }
                }
                while (ggInt >= 3 || ggInt <= 0); //Wenn Eingabe Falsch: Neustart

                if (ggInt == 1)
                {
                    do
                    {
                        Console.WriteLine("\n\t\t\tBitte geben sie das Kopfspiel in mm ein. Empfohlen ist 0,1 bis 0,3mm");
                        Double.TryParse(Console.ReadLine(), out c);
                        if (c <= 0)
                        {
                            Console.WriteLine("Eingabe Wiederholen!");
                        }

                    } while (c <= 0);
                }
                else
                {
                    c = 0.167;
                }


            }

            void Winkel()
            {
                string ww; //Eingabe als string deklarieren
                int wwInt = 0;     //späterer Speicherort für die Eingabe als Int

                do
                {
                    Console.WriteLine("\n\t\tWollen Sie den Zahnflankenwinkel selbst bestimmen? press: 1");
                    Console.WriteLine("\n\t\tOder wollen sie, dass für den Zahnflankenwinkel 20° angenommen wird? press: 2");

                    Console.WriteLine("\n\t\t\tBestätigen sie ihre Eingabe mit Enter");

                    ww = Console.ReadLine();     // Eingabe und convert
                    Int32.TryParse(ww, out wwInt);

                    if (wwInt >= 3 || wwInt <= 0) //Fehlermeldung
                    {
                        Console.WriteLine("\n\t\t\t\tFehler! Falsche Eingabe!\n\t\t\t\tEingabe Wiederholen!\n");
                    }
                }
                while (wwInt >= 3 || wwInt <= 0); //Wenn Eingabe Falsch: Neustart

                if (wwInt == 1)
                {
                    do
                    {
                        Console.WriteLine("\n\t\t\tBitte geben sie den Zahnflanken Winkel in Grad an. Norm ist 20°");
                        Double.TryParse(Console.ReadLine(), out alpha);
                        if (alpha <= 0)
                        {
                            Console.WriteLine("Eingabe Wiederholen!");
                        }

                    } while (alpha <= 0);
                }
                else
                {
                    alpha = 20;
                }


            }

            //Unterprogramm zur Kontrolle der Moduleingabe
            void modul()
            {
                do
                {
                    Console.WriteLine("\n\t\t\tBitte geben sie das Modul ein.");
                    Double.TryParse(Console.ReadLine(), out m);
                    if (m <= 0)
                    {
                        Console.WriteLine("Eingabe Wiederholen!");
                    }

                } while (m <= 0);
            }

            //Unterprogramm zur Kontrolle der Zähnezahleingabe
            void zaehnezahl()
            {
                do
                {
                    Console.WriteLine("\n\t\t\tBitte geben sie die Zähnezahl an:");
                    Double.TryParse(Console.ReadLine(), out z);
                    if (z <= 0)
                    {
                        Console.WriteLine("Eingabe Wiederholen!");
                    }

                } while (z <= 0);
            }

            //Unterprogramm zur Kontrolle der Teilkreisdurchmessereingabe
            void teilkreisdurchmesser()
            {
                do
                {
                    Console.WriteLine("\n\t\t\tBitte geben sie den Teilkreisdurchmesser in mm ein.");
                    Double.TryParse(Console.ReadLine(), out d);
                    if (d <= 0)
                    {
                        Console.WriteLine("Eingabe Wiederholen!");
                    }

                } while (d <= 0);
            }

        }
    }
}
