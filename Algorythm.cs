namespace TestApp
{
    class Algorythm
    {
        public static int CountResult(int h, double w, double b)
        {
            double temp = h;
            int result = 0;
            if(b == 0 || b == 1 || h <= w)
            {
                result = -1;
                return result;
            }
            else
            {
                do
                {
                    if (temp == h && temp > w)
                    {
                        result++;
                        temp *= b;
                    }
                    else
                    {
                        result += 2;
                        temp *= b;
                    }

                } while (temp >= w);

                return result;
            } 
        }
    }
}
