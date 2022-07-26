NAME:- VINCHI PARTH D.
ROLL NO:- 48
SUBJECT:- C#
ENROLLMENT NO.:- 200802117

				LAB EXERCISE :- 1

1)Write a C# Sharp program to print Hello and your name in a separate line.
Expected Output :
Hello: Atmiya Students
-->ANSWER
using System;

class helloworld
{
    static void Main()
    {
        Console.WriteLine("HELLO ATMIYA STUDENTS ");
    }
}

1)Maximum no.
-->ANSWER
using System;
	class abc
{
    static void Main()
    {
        int a=10,b=30,c=15;
        if (a > b)
        {
            Console.WriteLine(a+"is big");
        }
        else if (b > c)
        {
            Console.WriteLine(b+"is big");
        }
        else 
        {
            Console.WriteLine(c + "is big");
        }
    }
}
2.) Write a C# Sharp program to print the sum of two numbers.
-->ANSWER
using System;

class Sum
{
    static void Main()
    {
        Console.WriteLine("Enter First No. :- ");
        int val1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Second No. :- ");
        int val2 = Convert.ToInt32(Console.ReadLine());

        int sum = val1 + val2;
        Console.WriteLine("Sum is " + sum);
    }
}

2)Prime no. or not
-->ANSWER
using System;

class PrimeNumber
{
    static void Main()
    {
        Console.WriteLine("Enter Number :- ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num % 2 == 0)
        {
            Console.WriteLine(num + " This is Prime Number");
        }
        else
        {
            Console.WriteLine(num + " This is not a Prime Number");
        }
    }
}
3.) Write a C# Sharp program to print the result of dividing two numbers.
-->ANSWER
using System;

class Divison
{
    static void Main()
    {
        Console.WriteLine("Enter First No. :- ");
        int val1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Second No. :- ");
        int val2 = Convert.ToInt32(Console.ReadLine());

        int Division = val1 / val2;
        Console.WriteLine("Division is " + Division);
    }
}
4.) Write a C# Sharp program to print the result of the specified operations.
Test data:
? -1 + 4 * 6
? ( 35+ 5 ) % 7
? 14 + -4 * 6 / 11
? 2 + 15 / 6 * 1 - 7 % 2
Expected Output:
23
5
12
3
-->ANSWER
using System;

class SpecifiedOperations
{
    static void Main()
    {
        Console.WriteLine("First Operation =" + (-1 + 4 * 6));
        Console.WriteLine("Second  Operation =" + ((35 + 5) % 7));
        Console.WriteLine("Third Operation =" + (14 + -4 * 6 / 11));
        Console.WriteLine("Fourth Operation =" + (2 + 15 / 6 * 1 - 7 % 2));
    }
}
5.) Write a C# Sharp program to swap two numbers.
Test Data:
Input the First Number : 5
Input the Second Number : 6
Expected Output:
After Swapping :
First Number : 6
Second Number : 5
-->ANSWER
using System;

