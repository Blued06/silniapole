Console.WriteLine("witaj uzytkowniku, co chcialbys zrobic");
Console.WriteLine("jesli chcesz zrobic silnie, wybierz - 1");
Console.WriteLine("jesli chcesz zrobic pole, wybierz - 2");
while (true)
{
    int wybor = ParseInt("podaj wybor: ");
    switch (wybor)
    {
        case 1:
            int n = ParseInt("podaj liczbe do silni: ");
            int silnia = 1;
            for (int i = 1; i <= n; i++)
            {
                silnia = silnia * i;
            }
            Console.WriteLine("silnia wynosi: " + silnia);
            break;
        case 2:
            Console.WriteLine("wybierz figure, ktorej chcesz obliczyc pole");
            Console.WriteLine("p - prostokat, t - trojkat, k - kwadrat, o - kolo");
            string figura = Console.ReadLine();
            int pole = 0;
            if (figura == "p")
            {
                int bokA = ParseInt("podaj a: ");
                int bokB = ParseInt("podaj b: ");
                pole = bokA * bokB;
            }
            else if (figura == "t")
            {
                int podstawa = ParseInt("podaj a: ");
                int wysokosc = ParseInt("podaj b: ");
                pole = (podstawa * wysokosc) / 2;
            }
            else if (figura == "k")
            {
                int bok = ParseInt("podaj a: ");
                pole = bok * bok;
            }
            else if (figura == "o")
            {
                int promien = ParseInt("podaj a: ");
                pole = 3 * promien * promien;
            }
            else
            {
                Console.WriteLine("nieznana figura");
            }
            Console.WriteLine("pole wynosi: " + pole);
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
        Console.WriteLine("zla liczba");
    }
