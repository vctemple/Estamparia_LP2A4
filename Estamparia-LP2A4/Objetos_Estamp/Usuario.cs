using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using BCrypt.Net;
using static BCrypt.Net.BCrypt;
using System.Drawing.Text;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;

namespace Estamparia_LP2A4.Objetos_Estamp
{
    public class Usuario
    {
        private int _id;
        private string _nome;
        private string _email;
        private string _telefone;
        private string _cpf;
        private string _senha;
        private string _perfil;

        public Usuario(string nome, string email, string telefone, string cpf, string senha, string perfil)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            CPF = cpf;
            Senha = senha;
            _perfil = perfil;
        }
        public Usuario(int id, string nome, string email, string telefone, string cpf, string senha, string perfil):
            this(nome, email, telefone, cpf, senha, perfil)
        {
            _id = id;
        }

        public Usuario(int id, string nome, string email, string telefone, string cpf, string perfil)
        {
            _id = id;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            CPF = cpf;
            _perfil = perfil;
        }

        //CONSTRUTOR PRA LOGIN
        public Usuario(string email, string senha, string perfil)
        {
            Email = email;
            _senha = senha;
            _perfil = perfil;
        }

        public Usuario(int id)
        {
            _id = id;
        }
        
        public int Id
        {
            get { return _id; }
        }

        public string Perfil
        {
            get { return _perfil; }
        }

        // Validacao de Nome
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O Nome precisa ser preenchido!");
                _nome = value;
            }
        }
        // Validação de Email
        public static bool ValidarEmail(string strEmail)
        {
            string strModelo = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (System.Text.RegularExpressions.Regex.IsMatch(strEmail, strModelo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string Email
        {
            get { return _email; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O E-mail precisa ser preenchido!");
                if (ValidarEmail(value) == false)
                    throw new Exception("O E-mail digitado não é um texto válido!");
                _email = value;
            }
        }

        // Validação de Telefone
        public string Telefone
        {
            get { return _telefone; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O telefone precisa ser preenchido!");
                if (value.Length < 11)
                    throw new Exception("O campo de telefone apresenta espaços vazios!");
                _telefone = value;
            }
        }

        // Validação de CPF
        public bool ValidarCPF(string CPF)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma = 0;
            int resto;

            CPF = CPF.Trim();
            CPF = CPF.Replace(".", "").Replace("-", "");

            if (CPF.Length != 11)
                return false;

            tempCpf = CPF.Substring(0, 9);

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return CPF.EndsWith(digito);
        }
        public string CPF
        {
            get { return _cpf; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O CPF precisa ser preenchido!");
                if (value.Length < 11)
                    throw new Exception("O campo de CPF apresenta espaços vazios!");
                if (ValidarCPF(value) == false)
                    throw new Exception("O CPF digitado não é um valor válido!");
                _cpf = value;
            }
        }
        //Validação de Senha
        private bool SenhaForte(string senha)
        {
            Regex validateGuidRegex = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
            if (validateGuidRegex.IsMatch(senha))
                return true;
            return false;
        }
        public static string SenhaBcrypt(string senha)
        {
            int Workfactor = 12;
            string senhahash = HashPassword(senha, Workfactor);
            return senhahash;
        }
        
        public static string CifradorDiagonal(string senha)
        {
            int num = 3;
            string nova = String.Empty;
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    nova = nova + "_";
                }
                int aux = i;
                while (aux < senha.Length)
                {
                    nova = nova + (senha[aux] != ' ' ? senha[aux] : '_');
                    aux = aux + num;
                }
                int resto = (senha.Length % num) > i ? num - (i + 2) : num - (i + 1);
                while (resto > 0)
                {
                    nova = nova + "_";
                    resto--;
                }
            }
            return nova;
        }
        public string Senha
        {
            get { return _senha; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O campo de senha é obrigatório e precisa ser preenchido!");
                if (SenhaForte(value) == false)
                    throw new Exception("Verifique se sua senha digitada apresenta as exigências:\n\n" +
                                        "- Pelo menos 8 dígitos;\n" +
                                        "- Ao menos um caracter numérico;\n" +
                                        "- Ao menos uma letra maiúscula;\n" +
                                        "- Ao menos uma letra minúscula;\n" +
                                        "- Ao menos um caractere especial: #?!@$%^&*-");
                _senha = SenhaBcrypt(value);
            }
        }
    }


}
