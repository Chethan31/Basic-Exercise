
int min;
int[] arr=new int[5];
Console.Write($"Enter the array values:");
for (int i=0; i<arr.Length; i++)
{
    arr[i]=int.Parse(Console.ReadLine());   
}
min = arr[0];
foreach (int i in arr)
{
    if(min>i)
    {
        min = i;
    }
}
Console.WriteLine($"The minimum value in array:{min}");