class Swap
{
    static void Main()
    {
        int a = 5, b = 6, temp;
        temp = a;
        a = b;
        b = temp;
        Console.WriteLine("Enter Number is :  " +a);
        Console.WriteLine("Enter Number is :  " +b);
    }
}
7)Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and
dividing of two numbers which will be entered by the user.
Test Data:
Input the first number: 25
Input the second number: 4
Expected Output:
25 + 4 = 29
25 - 4 = 21
25 x 4 = 100
25 / 4 = 6
25 mod 4 = 1
-->ANSWER
using System;
public class Exercise7
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int num1= Convert.ToInt32(Console.ReadLine());
 
        Console.Write("Enter another number: ");
        int num2= Convert.ToInt32(Console.ReadLine());
   
        Console.WriteLine("{0} + {1} = {2}", num1, num2, num1+num2);
        Console.WriteLine("{0} - {1} = {2}", num1, num2, num1-num2);
        Console.WriteLine("{0} x {1} = {2}", num1, num2, num1*num2);
        Console.WriteLine("{0} / {1} = {2}", num1, num2, num1/num2);
        Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1%num2);
   }
}
8)Write a C# Sharp program that takes a number as input and print its multiplication table.
Test Data:
Enter the number: 5
Expected Output:
5 * 0 = 0
5 * 1 = 5
5 * 2 = 10
5 * 3 = 15
....
5 * 10 = 50
-->ANSWER
using System;
public class Exercise8
{
    public static void Main()
    {
        int x;
        int result;

        Console.WriteLine("Enter a number:");
        x = Convert.ToInt32(Console.ReadLine());

        result = x * 1;
        Console.WriteLine("The table is : {0} x {1} = {2}", x, 1, result);
        result = x * 2;
        Console.WriteLine("             : {0} x {1} = {2}", x, 2, result);
        result = x * 3;
        Console.WriteLine("             : {0} x {1} = {2}", x, 3, result);
        result = x * 4;
        Console.WriteLine("             : {0} x {1} = {2}", x, 4, result);
        result = x * 5;
        Console.WriteLine("             : {0} x {1} = {2}", x, 5, result);
        result = x * 6;
        Console.WriteLine("             : {0} x {1} = {2}", x, 6, result);
        result = x * 7;
        Console.WriteLine("             : {0} x {1} = {2}", x, 7, result);
        result = x * 8;
        Console.WriteLine("             : {0} x {1} = {2}", x, 8, result);
        result = x * 9;
        Console.WriteLine("             : {0} x {1} = {2}", x, 9, result);
        result = x * 10;
        Console.WriteLine("             : {0} x {1} = {2}", x, 10, result);
    }
}
9)Write a C# Sharp program that takes four numbers as input to calculate and print the average.
Test Data:
Enter the First number: 10
Enter the Second number: 15
Enter the third number: 20
Enter the four number: 30
Expected Output:
The average of 10 , 15 , 20 , 30 is: 18
-->ANSWER
using System;
using System.IO;
public class Exercise9
{
    public static void Main()
    {
        double number1, number2, number3, number4;

        Console.Write("Enter the First number: ");
        number1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the Second number: ");
        number2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the third number: ");
        number3 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the fourth number: ");
        number4 = Convert.ToDouble(Console.ReadLine());

        double result = (number1 + number2 + number3 + number4) / 4;
        Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4} ",
     number1, number2, number3, number4, result);
    }
}
10)Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of
(x+y).z and x.y + y.z.
Test Data:
Enter first number - 5
Enter second number - 6
Enter third number - 7
Expected Output:
Result of specified numbers 5, 6 and 7, (x+y).z is 77 and x.y + y.z is 72
-->ANSWER
using System;
public class Exercise10
{
    public static void Main()
    {
        int number1, number2, number3;

        Console.Write("Enter first number - ");
        number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number - ");
        number2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter third number - ");
        number3 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Output of {0}, {1} and {2}, (x+y)�z is {3} and x�y + y�z is {4}\n\n",
            number1, number2, number3, ((number1 + number2) * number3), (number1 * number2 + number2 * number3));
    }
}
11)Write a C# Sharp program that takes an age (for example 20) as input and prints something
as "You look older than 20".
Test Data:
Enter your age � 25
Expected Output:
You look older than 25
-->ANSWER
using System;
public class Exercise11
{
    public static void Main()
    {
        int age;
        Console.Write("Enter your age ");
        age = Convert.ToInt32(Console.ReadLine());
        Console.Write("You look younger than {0} ", age);
        Console.WriteLine("");
    }
}
12) Write a C# program to that takes a number as input and display it four times in a row
(separated by blank spaces), and then four times in the next row, with no separation. You should
do it two times: Use Console. Write and then use {0}.
Test Data:
Enter a digit: 25
Expected Output:
25 25 25 25
25252525
25 25 25 25
25252525
-->ANSWER
using System;
public class Exercise12
{
    public static void Main()
    {
        int num;

        Console.WriteLine("Enter a digit: ");
        num = Convert.ToInt32(Console.ReadLine());

        // Part A: "num num num num" using Write
        Console.Write(num);
        Console.Write(" ");
        Console.Write(num);
        Console.Write(" ");
        Console.Write(num);
        Console.Write(" ");
        Console.Write(num);
        Console.WriteLine();

        // Part B: "numnumnumnum" using Write
        Console.Write(num);
        Console.Write(num);
        Console.Write(num);
        Console.WriteLine(num);
        


        Console.WriteLine("{0} {0} {0} {0}", num);
        Console.WriteLine("{0}{0}{0}{0}", num);
    }
}
13)Write a C# program that takes a number as input and then displays a rectangle of 3 columns
wide and 5 rows tall using that digit.
Test Data:
Enter a number: 5
Expected Output:
555
5 5
5 5
5 5
555
-->ANSWER
using System;
public class Exercise13
{
    public static void Main()
    {
        int x;

        Console.Write("Enter a number: ");
        x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("{0}{0}{0}", x);
        Console.WriteLine("{0} {0}", x);
        Console.WriteLine("{0} {0}", x);
        Console.WriteLine("{0} {0}", x);
        Console.WriteLine("{0}{0}{0}", x);
    }
}
14). Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit.
Test Data:
Enter the amount of celsius: 30
Expected Output:
Kelvin = 303
Fahrenheit = 86
-->ANSWER
using System;
public class Exercise14
{
    public static void Main()
    {
        Console.Write("Enter the amount of Celsius: ");
        int celsius = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Kelvin = {0}", celsius + 273);
        Console.WriteLine("Fahrenheit = {0}", celsius * 18 / 10 + 32);
    }
}
15)Write a C# program remove specified a character from a non-empty string using index of a
character.
Test Data:
Atmiya University
Sample Output:
Atiya University
Atmiya niversity
-->ANSWER
using System;
using System.Collections.Generic;

