using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCCIweek3ArraysTextPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //arrays are collections of variables called elements

            int[] myArray; //declares an array
            
            int[] myArray2 = { 1, 2, 3, 4, 5, 6}; //initializes array with initial values
            string[] daysOfWeek = { "sun", "mon", "tues", "wed", "thurs", "fri", "sat" }; //another example

            myArray = new int[6]; //creates the array. 6 in length.
            myArray[2] = 2;
            myArray[5] = 5;
            myArray[0] = 0;
            //those last two lines set values to the elements in the 3rd and 6th spots, respectively
            //remember first element is at index 0.

            Console.WriteLine($"slot 3 = {myArray[2]}. slot 6 = {myArray[5]}. slot 1 = 0.");

            //reverse an array. use daysOfWeek, above.
            //first time loops each element, prints normal
            //second time prints in reverse

            int length = daysOfWeek.Length;

            string[] weekReversed = new string[length];

            for (int index = 0; index < length; index++)
            {
                Console.WriteLine(daysOfWeek[index] + " ");
            }

            //this part is like: 7-0-1 = 6. so first new element [0] is last old element [6]
            //next: 7-1-1 = 5. so old [5] is new [1]
            for (int index = 0; index < length; index++)
            {
                weekReversed[length - index - 1] = daysOfWeek[index];
            }

            for (int index = 0; index < length; index++)
            {
                Console.WriteLine(weekReversed[index] + " ");
            }

            //let's get array elements from the user

            Console.WriteLine("How many children do you have?");
            int numKids = int.Parse(Console.ReadLine());

            int[] kidAges = new int[numKids];

            for (int i = 0; i < numKids; i++)
            {
                Console.WriteLine("How old is the first child?");
                kidAges[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numKids; i++)
            {
                Console.WriteLine(kidAges[i] + " ");
            }

            //to better print to screen:

            for (int i = 0; i < kidAges.Length; i++)
            {
                Console.WriteLine($"Child # {i+1} is {kidAges[i]}.");
            }

            //manipulating an array:
            //multiply everything by 2, using myArray2, above

            Console.WriteLine("Output: ");

            for (int i = 0; i < myArray2.Length; i++)
            {
                Console.WriteLine(myArray2[i] + " ");
            }

            Console.WriteLine("Output * 2: "); 

            for (int i = 0; i < myArray2.Length; i++)
            {
                myArray2[i] = 2 * myArray2[i];
                Console.WriteLine(myArray2[i] + " ");
            }

            //now let's square the values:

            Console.WriteLine("Output squared: ");

            for (int i= 0; i < myArray2.Length; i++)
            {
                myArray2[i] = myArray2[i] * myArray2[i];
                Console.WriteLine(myArray2[i] + " ");
            }

            //iteration with foreach loop: SO EASY

            string[] capitals = { "Sophia", "DC", "London", "Paris" };

            foreach (string capital in capitals)
                //VS understands that "captial" means each element in capitals
            {
                Console.WriteLine(capital);
            }

            Console.ReadLine();
        }
    }
}
