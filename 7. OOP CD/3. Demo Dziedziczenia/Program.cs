namespace _3._Demo_Dziedziczenia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Witaj Swiecie", "xProsek", true);
            Console.WriteLine(post1);

            post1.Update("Witaj Świecie!", true);
            Console.WriteLine(post1);

            Post post2 = new Post("Testowy", "xProsek", false);
            Console.WriteLine(post2);

            ImagePost imgPost1 = new ImagePost("test1", "xProsek", true, "https://imgur.com/rand0m");
            Console.WriteLine(imgPost1);
            //Console.WriteLine(imgPost1.ReturnLink());

            VideoPost vidPost1 = new VideoPost("test1", "xProsek", true, "https://youtube.com/w/rnd0m", 12);
            Console.WriteLine(vidPost1);

            vidPost1.Play();
            Console.WriteLine("Press any key to stop the video...");
            Console.ReadKey();
            vidPost1.Stop();

        }
    }
}