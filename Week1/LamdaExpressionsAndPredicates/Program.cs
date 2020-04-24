using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LamdaExpressionsAndPredicates
{
    
    delegate int Del(int x);
    public delegate void StringDelegate(String message, out String outMessage);

    class Program
    {
        
        static void Main(string[] args)
        {



            Console.WriteLine("Hello World!");

            List<Person> persons = new List<Person>();
            persons.Add(new Person("jim", 25));
            persons.Add(new Person("jam", 35));
            persons.Add(new Person("jem", 15));
            persons.Add(new Person("bim", 26));
            persons.Add(new Person("bam", 5));
            persons.Add(new Person("bom", 125));


            Console.WriteLine();
            Action<int, string, bool> IntStringBool = (x, y, z) => Console.WriteLine($"It's {z} that these {x} Associates are {y}!!");

            IntStringBool(24, "making me crazy", true);



            Console.WriteLine();
            //Ash
            Func<string, string, string> combineFirstAndLast = (a, b) => a + b;
            string fulllName = combineFirstAndLast("Ash ", "Bracken");
            Console.WriteLine(fulllName);

            Func<string, string, string> combineFirstAndLast1 = (a, b) => a + b;
            string fulllName1 = combineFirstAndLast1("Ash", "Bracken");
            Func<string, string> addProfession = (c) => c;
            string job = addProfession("Student");
            string nameAndProf = fulllName1 += job;
            Console.WriteLine(nameAndProf);


            Console.WriteLine();
            //Darius
            int divisor = 4;
            List<int> list = new List<int>() { 1, 9872, 5, 8, 3, 234, 242345, 52 };
            List<int> divisible = list.FindAll(x => (x % divisor) == 0);
            Console.Write($"Numbers divisible by {divisor} are :");
            foreach (var v in divisible)
            {
                Console.Write("{0} ", v);
            }


            Console.WriteLine();
            //David Aguilar
            Action<string> greet = name =>
            {
                string greeting = $"This is {name}!";
                Console.WriteLine(greeting);
            };
            greet("a Practice round");

            //delegate int Del(int x);

            Del del = x => x * x;
            int result = del(4);
            Console.WriteLine(result);


            Console.WriteLine();
            //David Sawyer

            Func<int, int, int> addNums = (num1, num2) => num1 + num2;
            Func<int, int, int> subNums = (num1, num2) => num1 - num2;
            Func<int, int, int> mulNums = (num1, num2) => num1 * num2;
            Func<int, int, int> divNums = (num1, num2) => num1 / num2;
            Console.WriteLine($"6+2={addNums(6, 2)}");
            Console.WriteLine($"6-2={subNums(6, 2)}");
            Console.WriteLine($"6*2={mulNums(6, 2)}");
            Console.WriteLine($"6/2={divNums(6, 2)}");


            Console.WriteLine();
            //Kuang

            Func<String, String, bool> isSame = (x, y) => x == y;
            Console.WriteLine("Comparing Rock and Paper: " + isSame("Rock", "Paper"));
            Console.WriteLine("Comparing Rock and Rock: " + isSame("Rock", "Rock"));


            Console.WriteLine();
            //Ibrahim

            Func<int, int, int> avg = (x, y) => (x + y) / 2;

            Console.WriteLine(avg(56,23));

            Console.WriteLine();
            //Isaiah

            Random rand = new Random();
            Func<string> headsOrTails = () =>
            {
                return (rand.Next(2) == 0) ? "heads" : "tails";
            };
            Console.WriteLine(headsOrTails());

            Console.WriteLine();
            //Jayson

            string value = "hello";
            var scream = value.ToCharArray().Select(c => Char.ToUpper(c));
            string screaming = string.Join("", scream);
            Console.WriteLine(screaming);


            Console.WriteLine();
            //JD

            Func<int, int> doubleX = x => x * 2;
            Func<int, int, int> add = (x, y) =>
            {
                var temp = x + y;
                return temp;
            };
            Action<int> write = x => Console.WriteLine(x);
            write(doubleX(add(3, 5)));

            var developers = new string[]
            {
                "Scott",
                "Chris",
                "Ann"
            };
            var query = developers.Where(e => e.Length == 5)
                                  .OrderByDescending(e => e)
                                  .Select(e => e);
            foreach (var employee in query)
            {
                Console.WriteLine(employee);
            }



            Console.WriteLine();
            //Jeff

            Console.WriteLine("Please enter your name");
            var Name = Console.ReadLine();
            Action<string> greeet = name =>
            {
                string greeting = $"Welcome back {name}!";
                Console.WriteLine(greeting);
            };
            greeet(Name);


            Console.WriteLine();
            //John Kear

            int[] numbers = { 5, 10, 2, 1 };
            var roots = numbers.Select(x => Math.Sqrt(x));
            Console.WriteLine(string.Join(" ", roots));


            Console.WriteLine();
            //ken

            static bool checkBelowHundred(int x)
            {
                return x < 100;
            }

            Predicate<int> val = checkBelowHundred;
            Console.WriteLine(val(99)); // retun true


            Console.WriteLine();
            //Michael Hall

            // example returning absolute value of an int
            Func<int, int> magnitude = x => Math.Abs(x);
            Console.WriteLine($"|-5| is equal to {magnitude(-5)}");
            // example getting longest string
            string[] words = { "yes", "no", "maybe", "so" };
            string longest = words.OrderByDescending(s => s.Length).First();
            Console.WriteLine($"{longest} is the longest word");

            Console.WriteLine();
            //Michael Walker

            async void setAlarmAsync()
            {
                Action<string> alarm = message => Console.WriteLine(message);
                await Task.Delay(5000); // Wait five seconds for alarm
                alarm("Wake Up!");
            }

            setAlarmAsync();

            Console.ReadLine();// to wait out the async 5 seconds

            Console.WriteLine();
            //John Kear

            int[] numbers1 = { 5, 10, 2, 1 };
            var roots1 = numbers.Select(x => Math.Sqrt(x));
            Console.WriteLine(string.Join(" ", roots1));


            Console.WriteLine();
            //Kingsley

            Func<float, float> degreeToFah = (float degree) => 9 / 5 * degree + 32;
            Console.WriteLine("lambda function: {0}", degreeToFah(45.8f));


            Console.WriteLine();
            //Michael Wong

            Console.WriteLine("Awaiting User Input...");
            String message = "";
            message = Console.ReadLine();
            Console.WriteLine();
            StringDelegate PrintMessage = (String message, out String outMessage) =>
            {
                Console.WriteLine(message);
                outMessage = message;
            };
            StringDelegate CountLength = (String message, out String outMessage) =>
            {
                outMessage = message + $" is {message.Length} characters long.";
                Console.WriteLine(outMessage);
            };
            StringDelegate AppendMessage = (String message, out String outMessage) =>
            {
                Console.WriteLine("Appended Message");
                outMessage = message + " Appended";
            };
            List<StringDelegate> delegates = new List<StringDelegate>();
            delegates.Add(PrintMessage);
            delegates.Add(CountLength);
            delegates.Add(AppendMessage);
            delegates.Add(PrintMessage);
            delegates.Add(AppendMessage);
            delegates.Add(CountLength);
            delegates.Add(AppendMessage);
            foreach (StringDelegate stringDel in delegates)
            {
                stringDel(message, out message);
            }



            Console.WriteLine();
            //Ryan Oxford

            String[] words1 = { "apple", "laser", "poignant", "masterful", "prodigious", "mend" };
            String value1 = Array.Find(words1, element => element.Length < 5);
            Console.WriteLine("Word less than 5 letters long: {0}", value1);



            Console.WriteLine();
            //Ryan Shereda

            #region Lambda Counter
            int counter = 0;
            //console formatting
            System.Console.WriteLine("-------------------------------");
            System.Console.WriteLine($"Current value of the counter: {counter}");
            Action<int> counterUp = value =>
            {
                //lambda function writes the action, then performs it
                System.Console.WriteLine($"Increasing counter by {value}");
                counter += value;
            };
            //loop to run process multiple times, for display of versatility
            for (int i = 1; i <= 3; i++)
            {
                counterUp(i);
                System.Console.WriteLine($"Current value of the counter: {counter}");
            }
            //end of program console formatting
            System.Console.WriteLine("-------------------------------");
            #endregion

            Console.WriteLine();
            //Sulav Aryal

            int[] scores = { 70, 60, 50, 40 };
            IEnumerable<int> score = scores.Where(x => x > 60);
            // only prints the score greater than 60
            foreach (int i in score)
            {
                Console.WriteLine(i + " ");
            }
            //Console.ReadLine();

            Console.WriteLine();
            //Tanner
            int[] choices = { 1,2,3,4,5,6,7};
            var oddNumbers = choices.Select(x => x % 2 != 0);
            Console.WriteLine(string.Join(" ", oddNumbers));


            Console.WriteLine();
            //Will Bogucz
            string[] input = { "Rock", "PaPeR", "LAMDA" };
            var lowerCase = input.Select(x => x.ToLower());
            Console.WriteLine("These are all now lower case: " + string.Join(" ", lowerCase));


            Console.WriteLine();
            //Xavier
            string name = "Xavier"; 
            char[] charRep = name.ToCharArray();
            System.Console.WriteLine(charRep);
            Action<char[]> rev = revMe => Array.Reverse(revMe);
            rev(charRep);
            Console.WriteLine(charRep);


            Console.WriteLine();



            Console.WriteLine();



            Console.WriteLine();



            Console.WriteLine();



            Console.WriteLine();






        }

    }
        class Person
        {
            public string Name { get; set; }

            public int age { get; set; }

            public Person() { }
            public Person(string s, int n)
            {
                this.Name = s;
                this.age = n;
            }
        }
}
