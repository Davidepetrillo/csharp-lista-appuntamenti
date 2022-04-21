using ListaAppuntamenti;

List<Appuntamento> listaAppuntamenti = new List<Appuntamento>();

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

Console.WriteLine();

Console.Write("Vuoi cambiare la data di uno dei tuoi appuntamenti? [Si/No] --- Risposta: ");
string rispostaDellUtenteSulCambioData = Console.ReadLine();

if (rispostaDellUtenteSulCambioData == "Si")
{
    Console.Write("Qual'è il nome dell'appuntamento della quale intendi cambiare la data?");
    string sceltaNomeAppuntamentoPerCambioDataDellUtente = Console.ReadLine();

    bool appuntamentoDaCambiareTrovato = false;

    foreach (Appuntamento appuntamentoAggiuntoAllaLista in listaAppuntamenti)
    {
        if (appuntamentoAggiuntoAllaLista.GetNome(sceltaNomeAppuntamentoPerCambioDataDellUtente) == nomeDellAppuntamento)
        {
            appuntamentoDaCambiareTrovato = true;
        }
    }
    // da rivedere la parte del bonus con il cambio data
}


