using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Estamparia_LP2A4.Objetos_Estamp
{
    internal class Fatura
    {
        private string _nomeUser;
        private string _emailUser;
        private string _data;
        private decimal _total;

        public Fatura(string NomeUser, string EmailUser, string Data, decimal Total)
        {
            _nomeUser = NomeUser;
            _emailUser = EmailUser;
            _data = Data;
            _total = Total;
        }

        public string NomeUser { get { return _nomeUser; } }
        public string EmailUser { get { return _emailUser; } }
        public string Data { get { return _data; } }
        public decimal Total { get { return _total; } }
    }

    
}
