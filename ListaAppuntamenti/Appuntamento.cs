using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAppuntamenti
{
    internal class Appuntamento
    {
        internal string nomeDellAppuntamento;
        internal string localitaAppuntamento;
        internal DateTime dataEOraDellAppuntamento;


        // costruttore

        public Appuntamento(string nomeDellAppuntamento, string localitaAppuntamento, DateTime dataEOraDellAppuntamento)
        {
            this.nomeDellAppuntamento = nomeDellAppuntamento;
            this.localitaAppuntamento = localitaAppuntamento;

            if(dataEOraDellAppuntamento < DateTime.Now)
            {
                throw new InvalidDataException("La data dell'appuntamento non può essere precedente alla data di oggi");
            }
            this.dataEOraDellAppuntamento = dataEOraDellAppuntamento;
        }

        // Getters e Setters
        public string GetNome(string nuovoNome)
        {
            return nuovoNome;
        }
        public string SetNome(string nuovoNome)
        {
            return nuovoNome;
        }

        public string GetLocalitaAppuntamento(string nuovaLocalitaAppuntamento)
        {
            return nuovaLocalitaAppuntamento;
        }
        public string SetLocalitaAppuntamento(string nuovaLocalitaAppuntamento)
        {
            return nuovaLocalitaAppuntamento;
        }

        public string GetDataEOra(string nuovaDataEOra)
        {
            return nuovaDataEOra;
        }
        public string SetDataEOra(string nuovaDataEOra)
        {
            return nuovaDataEOra;
        }

        public void CambioDataDellAppuntamento (DateTime nuovaDataAppuntamento)
        {
            if (nuovaDataAppuntamento < DateTime.Now)
            {
                throw new InvalidDataException("La data dell'appuntamento non può essere precedente alla data di oggi");
            }
            this.dataEOraDellAppuntamento = nuovaDataAppuntamento;
        }

        public void ToString()
        {
            Console.WriteLine();
            Console.WriteLine("----- Appuntamento -------");
            Console.WriteLine();
            Console.WriteLine($"Tipo di appuntamento: {nomeDellAppuntamento}");
            Console.WriteLine($"Luogo dell' appuntamento: {localitaAppuntamento}");
            Console.WriteLine($"Data e Ora dell' appuntamento: {dataEOraDellAppuntamento}");
            Console.WriteLine();
            Console.WriteLine("------------------");
        }
    }
}
