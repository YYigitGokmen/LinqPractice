
public class Program
{
    public static void Main(string[] args)
    {
        List<int> numbers = new List<int>() {5,0,9,-10,-3,120,31,18,2,7};

        var evenNumbers = numbers.Where(num => num % 2 == 0).ToList();
        //Çift olan sayılar
        foreach (int num in evenNumbers)
        {
            Console.WriteLine(num);

        }

        Console.WriteLine("###############################################");

        //Tek olan sayılar
        var oddNumbers = numbers.Where(num => num % 2 != 0);

        foreach (int num in oddNumbers)
        {
            Console.WriteLine(num);

        }

        Console.WriteLine("###############################################");

        //Negatif sayılar
        var negativeNumbers = numbers.Where(num => num < 0);

        foreach (int num in negativeNumbers)
        {
            Console.WriteLine(num);

        }

        Console.WriteLine("###############################################");

        //Pozitif Sayılar
        var positiveNumbers = numbers.Where(num => num > 0);

        foreach (int num in positiveNumbers)
        {
            Console.WriteLine(num);

        }

        Console.WriteLine("###############################################");

        //15'ten büyük ve 22'den küçük sayılar

        var numbersBetween = numbers.Where(num => num >15 && num < 22);

        foreach (int num in numbersBetween)
        {
            Console.WriteLine(num);
            
        }

        Console.WriteLine("###############################################");

        var squareOfNumbers = numbers.Select(num => num*num);

        foreach (int num in squareOfNumbers)
        {
            Console.WriteLine(num);

        }




    }
}
