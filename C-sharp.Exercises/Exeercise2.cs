using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Security.Cryptography;
using System.Xml;
using static System.Int32;

namespace C_sharp.Exercises;

public class Exeercise2
{
    ///// <summary>
    ///// 1- When you post a message on Facebook, depending on the number of people
    ///      who like your post, Facebook displays different information.
    //       If no one likes your post, it doesn't display anything.
    //       If only one person likes your post, it displays: [Friend's Name] likes
    //       your post.
    //       If two people like your post, it displays: [Friend 1] and[Friend 2]
    //       like your post.
    //       If more than two people like your post, it displays: [Friend 1],
    //       [Friend 2] and[Number of Other People] others like your post.
    //       Write a program and continuously ask the user to enter different
    //       names, until the user presses Enter (without supplying a name).
    //       Depending on the number of names provided, display a message based
    //       on the above pattern
    //       
    //       
    ///// </summary>
    public void Question1()
    {
        var str = new List<string?>();
        var counterNames = 0;
        var index = 0;
        while (true)
        {
            
            str.Add(Console.ReadLine());
            if (string.IsNullOrEmpty(str[index]))
            {
                break;
            }

            index++;
            counterNames++;
        }

        switch (counterNames)
        {
            case 0:
                break;
            case 1:
                Console.WriteLine($"{str[0]} likes your post.");
                break;
            case 2:
                Console.WriteLine($"{str[0]} and {str[1]} like your post.");
                break;
            default:
                Console.WriteLine($"{str[0]} and {str[1]} and Number of Other People others like your post.");
                break;
        }
    }
    /// <summary>
    /// 2- Write a program and ask the user to enter their name.
    /// Use an array to reverse the name and then store the result
    /// in a new string. Display the reversed name on the console.
    /// </summary>
    public void Question2()
    {
        Console.WriteLine("Pleas enter your name:");
        var nameInput = Console.ReadLine();
        var inputChars = nameInput?.ToCharArray();
        if (inputChars == null) return;
        Array.Reverse(inputChars);
        Console.WriteLine("Reversed name is : ");
        foreach (var charInputChar in inputChars)
        {
            Console.Write(charInputChar);
        }
    }

    /// <summary>
    /// 3- Write a program and ask the user to enter 5 numbers.
    /// If a number has been previously entered, display an error message
    /// and ask the user to re-try. Once the user successfully enters 5 unique
    /// numbers, sort them and display the result on the console.


    /// </summary>
    public void Question3()
    {
        var flag = true;
        Console.WriteLine("Please enter 5 uniq number:");
        var numbers = new int[5];
        var number = -1;
        while (flag==true)
        {
            Array.Clear(numbers);
            Console.WriteLine("what is your value:");
            for (var i = 0; i < numbers.Length; i++)
            {
                flag = false;
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                if (numbers[i] == number)
                {
                    Console.WriteLine("Error: your numbers are not uniq!");
                    Console.WriteLine("Do you want to retry?(Y/N)");
                    var answerCheck = char.Parse(Console.ReadLine().ToLower());
                    if (answerCheck != 'y')
                    {
                        return;
                    }
                    flag = true;
                    break;
                }

                number = numbers[i];
            }
            
        }
        Console.WriteLine("Output is:");
        Array.Sort(numbers);
        foreach (var value in numbers)
        {
            Console.WriteLine(value);
        }
    }

    /// 4 - Write a program and ask the user to continuously enter a number
    /// or type "Quit" to exit. The list of numbers may include duplicates.
    /// Display the unique numbers that the user has entered.
    public void Question4()
    {
        var numbers = new List<int>();
        string? rvalues;
        const string exit = "Quit";
        Console.WriteLine("You can continuously enter a number!");
        do
        {
            for (var i = 0; i < 5; i++)
            {
                numbers.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("If you don't want to continue, you can type \"Quit\"!");
            rvalues = Console.ReadLine();
        } while (rvalues!=exit);


        Console.WriteLine("Uniq numbers are:");
        foreach (var number in numbers)
        {
            var counter=0;
            var flag = false;
            foreach (var i in numbers)
            {
                if (number == i)
                {
                    counter++;
                }

                if (counter <= 1) continue;
                flag = true;
                break;
            }

            if (flag==false)
            {
                Console.WriteLine(number + " ");
            }

        }

    }

    /// <summary>
    /// 5- Write a program and ask the user to supply a list of comma separated
    /// numbers (e.g 5, 1, 9, 2, 10). If the list is empty or includes less than
    /// 5 numbers, display "Invalid List" and ask the user to re-try; otherwise,
    /// display the 3 smallest numbers in the list.
    /// </summary>
    public void Question5()
    {
        var numbers = new List<int>();
        var flag = false;
        var minArray = new int[3]{MaxValue, MaxValue, MaxValue};
        do
        {
            Console.WriteLine("Please enter a list of comma separated numbers:");
            var stringinput = Console.ReadLine()?.Split(',');
            if (stringinput != null)
            {
                var intInput = new int[stringinput.Length];
                for (var i = 0; i < stringinput.Length; i++)
                {
                    intInput[i] = Convert.ToInt32(stringinput[i]);
                }
                numbers.AddRange(intInput);
            }
            if (numbers.Count <= 5)
            {
                Console.WriteLine("Invalid list!");
                Console.WriteLine("Please retry.");
            }
            else
            {
                flag = true;
            }
        } while (flag == false);
        for (var i = 0; i < 3; i++)
        {
            foreach (var t in numbers)
            {
                if (t < minArray[i])
                {
                    minArray[i] = t;
                }
            }

            numbers.Remove(numbers[numbers.IndexOf(minArray[i])]);
        }
        Console.WriteLine("The 3 smallest number in the list is:");
        foreach (var i in minArray)
        {
            Console.WriteLine(i+" ");
        }
    }
}