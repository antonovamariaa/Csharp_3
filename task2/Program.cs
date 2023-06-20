int[] c1 = new int[3];
int[] c2 = new int[3];

System.Console.Write("input x1: ");
c1[0] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("input y1: ");
c1[1] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("input z1: ");
c1[2] = Convert.ToInt32(Console.ReadLine());

System.Console.Write("input x2: ");
c2[0] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("input y2: ");
c2[1] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("input z2: ");
c2[2] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Math.Round((Math.Sqrt(Math.Pow(c2[0] - c1[0], 2) + Math.Pow(c2[1] - c1[1], 2) + Math.Pow(c2[2] - c1[2], 2))), 2));