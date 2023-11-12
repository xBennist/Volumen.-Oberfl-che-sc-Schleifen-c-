using System;

class Program
{
    static void Main()
    {

        //Benjamin Streitriegl
        Console.WriteLine("Welche Figur möchten Sie berechnen?");
        Console.WriteLine("(W)ürfel, (Q)ader, (Z)ylinder, (D)onut (K)ugel, K(E)gel?");
        char figur = Console.ReadKey().KeyChar;
        Console.WriteLine();
        double länge, breite, höhe, radius, volumen, oberfläche;

        Console.WriteLine("Möchten Sie das Volumen (V) oder die Oberfläche (O) berechnen?");
        char Auswahl = Console.ReadKey().KeyChar;
        Console.WriteLine();



        switch (figur)
        {



            case 'W':
                if (Auswahl == 'V' || Auswahl == 'v')
                {
                    do
                    {
                        Console.WriteLine("Geben Sie die Länge in cm ein ");
                        länge = Convert.ToDouble(Console.ReadLine());
                    } while (Console.ReadLine() == "ja");
                    if (länge < 0)
                    {
                        Console.WriteLine("länge muss größer als 0 sein");
                    }



                    volumen = länge * länge * länge;
                    Console.WriteLine("Das Volumen des Rechecks beträgt: " + volumen + "cm³");
                }

                else if (Auswahl == 'O' || Auswahl == 'o')
                {
                    do
                    {
                        Console.WriteLine("Geben Sie die Länge in cm ein ");
                        länge = Convert.ToDouble(Console.ReadLine());
                    } while (Console.ReadLine() == "ja");
                    if (länge < 0)
                    {
                        Console.WriteLine("länge muss größer als 0 sein");
                    }

                    oberfläche = 6 * länge;
                    Console.WriteLine("Die Oberfläche des Quaders beträgt: " + oberfläche + "cm");
                }
                break;


            case 'Q':
                if (Auswahl == 'V' || Auswahl == 'v')
                {
                    do
                    {
                        Console.WriteLine("Geben Sie die Länge in cm ein ");
                        länge = Convert.ToDouble(Console.ReadLine());
                    } while (Console.ReadLine() == "ja");
                    if (länge < 0)
                    {
                        Console.WriteLine("länge muss größer als 0 sein");
                    }
                    do
                    {
                        Console.WriteLine("Geben Sie die Breite in cm ein:");
                        breite = Convert.ToDouble(Console.ReadLine());
                    } while (Console.ReadLine() == "ja");
                    if (breite < 0)
                    {
                        Console.WriteLine("länge muss größer als 0 sein");
                    }
                    do
                    {
                        Console.WriteLine("Geben Sie die Höhe in cm ein ");
                        höhe = Convert.ToDouble(Console.ReadLine());

                    } while (Console.ReadLine() == "ja");
                    if (höhe < 0)
                    {
                        Console.WriteLine("länge muss größer als 0 sein");
                    }
                    volumen = länge * breite * höhe;
                    Console.WriteLine("Das Volumen des Quaders beträgt: " + volumen + "cm³");
                }
                else if (Auswahl == 'O' || Auswahl == 'o')
                {
                    do
                    {
                        Console.WriteLine("Geben Sie die Länge in cm ein ");
                        länge = Convert.ToDouble(Console.ReadLine());
                    } while (Console.ReadLine() == "ja");
                    if (länge < 0)
                    {
                        Console.WriteLine("länge muss größer als 0 sein");
                    }
                    do
                    {
                        Console.WriteLine("Geben Sie die Breite in cm ein:");
                        breite = Convert.ToDouble(Console.ReadLine());
                    } while (Console.ReadLine() == "ja");
                    if (breite < 0)
                    {
                        Console.WriteLine("länge muss größer als 0 sein");
                    }
                    do
                    {
                        Console.WriteLine("Geben Sie die Höhe in cm ein ");
                        höhe = Convert.ToDouble(Console.ReadLine());
                    } while (Console.ReadLine() == "ja");
                    if (höhe < 0)
                    {
                        Console.WriteLine("länge muss größer als 0 sein");
                    }
                    oberfläche = 2 * (länge * breite + länge * höhe + breite * höhe);
                    Console.WriteLine("Die Oberfläche des Quaders beträgt: " + oberfläche + "cm");
                }
                break;





            case 'E':

                if (Auswahl == 'V' || Auswahl == 'v')
                {
                    do
                    {
                        Console.WriteLine("Bitte gib den Radius des Kegels in cm ein:");
                        radius = Convert.ToDouble(Console.ReadLine());
                    } while (Console.ReadLine() == "ja");
                    if (radius < 0)
                    {
                        Console.WriteLine("länge muss größer als 0 sein");
                    }
                    do
                    {
                        Console.WriteLine("Bitte gib die Höhe des Kegels in cm ein:");
                        höhe = Convert.ToDouble(Console.ReadLine());
                    } while (Console.ReadLine() == "ja");
                    if (höhe < 0)
                    {
                        Console.WriteLine("länge muss größer als 0 sein");
                    }
                    volumen = (1.0 / 3.0) * Math.PI * Math.PI * radius * höhe;
                    Console.WriteLine("Das Volumen des Quaders beträgt: " + volumen + "cm³");
                }
                else if (Auswahl == 'O' || Auswahl == 'o')
                {
                    do
                    {
                        Console.WriteLine("Geben Sie den kegelradius in cm ein ");
                        radius = Convert.ToDouble(Console.ReadLine());
                    } while (Console.ReadLine() == "ja");
                    if (radius < 0)
                    {
                        Console.WriteLine("länge muss größer als 0 sein");
                    }
                    do
                    {
                        Console.WriteLine("Geben Sie die kegelhöhe in cm ein:");
                        höhe = Convert.ToDouble(Console.ReadLine());
                    } while (Console.ReadLine() == "ja");
                    if (höhe < 0)
                    {
                        Console.WriteLine("länge muss größer als 0 sein");
                    }
                    oberfläche = Math.PI * radius * (radius + Math.Sqrt(Math.Pow(höhe, 2) + Math.Pow(radius, 2)));
                    Console.WriteLine("Die Oberfläche des Quaders beträgt: " + oberfläche + "cm");
                }

                break;
            case 'D':

                if (Auswahl == 'V' || Auswahl == 'v')
                {
                    do
                    {
                        Console.WriteLine("Bitte gib den Radius des Kegels in cm ein:");
                        radius = Convert.ToDouble(Console.ReadLine());
                    } while (Console.ReadLine() == "ja");
                    if (radius < 0)
                    {
                        Console.WriteLine("länge muss größer als 0 sein");
                    }
                    do
                    {
                        Console.WriteLine("Bitte gib die Höhe des Kegels in cm ein:");
                        höhe = Convert.ToDouble(Console.ReadLine());
                    } while (Console.ReadLine() == "ja");
                    if (höhe < 0)
                    {
                        Console.WriteLine("länge muss größer als 0 sein");
                    }
                    volumen = (1.0 / 3.0) * Math.PI * Math.PI * radius * höhe;
                    Console.WriteLine("Das Volumen des Quaders beträgt: " + volumen + "cm³");
                }
                else if (Auswahl == 'O' || Auswahl == 'o')
                {
                    do
                    {
                        Console.WriteLine("Geben Sie den kegelradius in cm ein ");
                        radius = Convert.ToDouble(Console.ReadLine());
                    } while (Console.ReadLine() == "ja");
                    if (radius < 0)
                    {
                        Console.WriteLine("länge muss größer als 0 sein");
                    }
                    do
                    {
                        Console.WriteLine("Geben Sie die kegelhöhe in cm ein:");
                        höhe = Convert.ToDouble(Console.ReadLine());
                    } while (Console.ReadLine() == "ja");
                    if (höhe < 0)
                    {
                        Console.WriteLine("länge muss größer als 0 sein");
                    }
                    oberfläche = Math.PI * radius * (radius + Math.Sqrt(Math.Pow(höhe, 2) + Math.Pow(radius, 2)));
                    Console.WriteLine("Die Oberfläche des Quaders beträgt: " + oberfläche + "cm");
                }
                break;

            case 'K':

                if (Auswahl == 'V' || Auswahl == 'v')
                {
                    do
                    {
                        Console.WriteLine("Bitte gib den Radius des Kegels in cm ein:");
                        radius = Convert.ToDouble(Console.ReadLine());
                    } while (Console.ReadLine() == "ja");
                    if (radius < 0)
                    {
                        Console.WriteLine("länge muss größer als 0 sein");
                    }
                    do
                    {
                        Console.WriteLine("Bitte gib die Höhe des Kegels in cm ein:");
                        höhe = Convert.ToDouble(Console.ReadLine());
                    } while (Console.ReadLine() == "ja");
                    if (höhe < 0)
                    {
                        Console.WriteLine("länge muss größer als 0 sein");
                    }
                    volumen = (1.0 / 3.0) * Math.PI * Math.PI * radius * höhe;
                    Console.WriteLine("Das Volumen des Quaders beträgt: " + volumen + "cm³");
                }
                else if (Auswahl == 'O' || Auswahl == 'o')
                {
                    do
                    {
                        Console.WriteLine("Geben Sie den kegelradius in cm ein ");
                        radius = Convert.ToDouble(Console.ReadLine());
                    } while (Console.ReadLine() == "ja");
                    if (radius < 0)
                    {
                        Console.WriteLine("länge muss größer als 0 sein");
                    }
                    do
                    {
                        Console.WriteLine("Geben Sie die kegelhöhe in cm ein:");
                        höhe = Convert.ToDouble(Console.ReadLine());
                    } while (Console.ReadLine() == "ja");
                    if (höhe < 0)
                    {
                        Console.WriteLine("länge muss größer als 0 sein");
                    }
                    oberfläche = Math.PI * radius * (radius + Math.Sqrt(Math.Pow(höhe, 2) + Math.Pow(radius, 2)));
                    Console.WriteLine("Die Oberfläche des Quaders beträgt: " + oberfläche + "cm");
                }

                break;



            case 'Z':

                if (Auswahl == 'V' || Auswahl == 'v')
                {

                    do
                    {
                        Console.WriteLine("Bitte gib den Radius in cm ein:");
                        radius = Convert.ToDouble(Console.ReadLine());
                    } while (Console.ReadLine() == "ja");
                    if (radius < 0)
                    {
                        Console.WriteLine("länge muss größer als 0 sein");
                    }
                    do
                    {
                        Console.WriteLine("Bitte gib die Höhe in cm ein:");
                        höhe = Convert.ToDouble(Console.ReadLine());
                    } while (Console.ReadLine() == "ja");
                    if (höhe < 0)
                    {
                        Console.WriteLine("länge muss größer als 0 sein");
                    }
                    volumen = (1.0 / 3.0) * Math.PI * radius * radius * höhe;
                    Console.WriteLine("Das Volumen des Quaders beträgt: " + volumen + "cm³");
                }
                else if (Auswahl == 'O' || Auswahl == 'o')
                {
                    do
                    {
                        Console.WriteLine("Geben Sie den kegelradius in cm ein ");
                        radius = Convert.ToDouble(Console.ReadLine());
                    } while (Console.ReadLine() == "ja");
                    if (radius < 0)
                    {
                        Console.WriteLine("länge muss größer als 0 sein");
                    }

                    do
                    {
                        Console.WriteLine("Geben Sie die kegelhöhe in cm ein:");
                        höhe = Convert.ToDouble(Console.ReadLine());
                    } while (Console.ReadLine() == "ja");
                    if (höhe < 0)
                    {
                        Console.WriteLine("länge muss größer als 0 sein");
                    }
                    oberfläche = Math.PI * radius * (radius + Math.Sqrt(Math.Pow(höhe, 2) + Math.Pow(radius, 2)));
                    Console.WriteLine("Die Oberfläche des Quaders beträgt: " + oberfläche + "cm");
                }
                break;

            default:
                Console.WriteLine("Ungültige Eingabe! Bitte wählen Sie eine der angegebenen Figuren aus.");
                break;
            }


        }

        } 
