
int size = 5;
int[] A = new int[size];
for (int i = 0; i < size; i++)
{
    A[i] = Convert.ToInt32(Console.ReadLine());
}
foreach (var num in A)
{
    Console.Write($"{num} ");
}
int min = A[0];
int max = A[0];
int sum = 0;
int dob = 1;
int sumeven = 0;
foreach (var num in A)
{
    if (num < min)
    {
        min = num;
    }
    if (num > max)
    {
        max = num;
    }
    sum += num;
    dob *= num;
    if (num % 2 ==0)
    {
        sumeven += num;
    }
}
///////////////////////////////////////////
int row = 3;
int col = 4;
int[,] B = new int[row, col];
Random random = new Random();
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
    {
        B[i, j] = random.Next(1, 100);
    }
}
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
    {
        Console.Write($"{B[i, j]} ");
    }
    Console.WriteLine();
}
int min1 = B[0, 0];
int max1 = B[0, 0];
int sum1 = 0;
int dob1 = 1;
int sumodd = 0;
foreach (var num in B)
{
    if (num < min1)
    {
        min1 = num;
    }
    if (num > max1)
    {
        max1 = num;
    }
    sum1 += num;
    dob1 *= num;
    if (num % 2 != 0)
    {
        sumodd += num;
    }
}



