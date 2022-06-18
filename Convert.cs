class convert
{
    public static void Main()
    {
        int[][] myJag = new int[5][]; //Create a new jagged array with 5 sub arrays

        myJag[0] = new int[4] { 1, 23, 104, 7 }; //Intialise first sub array with 4 values
        myJag[1] = new int[5] { 1, 23, 104, 7, 6 };
        myJag[2] = new int[6] { 1, 23, 104, 7, 6, 8 };
        myJag[3] = new int[3] { 1, 23, 104 };
        myJag[4] = new int[2] { 1, 23 }; //Intialise last (5th) sub array with 2 values

        int[] results = new int[5]; //Declare new array with 5 values

        for (int i = 0; i < myJag.Length; i++) //Looping through myJag array
        {
            Array.Sort(myJag[i]); //Sorts sub array into smallest to largest number
            Array.Reverse(myJag[i]); //Now reverses sub array so largest number is first
            results[i] = myJag[i][0]; //For every sub array [i], take first value [0]
            Console.Write(results[i] + " "); //Print new array
        }
    }
}