// salam
using System.ComponentModel.Design;
bool davam = true;
while (davam)
{
    for (; ; )
    {
        Console.WriteLine("Zehmet olmasa, heftenin gunleri ucun 1den 7ye kimi reqem daxil edin:");
    string number = Console.ReadLine();
    int daynumber;
    bool result = int.TryParse(number, out daynumber);
    if (result == true)
    {
        switch (daynumber)
        {
            case 1:
                Console.WriteLine("Bazar ertesi");
                break;
            case 2:
                Console.WriteLine("Cersenbe axsami");
                break;
            case 3:
                Console.WriteLine("Cersenbe");
                break;
            case 4:
                Console.WriteLine("Cume axsami");
                break;
            case 5:
                Console.WriteLine("Cume");
                break;
            case 6:
                Console.WriteLine("Senbe");
                break;
            case 7:
                Console.WriteLine("Bazar");
                break;
            default:
                Console.WriteLine("Bele bir gun yoxdur.");
                break;
        }  
            break;
    }
     else 
    {
        Console.WriteLine("Zehmet olmasa, reqem daxil edin.");
    }     
    }
    Console.WriteLine("Davam etmek isteyirsiz? Cavab olaraq he ve yaxud yox yazin");
    string davamcavab = Console.ReadLine(); 
    if (davamcavab != "he")
    {
        davam = false; 
    }
    }
    Console.WriteLine("Tesekkur edirik! Helelik!");





