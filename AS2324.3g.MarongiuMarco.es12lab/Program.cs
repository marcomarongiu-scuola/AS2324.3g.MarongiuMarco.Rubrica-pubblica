namespace AS2324._3g.MarongiuMarco.es12lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] simpatia=new int[100];
           string [] nome=new string[100];
           int[] annoNascita = new int[100];
           string[] cognome = new string[100];
           string[] nickname = new string[100];
           string[] email = new string[100];
            int scelta;
            int cont = 0;
            do
            {
                Console.WriteLine("premi 1 per: inserire un nominativo");
                Console.WriteLine("premi 2 per: vedere l'elenco dei nominativi");
                Console.WriteLine("premi 3 per: ricercare un nominativo in base al nickname");
                Console.WriteLine("premi 9 per: uscire");
                scelta = Convert.ToInt32(Console.ReadLine());
                switch (scelta)
                {
                    case 1:
                        Console.WriteLine("Inserire dati obbligatori:");
                        Console.WriteLine("Inserire Nome");
                        nome[cont] = Console.ReadLine();
                        Console.WriteLine("inserire cognome");
                        cognome[cont] = Console.ReadLine();
                        Console.WriteLine("inserisci Nickname");
                        nickname[cont] = Console.ReadLine();
                        Console.WriteLine("Inserire dati facoltativi:");
                        Console.WriteLine("inseirire data di nascita");
                        annoNascita[cont] =int.Parse(Console.ReadLine());
                        Console.WriteLine("inserire email");
                        email[cont] = Console.ReadLine();
                        Console.WriteLine("inserire simpatia");
                        simpatia[cont]=int.Parse(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("elenco dei nominativi");
                        for (int i = 0; i < 100; i++)
                        {
                            Console.WriteLine("persona: "+(i+1);
                            Console.WriteLine("Nome");
                        }

                }
                cont++;
            } while (scelta != 9);
        }
    }
}