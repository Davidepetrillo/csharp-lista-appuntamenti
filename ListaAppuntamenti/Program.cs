using ListaAppuntamenti;

List<Appuntamento> listaAppuntamenti = new List<Appuntamento>();

Console.WriteLine("Vuoi aggiungere un appuntamento alla tua agenda? [Si/No]");
string RispostaUtente = Console.ReadLine();

if (RispostaUtente == "Si") 

{
    Console.WriteLine("Quanti appuntamenti vuoi aggiungere alla tua agenda?");
    int numeroDiAppuntamentiAggiuntiDallUtente = int.Parse(Console.ReadLine());

    for (int i = 0; i < numeroDiAppuntamentiAggiuntiDallUtente; i++)
    {

        Console.WriteLine();
        Console.Write("Inserisci il nome del tuo appuntamento: ");
        string nomeDellAppuntamento = Console.ReadLine();
        Console.Write("Inserisci il luogo del tuo appuntamento: ");
        string luogoDellAppuntamento = Console.ReadLine();

        try
        {
            Console.Write("Inserisci la data del tuo appuntamento: ");
            DateTime dataEOraDellAppuntamento = DateTime.Parse(Console.ReadLine());

            Appuntamento nuovoAppuntamento = new Appuntamento(nomeDellAppuntamento, luogoDellAppuntamento, dataEOraDellAppuntamento);
            listaAppuntamenti.Add(nuovoAppuntamento);
        }
        catch (InvalidDataException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    foreach (Appuntamento appuntamentoAggiuntoAllaLista in listaAppuntamenti)
    {
        appuntamentoAggiuntoAllaLista.ToString();
    }

} else if ( RispostaUtente == "No")
           {

           }
