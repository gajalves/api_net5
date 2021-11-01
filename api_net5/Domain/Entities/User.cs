using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_net5.Domain.Validators;
namespace api_net5.Domain.Entities
{
    public class User: Base
    {
        public string Nome { get; private set; }

        public string Email { get; private set; }

        public string Senha { get; private set; }

        protected User() { }

        public User(string nome, string email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            _erros = new List<string>();
        }
        
        public void AlteraNome(string nome)
        {
            Nome = nome;
            Validate();
        }

        public void AlteraEmail(string email)
        {
            Email = email;
            Validate();
        }

        public void AlteraSenha(string senha)
        {
            Senha = senha;
            Validate();
        }

        public override bool Validate()
        {
            UserValidator validator = new UserValidator();
            var validacao = validator.Validate(this);

            if(!validacao.IsValid)
            {
                foreach(var error in validacao.Errors)
                {
                    _erros.Add(error.ErrorMessage);
                }

                throw new Exception("Alguns campos estão inválidos, por favor corrigir! " + _erros[0]);                
            }

            return true;
        }
    }
}
