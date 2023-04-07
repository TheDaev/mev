namespace bdmse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = new string[100];

            int wh = Console.WindowHeight;

            for(int j = 0; j < wh; j++)
            {
                Console.WriteLine($"\x1b[{j};1H~");
            }

            Console.Write("\x1b[0;0H");


            for (int i = 0; i < text.Length; i++)
            {
                if (Console.ReadKey().Key != ConsoleKey.F1)
                {
                    text[i] = Console.ReadLine();
                }
                else
                {
                    File.WriteAllLines("testFile.txt", text);
                    return;
                }

            }
            
        }
    }
}