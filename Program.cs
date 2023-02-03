Console.Write("Enter num1: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter num2: ");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter num3: ");
double num3 = Convert.ToDouble(Console.ReadLine());

//2 args
Console.WriteLine("Min of num1 and num2 is: " + Kean_ID_Funcs.Class1.Min(num1, num2));

//3 args
Console.WriteLine("Min of all nums is: " + Kean_ID_Funcs.Class1.Min(num1, num2, num3));
