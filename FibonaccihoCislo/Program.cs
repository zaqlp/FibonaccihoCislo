
int t = 2;
List<int> fibonaccihocisla = new List<int>();
fibonaccihocisla.Add(1);
fibonaccihocisla.Add(1);
while (fibonaccihocisla[t-1] < 1000000)
{
    fibonaccihocisla.Add( fibonaccihocisla[t-1] + fibonaccihocisla[t-2]);
    t++;
}
foreach (int i in fibonaccihocisla)
{
    Console.WriteLine(i);
}
string vstup;
vstup = Console.ReadLine();
int f =0;
f = int.Parse(vstup);
List<int> Soucet = new List<int>();

while (f != 0)
{
    int s = 0;
    while (fibonaccihocisla[s] < f)
    {
        s++;
    }
    if (s == 0)
    {
        Soucet.Add(fibonaccihocisla[s]);
        f = f - fibonaccihocisla[s];
    }
    else
    {
        Soucet.Add(fibonaccihocisla[s - 1]);
        f = f - fibonaccihocisla[s - 1];
    }
    
}
foreach (int i in Soucet)
{
    Console.WriteLine(i);
}


