int[,] arr = new int[5, 5];
Random rand = new Random();
for (int i = 0; i < 5; i++)
{
	for (int j = 0; j < 5; j++)
	{
		arr[i, j] = rand.Next(-100, 101);
	}
}
for (int i = 0; i < 5; i++)
{
	for (int j = 0; j < 5; j++)
	{
		Console.Write(arr[i, j]);
	}
	Console.WriteLine();
}
int min = arr[0, 0];
int max = arr[0, 0];
int sum = 0;
bool numsMinMax = false;
foreach (var num in arr)
{
    if (num < min)
    {
        min = num;
    }
    if (num > max)
    {
        max = num;
    }
}
for (int i = 0; i < 5; i++)
{
	for (int j = 0; j < 5; j++)
	{
		if (arr[i, j] == min || arr[i, j] == max)
		{
			numsMinMax = !numsMinMax;
		}
		if (numsMinMax == true)
		{
			sum += arr[i, j];
		}
	}
}