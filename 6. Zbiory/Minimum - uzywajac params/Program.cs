namespace Minimum___uzywajac_params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Lista: {(-2, 14, 13, 12, 1, 2)}");
            Console.WriteLine($"Minimum z tej listy: {Minimum(-2,14,13,12,1,2)}");
            Console.WriteLine($"Lista: {(15, 14, 13, 12, 2, 1)}");
            Console.WriteLine($"Minimum z tej listy: {Minimum(15, 14, 13, 12, 2, 1)}");
            Console.WriteLine($"Lista: {(1)}");
            Console.WriteLine($"Minimum z tej listy: {Minimum(1)}");

            Console.WriteLine($"Lista: {(1.2, 1.4, 1.0923982389, 0.5784355438, 0.521652)}");
            Console.WriteLine($"Minimum z tej listy: {Minimum(1.2, 1.4, 1.0923982389, 0.5784355438, 0.521652)}");

            Console.ReadLine();
        }


        public static int Minimum(params int[] args) 
        {
            int min = args[0];
            if (args.Length == 0) min = int.MaxValue;
            for (int i = 1; i < args.Length; i++) 
            {
                if (args[i] < min) min = args[i];
            }
            return min;
        }
        public static double Minimum(params double[] args)
        {
            double min = args[0];
            if (args.Length == 0) min = double.MaxValue;
            for (int i = 1; i < args.Length; i++)
            {
                if (args[i] < min) min = args[i];
            }
            return min;
        }
        public static float Minimum(params float[] args)
        {
            float min = args[0];
            if (args.Length == 0) min = float.MaxValue;
            for (int i = 1; i < args.Length; i++)
            {
                if (args[i] < min) min = args[i];
            }
            return min;
        }
        public static long Minimum(params long[] args)
        {
            long min = args[0];
            if (args.Length == 0) min = long.MaxValue;
            for (int i = 1; i < args.Length; i++)
            {
                if (args[i] < min) min = args[i];
            }
            return min;
        }
        public static short Minimum(params short[] args)
        {
            short min = args[0];
            if (args.Length == 0) min = short.MaxValue;
            for (int i = 1; i < args.Length; i++)
            {
                if (args[i] < min) min = args[i];
            }
            return min;
        }
        public static sbyte Minimum(params sbyte[] args)
        {
            sbyte min = args[0];
            if (args.Length == 0) min = sbyte.MaxValue;
            for (int i = 1; i < args.Length; i++)
            {
                if (args[i] < min) min = args[i];
            }
            return min;
        }
        //I tak dalej...
        //Starczy haha
    }
}