public class Exercise15
{
    static void Main(string[] args)
    {
        Console.WriteLine(remove_char("Atmiya University", 2));
        Console.WriteLine(remove_char("Atmiya University", 7));
    }
    public static string remove_char(string str, int n)
    {
        return str.Remove(n, 1);
    }
}
16)Write a C# program to create a new string from a given string (length 1 or more) with the 
first character added at the front and back.
Sample Output:
Input a string : The quick brown fox jumps over the lazy dog. 
TThe quick brown fox jumps over the lazy dog.T
-->ANSWER
using System;
using System.Text;

public class Exercise17
{
    static void Main(string[] args)
    {
        string str;
        int l = 0;
        Console.Write("Input a string : ");
        str = Console.ReadLine();
        if (str.Length >= 1)
        {
            var s = str.Substring(0, 1);
            Console.WriteLine(s + str + s);
        }
    }
}
17)Write a C# program to check two given integers and return true if one is negative and one is 
positive.
Sample Output:
Input first integer:
-5 
Input second integer: 
25 
Check if one is negative and one is positive: 
True 
-->ANSWER
using System;
using System.Collections.Generic;

public class Exercise18 {
  static void Main(string[] args)
        {
           Console.WriteLine("\nInput first integer:");  
           int x = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Input second integer:");  
           int y = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Check if one is negative and one is positive:");
           Console.WriteLine((x < 0 && y > 0) || (x > 0 && y < 0));
        }
}
18)Write a C# program to compute the sum of two given integers, if two values are equal then 
return the triple of their sum.
-->ANSWER
using System;
using System.Linq;
namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(12, 17));
            Console.WriteLine(test(2, 17));
            Console.WriteLine(test(22, 17));
            Console.WriteLine(test(20, 0));
            Console.ReadLine();
        }
        public static int test(int a, int b)
        {
            return a + b >= 10 && a + b <= 20 ? 30 : a + b;
        }

    }
}
19)Write a C# program to get the absolute value of the difference between two given numbers. 
Return double the absolute value of the difference if the first number is greater than second 
number.
-->ANSWER
using System;
using System.Collections.Generic;

public class Exercise20
{
    static void Main(string[] args)
    {
        Console.WriteLine(result(13, 40));
        Console.WriteLine(result(50, 21));
        Console.WriteLine(result(0, 23));
    }

    public static int result(int a, int b)
    {
        if (a > b)
        {
            return (a - b) * 2;
        }
        return b - a;
    }
}
20)Write a C# program to check the sum of the two given integers and return true if one of the 
integer is 20 or if their sum is 20.
-->ANSWER
using System;
using System.Linq;
namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(12, 17));
            Console.WriteLine(test(2, 17));
            Console.WriteLine(test(22, 17));
            Console.WriteLine(test(20, 0));
            Console.ReadLine();
        }
        public static int test(int a, int b)
        {
            return a + b >= 10 && a + b <= 20 ? 30 : a + b;
        }

    }
}
21)Write a C# program to check if an given integer is within 20 of 100 or 200.
-->ANSWER
using System;
using System.Collections.Generic;

