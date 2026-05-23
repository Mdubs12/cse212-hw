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
        // Step 1:
        // Create an array that can hold 'length' number of doubles
        double[] result = new double[length];

        // Step 2:
        // Loop through each position in the array
        for (int i = 0; i < length; i++)
    {
        // Step 3:
        // Store the multiple of 'number'
        // i + 1 is used because arrays start at 0
        result[i] = number * (i + 1);
    }

        // Step 4:
        // Return the completed array
        return result;
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
        // Step 1: loop through the list 'amount' of times
        for (int i = 0; i < amount; i++)
        {
            // Step 2:
            // Save the last item in the list
            int lastValue = data[data.Count - 1];

            // Step 3:
            // Remove the last item from the list
            data.RemoveAt(data.Count - 1);

            // Step 4:
            // Insert the saved value at the beginning
            data.Insert(0, lastValue);
        }
    }
}
