public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // David Comments:
        // Step 1: Create an new empty array of doubles (double[]) with the specified length (new double[length]) declared by length parameter .
        // This will be the array that we will fill with the multiples of the number and return at the end of the function.

        double[] multiplesArray = new double[length];

        // Step 2: Use a for loop to iterate from 0 to length - 1.
        for ( int indexOfTheMultiplesArray = 0; indexOfTheMultiplesArray < length; indexOfTheMultiplesArray++)
        

        // Step 3: Inside the for loop, calculate the multiple of the number by multiplying the number by (i + 1) where i is the current index of the loop. 
        //Remember that arrays are zero-indexed, so the first index is 0, but we want to start with the first multiple which is number 1, that is the reason why we use (i + 1)
        // This is because we want to start with the first multiple (number*1) and go up to (number*length).
        // then store the result in the array we created on the step 1 at the current index (i).

        {
           var multiple = number * (indexOfTheMultiplesArray + 1);
           multiplesArray[indexOfTheMultiplesArray] = multiple;
        }
        

        // Step 4: After the for loop is complete, return the array that we filled with the multiples of the number.


        return multiplesArray; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // David Comments:
        // Step 1: Create a new list to store the right rotated values. 
        // We will get these values using GetRange, starting from (data.Count - amount) up to the end.

        List<int> rightRotateValues = data.GetRange(data.Count - amount, amount);

        // Step 2: Create another list that will store the left static values. 
        // We will get these values using GetRange, starting from index 0 with a size of (data.Count - amount).  
        List<int> LeftStaticValues = data.GetRange(0, data.Count - amount);
        
        // Step 3: Clean the original list using Clear() to prepare it for the new values.
        data.Clear();

        // Step 4: Add the right rotated values to the original list using AddRange.
        data.AddRange(rightRotateValues);
        

        // Step 5: Add the left static values to the original list using AddRange so they go to the back.
        data.AddRange(LeftStaticValues);


    }
    
}
