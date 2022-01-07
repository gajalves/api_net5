using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_net5.Services.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public UserDTO()
        {

        }

        public UserDTO(int id, string nome, string email, string senha)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
        }
    }
}
