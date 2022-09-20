
static void Swap(ref double A, ref double B)
{
    double temp;
    temp = A;
    A = B;
    B = temp;
}
 
Console.WriteLine("User input A: ");
double A = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("User input B: ");
double B = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("User input C: ");
double C = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("A, B, C before changing: {0}, {1}, {2}", A, B, C);
Swap(ref A, ref C);
Swap(ref A, ref B);
Console.WriteLine("A, B, C after changing: {0}, {1}, {2}", A, B, C);


