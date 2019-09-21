//Programmer: Yagna Dheepika Venkitasamy
//Course: ISM6225 -DIS
//Assignment: Assignment 1

using System;
using System.Linq;
using System.Collections.Generic;

namespace Assignmen1_Venkitasamy
{
    class Program
    {
        public static void Main()
        {
            //Gather user input to calculate results
            Console.WriteLine("Hi! Choose from the following operations: " +
                "\n 1: Self Dividing Numbers" +
                "\n 2: Print Number Series" +
                "\n 3: Print Inverted Star Triange" +
                "\n 4: Print Jewels in Stones " +
                "\n 5: Print Largest Common SubArray" +
                "\n 6: Print the puzzle solution" +
                "\n 7: Exit");

            int userSelection = Convert.ToInt32(Console.ReadLine());
            //Convert the user input to integer value

            //Using try block to validate the user input 
            try
            {
                //Using if statement to validate user input between 1-7
                if ((userSelection > 0) && (userSelection < 8))

                    //Using Switch - case condition to categorize the operations 
                    switch (userSelection)
                    {
                        //Self dividing nos case
                        case 1:
                            //Displaying the user choice
                            Console.WriteLine("You have chosen to print self dividing numbers");

                            string X_input = "1"; //Gathering user input
                            int X = int.Parse(X_input);//Converting user input

                            string Y_input = "22";//Gathering user input
                            int Y = int.Parse(Y_input);//Converting user input

                            printSelfDividingNos(X, Y); //Calls the void method to execute the calculation
                            break;

                        //Get the series value case
                        case 2:
                            //Displaying the user choice
                            Console.WriteLine("You have chosen to print the number series for 5");
                            int n = 5;

                            PrintSeries(n);//Calling the return method to calculate the series value of N
                            break;

                        //Printing inverted triangle case
                        case 3:

                            //Displaying the user choice
                            Console.WriteLine("You have chosen to print triange for 5 rows");

                            int k = 5;

                            printTriange(k);//Calls the method to display the inverted triangle for selected rows
                            break;

                        //Binary to decimal conversion case
                        case 4:
                            //Displaying the user choice
                            Console.WriteLine("You have chosen to print the number of Jewels in the Stones");
                            int[] J = new int[] { 1, 3 };
                            int[] S = new int[] { 1, 3, 3, 2, 2, 2, 2, 2 };
                            numJewelsInStones(J, S);//Calls the return method to resulting array
                            break;

                        //Print star traingle case
                        case 5:
                            //Displaying the user choice
                            Console.WriteLine("You have chosen to print Largest common subarray");
                            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                            int[] arr2 = { 1, 2, 5, 7, 8, 9 };
                            int[] r5 = getLargestCommonSubArray(arr1, arr2);
                            displayArray(r5);

                            break;


                        //Solving Puzzle case
                        case 6:
                            //Displaying the user choice
                            Console.WriteLine("You have chosen to solve the puzzle!");
                            Console.WriteLine("Puzzle not solved yet!!");

                            break;

                        //Exit program
                        case 7:

                            Console.WriteLine("Now exiting the console..!");//Display the exit message
                            break;

                        //Default message incase user does not select valid option
                        default:

                            Console.WriteLine("Please enter valid integers only next time..");
                            break;
                    }//End of switch

                //To freeze user selection in the console
                Console.WriteLine("\nPress any key to exit the program ...");
                Console.ReadKey(true);

            }//End of try block

            //Using catch block to display message in case of bad user input
            catch
            {
                Console.WriteLine("Please input valid integers only..");
                Console.WriteLine("\nPress any key to exit the program ...");
                Console.ReadKey(true);
            }//End of catch block

        }//End of Main


        //Print self dividing number case method
        private static void printSelfDividingNos(int X, int Y)
        {
            string result = "";//Declare the variable to print the result

            //Using try block to catch any exceptions in the execusion
            try
            {
                //Checking if the lower number range is smaller than the upper range
                if (X > Y)
                {
                    Console.WriteLine("Pls input values of the number range X > Y");
                    //Displays an error message if its not
                }

                //works if X < Y
                else
                {
                    //for loop to check the number is self dividing 
                    for (int i = X; i <= Y; i++)
                    {
                        IsSelfDividing(i);

                        //If condition to get the result of the loop
                        if (IsSelfDividing(i))
                        {
                            result += i.ToString() + ", ";

                        }
                    }
                    //prints the final resulting array of self dividing numbers in the selected number range
                    Console.WriteLine(result);
                }//End of else

            }//End of the try block to validate user input

            //Using catch block to show error message for bad input
            catch
            {
                Console.WriteLine("Exception occured while computing Self Dividing Numbers");
                Console.WriteLine("\nPress any key to exit the program ...");
                Console.ReadKey(true);
            } //End of catch block

        } //End of the method printSelfDividingNos

