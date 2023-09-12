using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastro.Models
{
    internal class Usuario
    {

        //Definindo atributos como metodos Get and Set para cada um

        public string user {get;set;}
        public string email { get;set;}
        public string password { get;set;}

        public Usuario(string user,string email,string password)
        {
            this.user = user;
            this.email = email; 
            this.password = password;   
        }

    }
}
