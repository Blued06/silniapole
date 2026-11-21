 
Console.WriteLine("jesli chcesz zrobic silnie, wybierz - 1");
Console.WriteLine("jesli chcesz zrobic pole, wybierz - 2");
Console.WriteLine("jesli chcesz wyjsc, wybierz - 0");
int a = 0;
while (a != 2)
{
    int wybor = ParseInt("Podaj wybor: ");
    switch (wybor)
    {
        case 1:
            int n = ParseInt("Podaj liczbe do silni: ");
            int silnia = 1;
            for (int i = 1; i <= n; i++)
            {
                silnia = silnia * i;
            }
            Console.WriteLine("Silnia wynosi: " + silnia);
            break;
        case 2:
            Console.WriteLine("Wybierz figure, ktorej chcesz obliczyc pole");
            Console.WriteLine("p - prostokat, t - trojkat, k - kwadrat, o - kolo");
            string figura = Console.ReadLine();
            int pole = 0;
            if (figura == "p")
            {
                int bokA = ParseInt("Podaj a: ");
                int bokB = ParseInt("Podaj b: ");
                pole = bokA * bokB;
            }
            else if (figura == "t")
            {
                int podstawa = ParseInt("Podaj a: ");
                int wysokosc = ParseInt("Podaj b: ");
                pole = (podstawa * wysokosc) / 2;
            }
            else if (figura == "k")
            {
                int bok = ParseInt("Podaj a: ");
                pole = bok * bok;
            }
            else if (figura == "o")
            {
                int promien = ParseInt("Podaj a: ");
                pole = 3 * promien * promien;
            }
            else
            {
                Console.WriteLine("Nieznana figura");
            }
            Console.WriteLine("Pole wynosi: " + pole);
            break;
        case 0:
            a = 2;
            break;
    }
}
int ParseInt(string tekst)
{
    while (true)
    {
        Console.WriteLine(tekst);
        if (int.TryParse(Console.ReadLine(), out int liczba))
        {
            return liczba;
        }
        Console.WriteLine("Zla liczba");
    }
}