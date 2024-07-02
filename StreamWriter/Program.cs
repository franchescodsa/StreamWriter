namespace StreamWriterr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcepath = @"f:\tempp\teste.txt";
            string targetpath = @"f:\tempp\teste2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcepath);

                using (StreamWriter sw = File.AppendText(targetpath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }

                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro inesperado");
                Console.WriteLine(e.Message);
            }
        }
    }
}
