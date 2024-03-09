int T, sum;
int[] arr2 = new int[11];

T = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < T; i++)
{
    string str = Console.ReadLine();
    sum = 0;
    var arr = str.Split(" ");
    int x = Convert.ToInt32(arr[0]);
    int y = Convert.ToInt32(arr[1]);
    int mn = Math.Min(x, y);
    int mx = Math.Max(x, y);
    for (int j = mn + 1; j < mx; j++)
    {
        if (j % 2 != 0)
        {
            sum += j;
        }
    }
    arr2[i] = sum;
}

for (int i = 0; i < T; i++)
{
    Console.WriteLine(arr2[i]);
}
