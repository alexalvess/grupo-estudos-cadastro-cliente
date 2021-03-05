using System;

namespace Dominio.Entidades
{
    public class Trabalhador
    {
        public Trabalhador(string nome, string email, DateTime dataNascimento, string cpf)
        {
            cpf = cpf.Replace(".", "").Replace("-", "");

            ValidarNome(nome);
            ValidarEmail(email);
            ValidarCpf(cpf);

            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;

            Cpf = "########" + cpf.Substring(7, 2);
        }

        public int Id { get; protected set; }

        public string Nome { get; protected set; }

        public string Email { get; protected set; }

        public DateTime DataNascimento { get; protected set; }

        public string Cpf { get; protected set; }

        private void ValidarNome(string nome)
        {
            if(nome.Length < 3)
            {
                throw new Exception("Nome possui menos que 3 caracteres.");
            }
            if(nome.Length > 50)
            {
                throw new Exception("Nome possui mais que 50 caracteres.");
            }
            if(nome.Contains("!") || nome.Contains("@"))
            {
                throw new Exception("Nome contém caracteres especiais");
            }
        }

        private void ValidarEmail(string email)
        {
            if(email.Length < 3 || email.Length > 100)
            {
                throw new Exception("Quantidade de caracteres do email é inválida. É necessário ter maior que 3 ou menor que 100 caracteres.");
            }
        }

        private void ValidarCpf(string cpf)
        {
            if(cpf.Length != 11)
            {
                throw new Exception("O CPF informado é inválido.");
            }
        }
    }
}
