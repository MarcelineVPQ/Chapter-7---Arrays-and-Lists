using System;

namespace Chapter_7___Arrays_and_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayIntroduction();
            //DeclaringInitializingArrays();
            //ForEachLoopArrays();
            //ForEachLoopChallenge();
            MultiDimensionalArrays();
            Console.Read();
        }
        static void ArrayIntroduction()
        {
            /*  Video 69 - Basics of Arrays
             *  
             *  **Array Theory**
             *  
             *  -Stores a fixed size of sequential collection of elements of the same type
             *  -Again, ONLY THE SAME TYPE
             *  -Can Create Arrays of different types: int,string,object,etc.
             *  -Great to store a collection of data - easier to think of a collection of variables of the same type
             *    stored at a contiguous memory locations
             *   
             *  **Structure of an Array**
             *      values:    13  15  5   7   8   1    < Values is looked up by the index
             *      indexes:   0   1   2   3   4   5    < Always starts with 0 and increases by one
             *  
             *  **Declaring an array**
             *  
             *      dataType[] arrayName;
             *      ex: int[] grades;
             *  
             *  **Initializing an Array**
             * 
             *      dataType[] arrayName = new dataType[amountOfEntries];
             *      ex: int[] grades = new int[5];
             * 
             *  **ASigning values to an array**
             *  
             *      arrayName[index] = value;
             *      ex: grades[0] = 15;
             *      ex: grades[1] = 12;
             *      
             *      our structure would look like:
             *      values:    15  12
             *      index:      0   1 
             */

        }
        static void DeclaringInitializingArrays()
        {
            //Initialize the array
            int[] grades = new int[5];

            //fill the array with values
            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 12;
            grades[3] = 19;
            grades[4] = 7;

            Console.WriteLine("grades at index 0: {0}", grades[0]);


            //this is how to change the value
            string input = Console.ReadLine();

            //assign value to array grades at index 0
            grades[0] = int.Parse(input);

            Console.WriteLine("grades at index 0: {0}", grades[0]);

            //another way of initializing an array
            int[] gradesOfMathStudentsA = { 20, 13, 12, 8, 8 };

            //and yet another other way of initializing an array
            int[] gradesOfMAthStudentsB = new int[] { 15, 20, 3, 17, 18, 15 };

            Console.WriteLine("Length of A Math Studs. Array: {0}", gradesOfMathStudentsA.Length);

        }
        static void ForEachLoopArrays()
        {
            int[] nums = new int[10];

            
            
            /*this is the most classic for loop in arrays this is what we are saying;
             *  0 -> 0 , or at index zero we are assigning a value of zero then,
             *  1 -> 1 , or at index one we are assigning a value of one. Continue's until value reaches 9
             * 
             * 
             */
            for(int i = 0; i < 10; i++)
            {
                nums[i] = i + 10;
            }

            //to avoid out of bounds don't use this:
            //for(int j = 0; j <  10; j++)
            for (int j = 0; j <  nums.Length; j++)
            {
                Console.WriteLine("Element{0} = {1}",j,nums[j]);
            }

            //an alternative is a for each loop

            int counter = 0;
            foreach(int k in nums)
            {
                Console.WriteLine("Element{0} = {1}", counter, k);
                counter++;
            }


            //Challenge create an array with 5 of your best friends
            //create a for each loop which greets all of them


           

        }
        static void ForEachLoopChallenge()
        {
            //Video 71
            string[] friends = new string[5];

            friends[0] = "Meryl";
            friends[1] = "Sigourney";
            friends[2] = "Scarlett";
            friends[3] = "Sandra";
            friends[4] = "Natalie";
            int counter = 0;

            foreach(string i in friends)
            {
                Console.WriteLine("Hello {0}, how are you today?", i);
                counter++;
            }

        }
        static void MultiDimensionalArrays()
        {

        }
    }
}