        //Using a boolean method to find out if the number is self dividing
        private static bool IsSelfDividing(int n)
        {
            //Converting the string array to number and then in turn to single digit array for dividing the number with each of its own
            string[] intList = n.ToString().Select(digit => digit.ToString()).ToArray<string>();

            //Excluding numbers that contains 0 in it
            if (intList.Contains("0"))
            {
                //Console.WriteLine("Contains 0");
                return false;
            }
            //Using for loop to run the iteration for checking the self dividing method
            for (int i = 0; i < intList.Length; i++)
            {
                if (n % int.Parse(intList[i]) != 0)
                {
                    return false;//returns false if the number is not self dividing
                }
            }
            return true; // returns tru if the number is indeed self dividing
        }


        //Method to print series for N
        private static double PrintSeries(int n)
        {
            //Using the try block to validate user input
            try
            {
                //Using for loop to iterate the statement
                for (int i = 1; i <= n; i++)
                {
                    //Using nested for loop for the iteration of numbers
                    for (int k = 1; k <= i; k++)
                    {
                        if (k > 1)
                            Console.Write(",");
                        Console.Write(i);
                    }

                    Console.Write(",");
                }
            }//End of try block
            //Using catch block to show error message for bad input
            catch
            {
                Console.WriteLine("Exception occured while computing print series method");
                Console.WriteLine("\nPress any key to exit the program ...");
                Console.ReadKey(true);

            } //End of catch block

            return n;// its a return method!

        }//End of the print series method

        //Calls the method to print reverse trainagle
        private static void printTriange(int n)
        {
            //Using the try block to validate user input
            try
            {
                //Using for loop to iterate the star using * and spaces
                for (int i = n; i > 0; i--)
                {
                    for (int j = n - i; j > 0; j--)
                    {
                        Console.Write(" ");
                    }
                    for (int j = (2 * i) - 1; j > 0; j--)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                }

            }//End of try block
            //Using catch block to show error message for bad input
            catch
            {
                Console.WriteLine("Exception occured while print triangle method");
                Console.WriteLine("\nPress any key to exit the program ...");
                Console.ReadKey(true);
            }

        }//End of Print Traiangle method

        //Method to count no of jewels in stones
        public static int numJewelsInStones(int[] J, int[] S)
        {
            //Using the try block to validate user input
            try
            {
                int count = 0; //declare an int variable to store the result

                //use foreach loop to check if the jewel is available in stone array
                foreach (int v in S)
                    //using if condition to check if j is in S
                    if (J.Contains(v))
                    {
                        count++;//increment 1 if its there
                    }
                    else;// do nothing if its not there

                Console.WriteLine(count);//display the resulting count

            }//End of try block
            //Using catch block to show error message for bad input
            catch
            {
                Console.WriteLine("Exception occured while computing numJewelsInStones()");
                Console.WriteLine("\nPress any key to exit the program ...");
                Console.ReadKey(true);
            }//End of catch

            return 0;// its a return method!!

        } //End of numJewelsInStones Method

        //Method to get the largest common sub array
        private static int[] getLargestCommonSubArray(int[] arr1, int[] arr2)
        {

            //Using the try block to validate user input
            try
            {
                List<int> temp_arr = new List<int>();
                List<int> result = new List<int>();
                if (arr1.Length < 1 || arr2.Length < 1)
                {
                    return new int[0];
                }
                else
                {
                    for (int i = 0; i < arr1.Length; i++)
                    {
                        int num = arr1[i];
                        Boolean foundMatch = false;
                        for (int j = 0; j < arr2.Length; j++)
                        {
                            if (num == arr2[j])
                            {
                                foundMatch = true;
                                temp_arr.Add(num);
                                break;
                            }

                        }
                        if (!foundMatch || i == arr1.Length - 1)
                        {
                            if (temp_arr.Count() >= result.Count())
                            {
                                result = new List<int>(temp_arr);

                                temp_arr = new List<int>();
                            }
                            else
                            {
                                temp_arr = new List<int>();
                            }
                        }
                    }
                    return result.ToArray();
                }

            }//End of try block
             //Using catch block to show error message for bad input
            catch
            {
                Console.WriteLine("Exception occured while computing largest common subarray");
                Console.WriteLine("\nPress any key to exit the program ...");
                Console.ReadKey(true);
            }//End of catch block

            return null;

        }//End of the get largest common sub array

        //Method to display the final array 
        public static void displayArray(int[] final_arr)
        {
            //Using try block to validate the logic
            try
            {
                //For loop to iterate the digits of the array
                for (int i = 0; i < final_arr.Length; i++)
                {
                    Console.Write(final_arr[i] + ", ");

                }
            }//End of try block
            //Using catch block to catch the exception
            catch
            {
                Console.WriteLine("Exception occured while computing Display array");
                Console.WriteLine("\nPress any key to exit the program ...");
                Console.ReadKey(true);

            }//End of catch block
        }//End of display array method


    }//End of Class
} //End of namespace

/*Self-reflections: The last problem of solving the "UBER COOL UNCLE" was unclear to solve. 
 * Working on this assignment helped me in gathering knowlege about coding with the basic C# functions and fondation of coding . 
 */
