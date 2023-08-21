namespace _7._IEnumerable___wstep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CatShelter cs = new CatShelter();
            foreach (Cat cat in cs) 
            {
                Console.WriteLine(cat);
                if (!cat.IsABadCat)
                {
                    cat.FeedTheCat(2);
                }
                else
                {
                    cat.FeedTheCat(1);
                }
                Console.WriteLine();

            }
        }
    }
}