internal class Program
{
    private static void Main(string[] args)
    {
        const string MyName = "Henri";
        const int MyAge = 23;
        const bool MyRelationshipStatus = true;
        const int x = 10;

        if (x > 18)
        {
            Console.WriteLine("Hello world! The current time is " + DateTime.Now + " my name is " + MyName + " I am " + MyAge + " if you asked me if i was in a relationship i would say " + MyRelationshipStatus);
        }
        else if (x > 10)
        {
            Console.WriteLine("Im sorry i must be lost");
        }
        else
        {
            Console.WriteLine("where am i");
        }

        switch (MyAge)
        {
            case 1:
                Console.WriteLine("happy Birthday");
                break;
            case 23:
                Console.WriteLine("Where is the cake");
                break;
            default:
                Console.WriteLine("I kind of miss foo bar");
                break;
        }



        string[] names = { "Henri", "Barney", "Sterling", "Don" };

        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }

        foreach (string i in names)
        {
            Console.WriteLine(i);
        }

        List<int> numbers = new List<int>();
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);
        numbers.Add(4);
        numbers.Add(5);
        numbers.Add(6);
        numbers.Add(7);
        numbers.Add(8);

        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }

        int sum = numbers.Sum();
        Console.WriteLine(sum);
    }
}


internal class Kata
{
    private static bool Main(string[]  args)
    {
        const string MyName = "Henri";
        const int MyAge = 23;
        const bool MyRelationshipStatus = true;
        const int x = 10;

        if (x > 18)
        {
            Console.WriteLine("Hello world! The current time is " + DateTime.Now + " my name is " + MyName + " I am " + MyAge + " if you asked me if i was in a relationship i would say " + MyRelationshipStatus);
        }
        else if (x > 10)
        {
            Console.WriteLine("Im sorry i must be lost");
        }
        else
        {
            Console.WriteLine("where am i");
        }

        switch (MyAge)
        {
            case 1:
                Console.WriteLine("happy Birthday");
                break;
            case 23:
                Console.WriteLine("Where is the cake");
                break;
            default:
                Console.WriteLine("I kind of miss foo bar");
                break;
        }



        string[] names = { "Henri", "Barney", "Sterling", "Don" };

        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }

        foreach (string i in names)
        {
            Console.WriteLine(i);
        }

        List<int> numbers = new List<int>();
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);
        numbers.Add(4);
        numbers.Add(5);
        numbers.Add(6);
        numbers.Add(7);
        numbers.Add(8);

        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }

        int sum = numbers.Sum();
        Console.WriteLine(sum);


        foreach( int i in numbers){
      if (i.Equals(x))
        {
        return false;
      }
      else
        {
        return true;
      }
    }
    
    }
}

