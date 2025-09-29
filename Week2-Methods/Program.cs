using System.Windows.Markup;

CreateMenu();

void CreateMenu()
{
    try
    {
        //draw menu
        Console.WriteLine("--Main Menu--");
        Console.WriteLine($"1 - Say hello\n2 - Add numbers\n3 - Calculate area\n------------\nChoose an option");

        //accept users choice
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                SayHello();
            break;
            case "2":
                AddNumbers();
            break;
            case "3":
                CalculateArea();
            break;

            default:
                Console.WriteLine("Invalid choice");
            break;
        }

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}

static void SayHello()
{
    Console.WriteLine("Hello Word!");
}

static void AddNumbers()
{
    try
    {
        Console.WriteLine("Enter number of values to be added");
        int amount = Convert.ToInt16(Console.ReadLine());
        int value = 0;
        for (int i = 0; i < amount; i++)
        {
            Console.WriteLine($"enter value {i}");
            value += Convert.ToInt16(Console.ReadLine());
        }
        Console.WriteLine($"Answer is {value}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}

static void CalculateArea()
{
    try
    {
        //get user input
        Console.WriteLine("Enter length");
        double length = Convert.ToInt64(Console.ReadLine());

        Console.WriteLine("Enter width");
        double width = Convert.ToInt64(Console.ReadLine());

        //calculate area
        double area = length * width;
        Console.WriteLine($"Area is {area}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }

}