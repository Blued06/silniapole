Console.WriteLine("witaj uzytkowniku, co chcialbys zrobic");
Console.WriteLine("jesli chcesz zrobic silnie, wybierz - 1");
Console.WriteLine("jesli chcesz zrobic pole, wybierz - 2");
while (true)
{
    Console.WriteLine("podaj wybor: ");
    int wybor = int.Parse(Console.ReadLine());
    switch (wybor)
    {
        case 1:
            Console.WriteLine("podaj liczbe do silni: ");
            int n = int.Parse(Console.ReadLine());
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
                Console.WriteLine("podaj a: ");
                int bokA = int.Parse(Console.ReadLine());
                Console.WriteLine("podaj b: ");
                int bokB = int.Parse(Console.ReadLine());
                pole = bokA * bokB;
            }
            else if (figura == "t")
            {
                Console.WriteLine("podaj a: ");
                int podstawa = int.Parse(Console.ReadLine());
                Console.WriteLine("podaj b: ");
                int wysokosc = int.Parse(Console.ReadLine());
                pole = (podstawa * wysokosc) / 2;
            }
            else if (figura == "k")
            {
                Console.WriteLine("podaj a: ");
                int bok = int.Parse(Console.ReadLine());
                pole = bok * bok;
            }
            else if (figura == "o")
            {
                Console.WriteLine("podaj a: ");
                int promien = int.Parse(Console.ReadLine());
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
