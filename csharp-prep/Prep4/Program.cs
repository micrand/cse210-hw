using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        
        int displayScreen = 1;
        int totalCount = 0;
        double averageNumber = 0;        

        List<int> numbers = new List<int>();

        while(displayScreen!=0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished: ");
            int number = int.Parse(Console.ReadLine());

            numbers.Add(number);

            if(number == 0)
            {
                displayScreen = number;
            }

        }
        
        foreach(int nb in numbers)
        {            
            Console.WriteLine("number="+nb);
            totalCount += nb;
        }

        averageNumber = totalCount / numbers.Count();

        Console.WriteLine($"The sum is: {totalCount}");        
        // Console.WriteLine($"The average is: {Queryable.Average(numbers.AsQueryable())}");
        // Console.WriteLine($"The average is: {averageNumber}");
        // Console.WriteLine($"The average is: {numbers.Average()}");
        Console.WriteLine($"The average is: {calculateAverage(numbers)}");
        Console.WriteLine($"The large number: {numbers.Max()}");
    }

    private static double calculateAverage(List<int> list)
    {
        int sum=0;
        foreach( int num in list )
        {
            sum += num;
        }
        return (double)sum/list.Count;
    }

    public void writeListGenerics()
    {
        List<int> members;
        List<string> words;

        members = new List<int>();
        words = new List<string>();

        members.Add(10);
        members.Add(15);
        members.Add(21);

        words.Add("phone");
        words.Add("keyboard");
        words.Add("mouse");
        words.Add("monitor");

        foreach( int member in members)
        {
            Console.WriteLine("memberID=" + member);
        }

        Console.WriteLine($"There are {words.Count} words in the list");
        Console.WriteLine($"There are {members.Count} members in the list");
    }
}