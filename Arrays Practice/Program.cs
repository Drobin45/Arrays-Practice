using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //First attempt at setting up simple arrays

            //int[] myFirstArray;

            //string[] myStringArray = { "First", "Second", "Third", "Fourth" };

            //// getting the console to print out specific elements of your array
            //char[] lastName = { 'r', 'o', 'b', 'i', 'n', 's', 'o', 'n' };

            //    Console.WriteLine(lastName[2]);
            //    Console.WriteLine(lastName[0]);
            //    Console.WriteLine(lastName[1]);

            //-------------------------------------------------------------------------------

            //Create the following arrays and print using the correct index numbers. 
            //Array of top 10 Vacation spots
            //Print the first and last vacation spots
            //Array of ages of 3 children you know
            //Print each child's age
            //Array of GPA's on a 4.0 scale of 8 students - you don't have to print
            //Array of the first letter of 4 of your classmate's names who are sitting near you
            //Print all four on the same line.

            //string[] vacation = { "The Vatacin", "India", "Australia", "Volcanoes?", "Europe", "Alabama", "Mexico", "Iceland", "New Zealand", "Ohio" };
            //Console.WriteLine(vacation[0]);
            //Console.WriteLine(vacation[9]);

            //int[] childAges = { 3, 5, 7 };
            //Console.WriteLine(childAges[0]);
            //Console.WriteLine(childAges[1]);
            //Console.WriteLine(childAges[2]);
            //Console.WriteLine(childAges[0] + " " + childAges[1] + " " + childAges[2]);

            //double[] gpa = { 1.0, 1.5, 2.0, 2.5, 3.0, 3.5, 3.75, 4.0 };

            //char[] cohortNames = { 'T', 'R', 'J', 'F' };

            //// With char variables, you can print the entire set of elements on one line by doing the following.

            //Console.WriteLine(cohortNames);

            ////For strings and int, you have to do something like this to get them all on one line.

            //Console.Write(cohortNames[0] + " ");
            //Console.Write(cohortNames[1] + " ");
            //Console.Write(cohortNames[2] + " ");
            //Console.Write(cohortNames[3] + "\n");

            ////The below can take elements from DIFFERENT ARRAYS and put them on the same line together. Useful!

            //Console.WriteLine("{0}, {1}, {2}, {3}", cohortNames[0], cohortNames[1], cohortNames[2], cohortNames[3]);

            //---------------------------------------------------------------------

            // This creates arrays without already putting in the elements. Both of these are ready for 21 elements each.
            // dataType[] nameOfArray = dataType[#ofElements];

            //int[] numberOfSeats = new int[21];
            //string[] seats = new string[21];

            //// To "Fill out" your array with elements, this form of line can fill it out.
            ////nameOfArray[index] = Element;
            //seats[0] = "Jordan";

            ////Allows user to fill out elements
            //Console.WriteLine("Please enter in the name of the next student");
            //seats[1] = Console.ReadLine();
            //Console.WriteLine("The student in the second seat is {0}", seats[1]);

            //Console.WriteLine("Please enter the age of the person in the second seat.");
            //int[] studentAge = new int[21];
            //studentAge[1] = int.Parse(Console.ReadLine());

            // One way of having user write in an element
            //Console.WriteLine("The age of the student in the first seat is " + studentAge[0]);

            //Assign the value of the int at the 0 index of studentAge to the usre's input converted into an int

            //studentAge[0] = int.Parse(Console.ReadLine());

            ////Create a new string variable and set it equal to the int at the index of 0 ...
            //// and convert it into a string!

            //string firstIndex = studentAge[0].ToString();

            //--------------------------------------------------------------------------------

            //string[] restaurantsInMall = { "Subway", "Saki", "Dunkin Donus", "Red Lobster", "Chick-Fil-A" };
            //Console.WriteLine(restaurantsInMall.Length);

            //// For review
            ////Declaring without intializing
            //int[] myIntArrayAgain;

            ////Declare and intitialize an array when I know the elements
            //char[] lettersInFirstName = { 'D', 'a', 'n', 'i', 'e', 'l' };

            ////Declare and initialize an array when I don't know the elements but I know how many there will be

            //string[] variableName = new string[42];

            //To practice using .Length, create a char array of the letters in your middle name ...
            //... and print the number of char's to the Console. 

            //char[] middleName = { 'B', 'l', 'a', 'k', 'e' };
            //Console.WriteLine(middleName.Length);

            //Declare and initialize a string array.
            //Using the length property print the second to last element in the array

            //string[] restaurantsInMall = { "Subway", "Saki", "Dunkin Donus", "Red Lobster", "Chick-Fil-A" };
            //Console.WriteLine(restaurantsInMall.Length);
            //int numRest = restaurantsInMall.Length;
            //Console.WriteLine(restaurantsInMall[numRest - 2]);

            // Alaternatively you could write the following as the final line of this program. It's "cleaner".
            //Console.Writeline(restaurantsInMall[restaurantsInMall.Length - 2]);

            //IndexOf is a method used to search an array for a specified value and returns...
            //... the index position of the first matching value found.

            //int[] bestYearsEver = { 1985, 1999, 1991, 2000, 1985 };
            //Console.WriteLine(Array.IndexOf(bestYearsEver, 1985));

            ////LastIndexOf is a method used to search an array for a specified value and returns....
            ////the index position of the last matching value found.

            //Console.WriteLine(Array.LastIndexOf(bestYearsEver, 1985));

            //Reverse Method
            //int[] palindromeNumbers = { 1, 2, 3, 4, 5, 6, 7 };
            //Console.WriteLine(palindromeNumbers[0]);
            //Array.Reverse(palindromeNumbers);
            //Console.WriteLine(palindromeNumbers[0]);

            //Sort
            //Will sort numbers in an array from lowest to highest
            //Will sort char's and strings in alphabetical ordre from A-Z. p.s.- Lowercase goes first
            //string[] powerRangers = { "Green", "Yellow", "Pink", "Blue", "Red", "Black" };
            //Console.WriteLine(powerRangers[0]);
            //Array.Sort(powerRangers);
            //Console.WriteLine(powerRangers[0]);

            // Declare and initialize a string array of first names. Choose a name to find and print the IndexOf.
            //Complete!

            string[] names = { "Daniel", "Linda", "Emily", "Aaron" };
            Console.WriteLine(Array.IndexOf(names, "Daniel"));

            //Create an array of lucky numbers. Each number should repeat at least once....
            //....Choose a lucky number, find and print the last index of it.
            //Complete!

            int[] numbers = { 1, 3, 5, 7, 1, 3, 5, 7};
            Console.WriteLine(Array.LastIndexOf(numbers, 7));

            //Create an array of alphabet characters. Print the first index of the array....
            //....Now reverse the array and print the first index.
            //Complete!

            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
            Console.WriteLine(vowels[0]);
            Array.Reverse(vowels);
            Console.WriteLine(vowels[0]);

            //Create an array of student names in random order...
            //...Order the students’ names using the sort method. Print the first and last students’ names.
            //Complete!

            string[] cohortNames = { "Daniel", "Rebeca", "Tiffany", "Jessica", "Sam" };
            Array.Sort(cohortNames);
            Console.WriteLine(cohortNames[4]);

            //Ask 10 people for their favorite numbers and create an array of those numbers...
            //...Order the numbers using the sort method. Print the first and last numbers.
            //Complete!

            int[] favNumbers = { 11, 92, 33, 84, 53, 66, 67, 78, 19, 10 };
            Array.Sort(favNumbers);
            Console.WriteLine(favNumbers[9]);

            

            












        }
    }
}