public class Exercise22
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nInput an integer:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(result(x));
    }

    public static bool result(int n)
    {
        if (Math.Abs(n - 100) <= 20 || Math.Abs(n - 200) <= 20)
            return true;
        return false;
    }
}
22)Write a C# program to convert a given string into lowercase.
-->ANSWER
using System;
public class Exercise23
{
    public static void Main()
    {
        string line = "Write a C# Sharp Program to display the following pattern using the alphabet.";

        Console.WriteLine(line.ToLower());

    }
}
23)Write a C# program to print the odd numbers from 1 to 99. Prints one number per line.
Sample Output:
Odd numbers from 1 to 99. Prints one number per line.
1
3
5
7
9
...
95
97
99
-->ANSWER
using System;  
public class Exercise25
{  
    public static void Main() 
      {     
          Console.WriteLine("Odd numbers from 1 to 99. Prints one number per line.");
          for (int n = 1; n < (99 + 1); n++)
            {
                if (n % 2 != 0)
                {
                    Console.WriteLine(n.ToString());
                }
            }
                    
    }
}
24)Write a C# program to compute the sum of the first 500 prime numbers.
Sample Output:
Sum of the first 500 prime numbers:
3682913
-->ANSWER 
using System;
public class Exercise26
{
    public static void Main()
    {
        Console.WriteLine("\nSum of the first 500 prime numbers: ");
        long sum = 0;
        int ctr = 0;
        int n = 2;
        while (ctr < 500)
        {
            if (isPrime(n))
            {
                sum += n;
                ctr++;
            }
            n++;
        }

        Console.WriteLine(sum.ToString());

    }
    public static bool isPrime(int n)
    {
        int x = (int)Math.Floor(Math.Sqrt(n));

        if (n == 1) return false;
        if (n == 2) return true;

        for (int i = 2; i <= x; ++i)
        {
            if (n % i == 0) return false;
        }

        return true;
    }
}
25. Write a C# program and compute the sum of the digits of an integer.
Sample Output:
Input a number(integer): 12
Sum of the digits of the said integer: 3
-->ANSWER
using System;
public class SumExample
{
    public static void Main(string[] args)
    {
        int n, sum = 0, m;
        Console.Write("Enter a number: ");
        n = int.Parse(Console.ReadLine());
        while (n > 0)
        {
            m = n % 10;
            sum = sum + m;
            n = n / 10;
        }
        Console.Write("Sum is= " + sum);
    }
}
26) Write a C# program to reverse the words of a sentence.
Sample Output:
Original String: Display the pattern like pyramid using the alphabet.
Reverse String: alphabet. the using pyramid like pattern the Display
-->ANSWER
using System;
using System.Collections.Generic;
public class Exercise28 {
 public static void Main() {
  string line = "Display the pattern like pyramid using the alphabet.";
  Console.WriteLine("\nOriginal String: " + line);
  string result = "";
  List < string > wordsList = new List < string > ();
  string[] words = line.Split(new [] {
   " "
  }, StringSplitOptions.None);
  for (int i = words.Length - 1; i >= 0; i--) {
   result += words[i] + " ";
  }
  wordsList.Add(result);
  foreach(String s in wordsList) {

   Console.WriteLine("\nReverse String: " + s);
  }
 }
}
28)Write a C# program to convert a hexadecimal number to decimal number.
Sample Output:
Hexadecimal number: 4B0
Convert toDecimal number: 1200
-->ANSWER
using System;
using System.Text;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring a variable and assigning hex value
            string hex_value = "10FA";

            //converting hex to integer
            int int_value = Convert.ToInt32(hex_value, 16);

            //printing the values
            Console.WriteLine("hex_value = {0}", hex_value);
            Console.WriteLine("int_value = {0}", int_value);

            //hit ENTER to exit
            Console.ReadLine();
        }
    }
}
29)Write a C# program to multiply corresponding elements of two arrays of integers.
Sample Output:
Array1: [1, 3, -5, 4]
Array2: [1, 4, -5, -2]
Multiply corresponding elements of two arrays:
1 12 25 -8
-->ANSWER
using System;
using System.Collections.Generic;
public class Exercise31
{
    public static void Main()
    {
        int[] first_array = { 1, 3, -5, 4 };
        int[] second_array = { 1, 4, -5, -2 };

        Console.WriteLine("\nArray1: [{0}]", string.Join(", ", first_array));
        Console.WriteLine("Array2: [{0}]", string.Join(", ", second_array));

        Console.WriteLine("\nMultiply corresponding elements of two arrays: ");

        for (int i = 0; i < first_array.Length; i++)
        {

            Console.Write(first_array[i] * second_array[i] + " ");
        }
        Console.WriteLine("\n");
    }
}
30). Write a C# program to create a new string of four copies, taking last four characters from a
given string. If the length of the given string is less than 4 return the original one.
Sample Output:
Input a string : The quick brown fox jumps over the lazy dog.
dog.dog.dog.dog.
-->ANSWER
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Exercise32
{
    static void Main(string[] args)
    {
        string str;
        int l = 0;
        Console.Write("Input a string : ");
        str = Console.ReadLine();
        if (str.Length > 4)
        {
            Console.WriteLine(str.Length < 4 ? str + str + str : str.Substring(str.Length - 4) + str.Substring(str.Length - 4) + str.Substring(str.Length - 4) + str.Substring(str.Length - 4));
        }
    }
}
31). Write a C# program to check if a given positive number is a multiple of 3 or a multiple of 7.
Sample Output:
Input first integer:
15
True
-->ANSWER
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exercise33
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nInput first integer:");
        int x = Convert.ToInt32(Console.ReadLine());
        if (x > 0)
        {
            Console.WriteLine(x % 3 == 0 || x % 7 == 0);
        }
    }
}
32). Write a C# program to check if a string starts with a specified word.
Note: Suppose the sentence starts with "Hello"
Sample Data: string1 = "Hello how are you?"
Result: Hello.
Sample Output:
Input a string : Hello how are you?
True
-->ANSWER
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Exercise34 {
  static void Main(string[] args)
        {
           string str; 
           Console.Write("Input a string : ");
           str = Console.ReadLine();
           Console.WriteLine((str.Length < 6 && str.Equals("Hello")) || (str.StartsWith("Hello") && str[5] == ' '));
        }
}
33)Write a C# program to check two given numbers where one is less than 100 and other is
greater than 200.
Sample Output:
Input a first number(<100): 75
Input a second number(>100): 250
True
-->ANSWER
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Exercise35
{
    static void Main(string[] args)
    {
        Console.Write("Input a first number(<100): ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a second number(>200): ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine((m < 100 && n > 200));
    }
}
34)Write a C# program to check if an integer (from the two given integers) is in the range -10 to
10.
Sample Output:
Input a first number: -5
Input a second number: 8
True
-->ANSWER
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exercise36
{
    static void Main(string[] args)
    {
        Console.Write("Input a first number: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a second number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(((m >= -10 && m <= 10)) || ((n >= -10 && n <= 10)));
    }
}
35)Write a C# program to check if "HP" appears at second position in a string and returns the
string without "HP".
Test Data: PHP Tutorial
Sample Output:
P Tutorial
-->ANSWER
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exercise37
{
    static void Main(string[] args)
    {
        string str = "PHP Tutorial";
        Console.WriteLine((str.Substring(1, 2).Equals("HP") ? str.Remove(1, 2) : str));
    }
}
36). Write a C# program to find the largest and lowest values from three integer values.
Test Data:
Input first integer:
15
Input second integer:
25
Input third integer:
30
Sample Output
Largest of three: 30
Lowest of three: 15
-->ANSWER
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Exercise39
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nInput first integer:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input second integer:");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input third integer:");
        int z = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Largest of three: " + Math.Max(x, Math.Max(y, z)));
        Console.WriteLine("Lowest of three: " + Math.Min(x, Math.Min(y, z)));
    }
}
37)Write a C# program to check the nearest value of 20 of two given integers and return 0 if two
numbers are same.
Test Data:
Input first integer:
15
Input second integer:
12
Sample Output
15
-->ANSWER
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Exercise40
{
    public static void Main()
    {
        Console.WriteLine("\nInput first integer:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input second integer:");
        int y = Convert.ToInt32(Console.ReadLine());
        int n = 20;
        var val1 = Math.Abs(x - n);
        var val2 = Math.Abs(y - n);
        Console.WriteLine(val1 == val2 ? 0 : (val1 < val2 ? x : y));
    }
}
38). Write a C# program to count a specified number in a given array of integers.
Test Data:
Input an integer: 5
Sample Output
Number of 5 present in the said array: 2 
-->ANSWER
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Exercise45
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nInput an integer:");
        int x = Convert.ToInt32(Console.ReadLine());
        int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };
        Console.WriteLine("Number of " + x + " present in the said array:");
        Console.WriteLine(nums.Count(n => n == x));
    }
}
39)Write a C# program to check if a number appears as either the first or last element of an array
of integers and the length is 1 or more.
Test Data:
Input an integer: 25
Sample Output
False
-->ANSWER
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exercise46
{
    public static void Main()
    {
        Console.WriteLine("\nInput an integer:");
        int x = Convert.ToInt32(Console.ReadLine());
        int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };
        Console.WriteLine((nums[0] == x) || (nums[nums.Length - 1] == x));
    }
}
40)0. Write a C# program to compute the sum of all the elements of an array of integers.
Test Data:
Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1]
Sample Output
Sum: 69 
-->ANSWER
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exercise47
{
    public static void Main()
    {
        int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
        Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums));
        var sum = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }
        Console.WriteLine("Sum: " + sum);
    }
}
41)Write a C# program to check if the first element or the last element of the two arrays ( length 
1 or more) are equal.
Test Data:
Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1] 
Array2: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5]
Check if the first element or the last element of the two arrays ( leng th 1 or more) are equal. 
Sample Output
True 
-->ANSWER
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exercise49
{
    public static void Main()
    {
        int[] nums1 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
        Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums1));
        int[] nums2 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5 };
        Console.WriteLine("\nArray2: [{0}]", string.Join(", ", nums2));

        Console.WriteLine("\nCheck if the first element or the last element of the two arrays ( length 1 or more) are equal.");
        Console.WriteLine((nums1[0].Equals(nums2[0])) || (nums1[nums1.Length - 1].Equals(nums2[nums2.Length - 1])));
    }
}
42)Write a C# program to rotate an array (length 3) of integers in left direction.
Test Data:
Array1: [1, 2, 8]
After rotating array becomes: [2, 8, 1] 
-->ANSWER
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exercise50
{
    public static void Main()
    {
        int[] nums = { 1, 2, 8 };
        Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums));
        var temp = nums[0];
        for (var i = 0; i < nums.Length - 1; i++)
        {
            nums[i] = nums[i + 1];
        }
        nums[nums.Length - 1] = temp;
        Console.WriteLine("\nAfter rotating array becomes: [{0}]", string.Join(", ", nums));

    }
}
43)Write a C# program to get the larger value between first and last element of an array (length 
3) of integers.
Test Data:
Array1: [1, 2, 5, 7, 8] 
Highest value between first and last values of the said array: 8 
-->ANSWER
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exercise51
{
    public static void Main()
    {
        int[] nums = { 1, 2, 5, 7, 8 };
        Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums));
        var h_val = nums[0];
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] > nums[0])
                h_val = nums[i];
        }
        Console.WriteLine("\nHighest value between first and last values of the said array: {0}", h_val);

    }
}
44)Write a C# program to create a new array of length containing the middle elements of three 
arrays (each length 3) of integers.
Test Data:
Array1: [1, 2, 5]
Array2: [0, 3, 8]
Array3: [-1, 0, 2]
New array: [2, 3, 0]
-->ANSWER
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exercise52
{
    public static void Main()
    {
        int[] array1 = { 1, 2, 5 };
        Console.WriteLine("\nArray1: [{0}]", string.Join(", ", array1));
        int[] array2 = { 0, 3, 8 };
        Console.WriteLine("\nArray2: [{0}]", string.Join(", ", array2));
        int[] array3 = { -1, 0, 2 };
        Console.WriteLine("\nArray3: [{0}]", string.Join(", ", array3));
        int[] new_array = { array1[1], array2[1], array3[1] };
        Console.WriteLine("\nNew array: [{0}]", string.Join(", ", new_array));

    }
}
45)Write a C# program to check if an array contains an odd number.
Test Data:
Original array: [2, 4, 7, 8, 6]
Check if an array contains an odd number? True
-->ANSWER
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exercise53
{  
   public static void Main() 
      {
         int[] nums = {2, 4, 7, 8, 6};
         Console.WriteLine("\nOriginal array: [{0}]", string.Join(", ", nums));
         Console.WriteLine("Check if an array contains an odd number? "+even_odd(nums));
      }  
        
    public static bool even_odd(int[] nums)  
    {
         foreach (var n in nums)
            {
                if (n % 2 != 0) 
                return true;
            }
        return false;
              
     } 
}



					.....FINISHED.....