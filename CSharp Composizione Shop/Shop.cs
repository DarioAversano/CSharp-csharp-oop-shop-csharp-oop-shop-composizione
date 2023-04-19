using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Composizione_Shop
{
    internal class Shop
    {
        private string nome;
        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                this.nome = value;
            }
        }
        private string citta;
        public string Citta
        {
            get
            {
                return citta;
            }
            set
            {
                this.citta = value;
            }
        }
        private string indirizzo;
        public string Indirizzo
        {
            get
            {
                return indirizzo;
            }
            set
            {
                this.indirizzo = value;
            }
        }
        private string numeroCivico;
        public string NumeroCivico
        {
            get
            {
                return numeroCivico;
            }
            set
            {
                this.numeroCivico = value;
            }
        }


    //CONSTRUCTOR
        public Shop (string nome = "Nome non definito", string citta = "Citta non definita", string indirizzo = "Via non definita", string numeroCivico = "N.D.")
        {
            this.nome = nome;
            this.citta = citta;
            this.indirizzo = indirizzo;
            this.numeroCivico = numeroCivico; 
        }


    }
}

