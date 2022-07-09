int N = Convert.ToInt32(Console.ReadLine());
int negativeN = N * (-1);
while (negativeN <= N)
{
    Console.WriteLine(negativeN);
    negativeN = negativeN + 1;
}