// Write a C# program that takes the radius of a circle as input and calculate the perimeter and area of the circle and print it in console


internal class Program
{
    private static void Main(string[] args)
    {
        const float pi = 3.14f;
        Console.WriteLine("Please enter radius: ");
        var radius = int.Parse(Console.ReadLine());



        //Perimetr 2*pi*r

        float perimetr = 2 * radius * pi;
        // Area pi*r*r

        var area = pi * radius * radius;
        Console.WriteLine($"Perimetr: {perimetr} Area: {area}");

        Console.ReadLine();
    }
}