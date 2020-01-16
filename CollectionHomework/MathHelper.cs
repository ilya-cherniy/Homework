namespace CollectionHomework
{
    class MathHelper
    {
        public static bool IsSimple(int n)
        {
            if (n < 2)
                return false;
            for (int i = 2; i <= (int)(n / 2); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}
