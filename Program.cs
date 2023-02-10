using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Study_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //      Day 0
            /*
            using System;
            using System.Collections.Generic;
            using System.IO;

            class Solution
                    {
                        static void Main(String[] args)
                        {
                            // Declare a variable named 'inputString' to hold our input.
                            String inputString;

                            // Read a full line of input from stdin (cin) and save it to our variable, input_string.
                            inputString = Console.ReadLine();

                            // Print a string literal saying "Hello, World." to stdout using cout.
                            Console.WriteLine("Hello, World.");

                            // TODO: Write a line of code here that prints the contents of input_string to stdout.
                            Console.WriteLine(inputString);
                        }
                    }
            */
            //      Day 1
            /*
                using System;
                using System.Collections.Generic;
                using System.IO;

                class Solution 
                {
                    static void Main(String[] args) 
                    {
                        int i = 4;
                        double d = 4.0;
                        string s = "HackerRank ";

                        // Declare second integer, double, and String variables.
                        int myInt;
                        double myDoub;
                        string myString; 
                        // Read and save an integer, double, and String to your variables.
                        myInt = int.Parse(Console.ReadLine());
                        myDoub = double.Parse(Console.ReadLine());
                        myString = Console.ReadLine();
                        // Print the sum of both integer variables on a new line.
                        Console.WriteLine(string.Format("{0:0}", i + myInt));
                        // Print the sum of the double variables on a new line.
                        Console.WriteLine(string.Format("{0:0.0}", d + myDoub));
                        // Concatenate and print the String variables on a new line
                        // The 's' variable above should be printed first.
                        Console.WriteLine(s + myString);
                    }
                }
             */
            //      Day 2
            /*
            using System.CodeDom.Compiler;
            using System.Collections.Generic;
            using System.Collections;
            using System.ComponentModel;
            using System.Diagnostics.CodeAnalysis;
            using System.Globalization;
            using System.IO;
            using System.Linq;
            using System.Reflection;
            using System.Runtime.Serialization;
            using System.Text.RegularExpressions;
            using System.Text;
            using System;

            class Result
            {

                 * Complete the 'solve' function below.
                 *
                 * The function accepts following parameters:
                 *  1. DOUBLE meal_cost
                 *  2. INTEGER tip_percent
                 *  3. INTEGER tax_percent

                        public static void solve(double meal_cost, int tip_percent, int tax_percent)
                        {
                            double comidaGorgeta = meal_cost * (Convert.ToDouble(tip_percent) / 100);
                            double comidaTaxa = (meal_cost * (Convert.ToDouble(tax_percent) / 100));
                            double comidaPrecoFinal = meal_cost + comidaGorgeta + comidaTaxa;
                            int comidaPrecoArredondado = Convert.ToInt32(Math.Round(comidaPrecoFinal));
                            Console.WriteLine(comidaPrecoArredondado);
                        }

                    }

                    class Solution
                    {
                        public static void Main(string[] args)
                        {
                            double meal_cost = Convert.ToDouble(Console.ReadLine().Trim());

                            int tip_percent = Convert.ToInt32(Console.ReadLine().Trim());

                            int tax_percent = Convert.ToInt32(Console.ReadLine().Trim());

                            Result.solve(meal_cost, tip_percent, tax_percent);
                        }
                    }
             */
            // Day 3
            /*
            using System.CodeDom.Compiler;
            using System.Collections.Generic;
            using System.Collections;
            using System.ComponentModel;
            using System.Diagnostics.CodeAnalysis;
            using System.Globalization;
            using System.IO;
            using System.Linq;
            using System.Reflection;
            using System.Runtime.Serialization;
            using System.Text.RegularExpressions;
            using System.Text;
            using System;

            class Solution
            {
              public static void Main(string[] args)
              {
                  int N = Convert.ToInt32(Console.ReadLine().Trim());

                  if ( N % 2 == 1) {
                      Console.WriteLine("Weird");
                  } else if ( N % 2 == 0 && N > 1 && N < 6 ) {
                      Console.WriteLine("Not Weird");
                  } else if (N % 2 == 0 && N > 5 && N < 21) {
                      Console.WriteLine("Weird");
                  } else if (N % 2 == 0 && N > 20) {
                      Console.WriteLine("Not Weird");
                  }
              }
            }
             */
            //      Day 4
            /*
            using System;
            using System.Collections.Generic;
            using System.IO;

            class Person {
                public int age;     
	            public Person(int initialAge) {
                    // Add some more code to run some checks on initialAge
                    age = initialAge;
                    if (age < 0) {
                        Console.WriteLine("Age is not valid, setting age to 0.");
                        age = 0;
                    }
                 }
                 public void amIOld() {
                    // Do some computations in here and print out the correct statement to the console 
                    if (age < 13) {
                        Console.WriteLine("You are young.");  
                    } else if (age < 18) {
                        Console.WriteLine("You are a teenager.");
                    } else {
                        Console.WriteLine("You are old.");
                    }
                 }
                 public void yearPasses() {
                    // Increment the age of the person in here
                    age++;
                 }

            static void Main(String[] args) {
                    int T=int.Parse(Console.In.ReadLine());
                    for (int i = 0; i < T; i++) {
                        int age=int.Parse(Console.In.ReadLine());
                        Person p=new Person(age);
                         p.amIOld();
                            for (int j = 0; j < 3; j++) {
                              p.yearPasses();
                            }
                            p.amIOld();
                            Console.WriteLine();
                    }
                }
            }
             */
            //      Day 5
            /*
            using System.CodeDom.Compiler;
            using System.Collections.Generic;
            using System.Collections;
            using System.ComponentModel;
            using System.Diagnostics.CodeAnalysis;
            using System.Globalization;
            using System.IO;
            using System.Linq;
            using System.Reflection;
            using System.Runtime.Serialization;
            using System.Text.RegularExpressions;
            using System.Text;
            using System;

            class Solution
            {
                public static void Main(string[] args)
                {
                    int n = Convert.ToInt32(Console.ReadLine().Trim());
        
                    for (int i = 1; i <= 10; i++) {
                        int res = Convert.ToInt32(i * n);
                        Console.WriteLine($"{n} x {i} = {res}");
                    }
                }
            }
             */
            //      Day 6
            /*
            using System;
            using System.Collections.Generic;
            using System.IO;
            class Solution {
                static void Main(String[] args) {
                    int T = Convert.ToInt32(Console.ReadLine());
                    string S = Console.ReadLine();

                    for (int j = 0; j != T; j++ ) {
                        string odd = string.Empty;
                        string even = string.Empty;
                        for (int i = 0; i < S.Length; i++) {
                            if ((i % 2) == 0) {
                                even += Convert.ToString(S[i]);
                            }
                            else {
                                odd += Convert.ToString(S[i]);
                            }
                        }
                        S = string.Empty;
                        S = Console.ReadLine();
                        Console.WriteLine($"{even} {odd}");
                    }  
                }     
            }
             */
            //      Day 7
            /*
             using System.CodeDom.Compiler;
            using System.Collections.Generic;
            using System.Collections;
            using System.ComponentModel;
            using System.Diagnostics.CodeAnalysis;
            using System.Globalization;
            using System.IO;
            using System.Linq;
            using System.Reflection;
            using System.Runtime.Serialization;
            using System.Text.RegularExpressions;
            using System.Text;
            using System;

            class Solution
            {
                public static void Main(string[] args)
                {        
                    int n = Convert.ToInt32(Console.ReadLine().Trim());
        
                    List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

                    int length = arr.Count;
        
                    for(int i = length - 1; i >= 0; i--) 
                    {
                        if (i != 0) 
                        {
                            Console.Write(arr[i] + " ");
                        } 
                        else 
                        {
                            Console.Write(arr[i]);
                        }
                    }
                }
            }
             */
        }
    }
}

