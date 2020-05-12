namespace part1
{
    public class LuckyNumbers
    {
        public int Calculate(int a, int b)
        {
            int[] one = new int[2];
            a[0] = 3;
            a[1] = 7;

            ll i = 0;
            ll pos = 2;
            while (1)
            {
                ll x = a[i] * 10 + 3;
                ll y = a[i] * 10 + 7;
                a[pos++] = x;
                a[pos++] = y;
                i++;
                if (x >= 1000000000) break; 
            }

        }
    }
}