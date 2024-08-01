int n = 10;
int[] array = { 2, 24, 53, 2, 64, 74, 4, 7, 1, 11 };
int i = 0;
while(i < n)
{
    if(array[i] % 2 == 0)
    {
        System.Console.Write($"{array[i]} ");
    }
    i = i + 1;
}