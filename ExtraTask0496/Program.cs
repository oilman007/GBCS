Console.Clear();

int asum(int i, int[] aval)
{
    int result = aval[i];
    result += i == 0 ?  aval[aval.Length-1] : aval[i-1];
    result += i == aval.Length-1 ?  aval[0] : aval[i+1];
    return result;
}

string[] lines = System.IO.File.ReadAllLines("input.txt");
int n = int.Parse( lines[0]);
string[] split = lines[1].Split();

int[] aval = new int[n];
for(int i=0; i< n; ++i)
    aval[i] = int.Parse( split[i]);

int max =0;
for(int i=0; i< n; ++i)
{
    int cur = asum(i, aval);
    if(max < cur)
        max = cur;
}

 File.WriteAllText("output.txt", max.ToString());