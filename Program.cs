using AutoMotors;

Makina Audi = new Makina("Audi Q4","Audi Q4 E-Tronic", "Bardhe", 2023, 3.0, 75, 75, "Nafte", 0.047, 55000);
Makina Mercedes = new Makina("Mercedes-Benz", "W203", "I zi", 2006, 2.2, 66, 66, "Nafte", 0.134, 5000);
Makina BMW = new Makina("BMW Seria 5", "W203", "I zi", 2006, 2.2, 57, 57, "Nafte", 0.134, 56000);


Console.WriteLine("Mire se vini ne Auto Motors!");
Console.WriteLine(" Ju lutem zgjidhni opsionin e makines tuaj!");

Console.WriteLine($"1.{Audi.Marka} {Audi.Modeli}    2. {Mercedes.Marka} {Mercedes.Modeli}   3.{BMW.Marka} {BMW.Modeli}");
int opsioni = Convert.ToInt32(Console.ReadLine());
if (opsioni == 1)
{
    Audi.Specifikimi(Audi);

    while (true)
    {
        Audi.ShfaqOpsionet();
        int op = Convert.ToInt32(Console.ReadLine());

        if (op == 1)
        {
            Audi.Xhiro(Audi);
         
        }
        else if (op == 2)
        {
            Audi.Laje();
            continue;
        }
        else if (op == 3)
        {
            Audi.Parko();
            continue;
        }
        else if (op == 4)

        {
            Audi.Furnizo(Audi);
        }
        else if (op == 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Zgjedhje eshte e gabuar!");
            
        }
    }

}
else if (opsioni == 2)
{

    BMW.Specifikimi(BMW);

    while (true)
    {
        BMW.ShfaqOpsionet();
        int op = Convert.ToInt32(Console.ReadLine());
    }
        Console.WriteLine($"Ju zgjodhet {BMW.Marka} {BMW.Modeli}. Parametrat e makines jane keto:");
    Console.WriteLine($"Viti i Prodhimit: {BMW.Viti}");
    Console.WriteLine($"Lloji i Karburantit: {BMW.Karburant}");
    Console.WriteLine($"Motorri: {BMW.Fuqia}");

    while (true)
    {
        Console.WriteLine("1. Bej Xhiro     2. Laj Makinen      3. Parko        4. Furnizo          0. Dil");
        int op = Convert.ToInt32(Console.ReadLine());

        if (op == 1)
        {
            Random rnd = new Random();
            int km = rnd.Next(1, 200);

            BMW.Xhiro(BMW);

            // BMW harxhon 9.6l - 100 km => 0.096l - 1km
            // Cmimi aktual i benzines = 179 LEK / l

            double l = km * 0.096;
            double cmimi = 179 * l;

            Console.WriteLine($"Ke bere {km} kilometra dhe jane kosumuar {Math.Round(l, 2)} litra nafte!");
            Console.WriteLine($"Per kete udhetim jane shpenzuar {Math.Round(cmimi, 2)} LEK");

            continue;
        }
        else if (op == 2)
        {
            BMW.Laje();
            continue;
        }
        else if (op == 3)
        {
            BMW.Parko();
            continue;
        }
        else if (op == 4)
        {
            BMW.Furnizo(BMW);
            continue;
        }
        else if (op == 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Zgjedhje eshte e gabuar!");
            continue;
        }
    }
}
else if (opsioni == 3)
{
    Console.WriteLine($"Ju zgjodhet {Mercedes.Marka} {Mercedes.Modeli}. Parametrat e makines jane keto:");
    Console.WriteLine($"Viti i Prodhimit: {Mercedes.Viti}");
    Console.WriteLine($"Lloji i Karburantit: {Mercedes.Karburant}");
    Console.WriteLine($"Motorri: {Mercedes.Fuqia}");

    while (true)
    {
        Console.WriteLine("1. Bej Xhiro     2. Laj Makinen      3. Parko        4. Furnizo          0. Dil");
        int op = Convert.ToInt32(Console.ReadLine());

        if (op == 1)
        {
            Random rnd = new Random();
            int km = rnd.Next(1, 200);

            Mercedes.Xhiro(Mercedes);

            // Mercedes harxhon 13.4l - 100 km => 0.134l - 1km
            // Cmimi aktual i benzines = 179 LEK / l

            double l = km * 0.134;
            double cmimi = 179 * l;

            Console.WriteLine($"Ke bere {km} kilometra dhe jane kosumuar {Math.Round(l, 2)} litra nafte!");
            Console.WriteLine($"Per kete udhetim jane shpenzuar {Math.Round(cmimi, 2)} LEK");

            continue;
        }
        else if (op == 2)
        {
            Mercedes.Laje();
            continue;
        }
        else if (op == 3)
        {
            Mercedes.Parko();
            continue;
        }
        else if (op == 4)
        {
            Mercedes.Furnizo(Mercedes);
            continue;
        }
        else if (op == 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Zgjedhje eshte e gabuar!");
            continue;
        }
    }
}
else
{
    Console.WriteLine("Zgjedhja eshte e gabuar!");
}