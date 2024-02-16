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
            string ricerca;
            do
            {
                Console.WriteLine("premi 1 per: inserire un nominativo");
                Console.WriteLine("premi 2 per: vedere l'elenco dei nominativi");
                Console.WriteLine("premi 3 per: ricercare un nominativo in base al nickname");
                Console.WriteLine("premi 4 per ricercare tutti i nomi in base al nome case insensitive");
                Console.WriteLine("premi 5 per ricercare tutti i cognomi che iniziano per a prescindere da come è scritto");
                Console.WriteLine("premi 6 per ricercare tutti i cognomi che contengono il dato ricercato a prescindere da come è scritto\r\n");
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
                        do 
                        {
                            Console.WriteLine("inserire simpatia (deve essere compresa tra 1 e 5)");
                            simpatia[cont] = int.Parse(Console.ReadLine());
                        }while (simpatia[cont]<1 || simpatia[cont]>5);
                        cont++;
                        break;
                    case 2:
                        Console.WriteLine("elenco dei nominativi");
                        for (int i = 0; i < cont; i++)
                        {
                            Console.WriteLine("persona: "+(i+1));
                            Console.WriteLine("Nome: " + nome[i]);
                            Console.WriteLine("Cognome: " + cognome[i]);
                            Console.WriteLine("Nickname: " + nickname[i]);
                            Console.WriteLine("Anno di nascita: " + annoNascita[i]);
                            Console.WriteLine("Email: " + email[i]);
                            Console.WriteLine("Simpatia: " + simpatia[i]);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Inserisci un nickname");
                        ricerca=(Console.ReadLine());
                        bool verifica=false;
                        for (int y=0; y < cont; y++)
                        {
                            if (ricerca == nickname[y])
                            {
                                verifica=true;
                                Console.WriteLine("Nome: " + nome[y]);
                                Console.WriteLine("Cognome: " + cognome[y]);
                                Console.WriteLine("Nickname: " + nickname[y]);
                                Console.WriteLine("Anno di nascita: " + annoNascita[y]);
                                Console.WriteLine("Email: " + email[y]);
                                Console.WriteLine("Simpatia: " + simpatia[y]);
                            }
                        }
                        if (verifica == false)
                        {
                            Console.WriteLine("Non sono state trovate persone con il nickname: "+ricerca);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Inserisci un nome");
                        ricerca = (Console.ReadLine());
                        bool verifica2 = false;
                        for (int y = 0; y < cont; y++)
                        {
                            if (ricerca.ToUpper() == nome[y].ToUpper())
                            {
                                verifica = true;
                                Console.WriteLine("Nome: " + nome[y]);
                                Console.WriteLine("Cognome: " + cognome[y]);
                                Console.WriteLine("Nickname: " + nickname[y]);
                                Console.WriteLine("Anno di nascita: " + annoNascita[y]);
                                Console.WriteLine("Email: " + email[y]);
                                Console.WriteLine("Simpatia: " + simpatia[y]);
                            }
                        }
                        if (verifica2 == false)
                        {
                            Console.WriteLine("Non sono state trovate persone con il nome: " + ricerca);
                        }
                        break;
                    case 5:
                        Console.WriteLine("Inserisci la parte iniziale di un cognome");
                        ricerca = (Console.ReadLine());
                        bool verifica3 = false;
                        for (int y = 0; y < cont; y++)
                        {
                            if (cognome[y].ToUpper().StartsWith(ricerca.ToUpper()) == true)
                            {
                                verifica = true;
                                Console.WriteLine("Nome: " + nome[y]);
                                Console.WriteLine("Cognome: " + cognome[y]);
                                Console.WriteLine("Nickname: " + nickname[y]);
                                Console.WriteLine("Anno di nascita: " + annoNascita[y]);
                                Console.WriteLine("Email: " + email[y]);
                                Console.WriteLine("Simpatia: " + simpatia[y]);
                            }
                        }
                        if (verifica3 == false)
                        {
                            Console.WriteLine("Non sono state trovate persone con il cognnome: " + ricerca);
                        }
                        break;
                    
                    default:
                        if (scelta != 9)
                        {
                            Console.WriteLine("valore non accettabile");
                        }
                        break;
                }
                
            } while (scelta != 9);
        }
    }
}