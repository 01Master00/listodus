namespace listodus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in PrimSzamok(2, 10))
            {
                Console.WriteLine(item);
            }


        }
        static List<int> PrimSzamok(int kezdo, int veg)
        {
            List<int> prim = new List<int>();
            for (int i = kezdo; i < veg; i++)
            {
                if (Prima(i)) 
                    prim.Add(i);
            }
            return prim;
        }

        static bool Prima(int szam)
        {
            if (szam < 2)
                return false;
            for (int i = 2; i < szam; i++)
            {
                if (szam%i == 0)
                    return false;
            } 
            return true;
        }   

    }

}
