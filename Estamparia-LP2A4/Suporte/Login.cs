using Estamparia_LP2A4.Objetos_Estamp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estamparia_LP2A4.Suporte
{
    internal class Login
    {
        private string _email;
        private string _senha;
        private string _perfil;

        public Login(string email, string senha)
        {
            Email = email;
            Senha = senha;
        }

        public string Email
        {
            get { return _email; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O E-mail informado não é um texto válido");
                _email = value; 
            }
        }

        public string Senha
        {
            get { return _senha; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("A senha informada não é um texto válido");
                _senha = value;
            }
        }

        public string Perfil
        {
            get { return _perfil; }
            set { _perfil = value; }
        }
    }
}
