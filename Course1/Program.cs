namespace Course1;

class Program
{
    static void Main(string[] args)
    {

        string[] cars = { "Toyota", "BMW", "Nissan" };


        for (int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine(cars[i]);
        }
        
        
        Console.ReadKey();
    }
 }