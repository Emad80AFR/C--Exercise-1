namespace C_sharp.Exercises
{
    public class Exercise1
    {
        //Question1();
        //Question2();
        //Question3();
        //Question4();
        // ReSharper disable once InvalidXmlDocComment
        /// Write a program to count how many numbers between
        /// 1 and 100 are divisible by 3 with no remainder.
        /// Display the count on the console.
        public void Question1()
        {

            var counter = 0;

            for (var i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    counter++;
                }
            }

            Console.WriteLine($"Count of numbers from 1 to 100 is:{counter}");

        }

        // ReSharper disable once InvalidXmlDocComment
        ///Write a program and continuously ask the user to enter a number
        /// or "ok" to exit. Calculate the sum of all the previously entered
        /// numbers and display it on the console.
        public void Question2()
        {
            var sum = 0;
            while (true)
            {
                var strImpute = Console.ReadLine();
                if (strImpute == "ok")
                {
                    break;
                }

                var integerValue = Convert.ToInt32(Console.ReadLine());
                sum += integerValue;

            }

            Console.WriteLine($"sum of the numbers is:{sum}");
        }



        // ReSharper disable once InvalidXmlDocComment
        ///Write a program and ask the user to enter a number.
        /// Compute the factorial of the number and print it on the console.
        /// For example, if the user enters 5, the program should calculate
        /// 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
        public void Question3()
        {
            Console.WriteLine("Please enter a number:");
            var numberForFactorial = Convert.ToInt32(Console.ReadLine());
            var result = 1;
            for (var i = 0; i < numberForFactorial; i++)
            {
                result *= (numberForFactorial - i);
            }

            Console.WriteLine($"Your result for factorial operation is:{result}");
        }

        // ReSharper disable once InvalidXmlDocComment
        ///Write a program that picks a random number between
        /// 1 and 10. Give the user 4 chances to guess the number.
        /// If the user guesses the number, display “You won";
        /// otherwise, display “You lost".
        /// (To make sure the program is behaving correctly,
        /// you can display the secret number on the console first.)
        public void Question4()
        {
            var random = new Random();
            var randomValue = random.Next(1, 10);
            Console.WriteLine(randomValue);
            for (var i = 0; i < 4; i++)
            {
                Console.Write($"Pleas enter {(CordinalNumbers)i} guess:");
                var userImpute = Convert.ToInt32(Console.ReadLine());
                if (userImpute != randomValue) continue;
                Console.WriteLine("You won");
                return;
            }

            Console.WriteLine("You lost");
        }


        // ReSharper disable once InvalidXmlDocComment
        ///Write a program and ask the user to enter a series of numbers
        /// separated by comma. Find the maximum of the numbers and display
        /// it on the console. For example, if the user enters
        /// “5, 3, 8, 1, 4", the program should display 8.

        public void Question5()
        {
            Console.WriteLine("Please enter a series of numbers separated by comma:");
            var input = Console.ReadLine();
            var numbers = input?.Split(',');
            var max = Convert.ToInt32(numbers?[0]);
            if (numbers != null)
                foreach (var number in numbers)
                {
                    var compare = Convert.ToInt32(number);
                    if (compare > max)
                    {
                        max = compare;
                    }
                }

            Console.WriteLine("maximum number is:"+ max);
        }
    }
}