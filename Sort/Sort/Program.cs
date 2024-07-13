// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
keyValuePairs.Add(4, 0);
keyValuePairs[4]++;
keyValuePairs[4] = keyValuePairs[4] + 1;
keyValuePairs.Add(5,1);
foreach(KeyValuePair<int, int> pair in keyValuePairs)
{
    if (pair.Value == 0) { Console.WriteLine(pair.Key); }
    if (pair.Value == 1) { Console.WriteLine(pair.Key); }
}
int[] input = new int[] {1,4,5,2,8,9 };
Sort(input);
int searchResult = binarySearch(new int[] { 4, 7, 10, 2, 6, 5, 9 }, 5);

void Sort(int[] array)
{
    int[] helper = new int[array.Length];
    MergeSort(array, helper, 0, array.Length - 1);

}
/// <summary>
/// Time Complexity O(n log n)
/// Space Complexity O(n)
/// </summary>
void MergeSort(int[] array, int[] helper, int low, int high )
{
    if (low < high)
    {
        int middle = low + (high - low) / 2;
        MergeSort(array, helper, low, middle);
        MergeSort(array, helper, middle + 1, high);
        merge(array, helper, low, middle, high); 
    }
 }

void merge(int[] array, int[] helper, int low, int middle, int high)
{
    for (int i = low; i<=high; i++)
    {
        helper[i] = array[i]; 
    }

    int helperLeft = low;
    int helperRight = middle + 1;
    int current = low;

    while (helperLeft <= middle && helperRight <= high)
    {
        if(helper[helperLeft]<=helper[helperRight])
        {
            array[current] = helper[helperLeft];
            helperLeft++;
        }
        else
        {
            array[current] = helper[helperRight];
            helperRight++;
        }
        current++;
    }

    int remaining = middle - helperLeft;
    for (int i=0; i<remaining; i++)
    {
        array[current+i] = helper[helperLeft+i];
    }

}
/// <summary>
/// Find x in input[] array
/// Time Complexity O (log n)
/// </summary>
int binarySearch(int [] input, int x) //only works for sorted array
{
    int low = 0;
    int high=input.Length-1;
    int middle;
    while (low <= high)
    {
        middle=low + (high-low)/2;
        if (input[middle] < x)
        {
            low= middle+1;
        }
        else if (input[middle] > x)
        {
            high = middle - 1;
        }
        else 
            return middle;
    }

    return -1;
}
