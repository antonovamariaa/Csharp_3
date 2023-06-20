System.Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());


if (num > 0)
{
    int index = 1;
    double[] array = new double[num];
    while (index <= num)
    {
        array[index - 1] = Math.Pow(index, 3);
        index++;
    }
    System.Console.WriteLine(string.Join(", ", array));

}
else { System.Console.WriteLine("error"); }
