using System;

namespace Projeto_de_Produtos_POO.classes
{
    public class Usuario
    {
        public Usuario(){
            //Cadastrar usuário automaticamente quando esta classe for instanciada
            Cadastrar();
        }

        public Usuario(int _codigo,string _nome, string _email,string _senha){
            Codigo = _codigo;
            Nome = _nome;
            Email = _email;
            Senha = _senha;
            DataCadastro = DateTime.UtcNow;
        }

        //ATRIBUTOS 
        int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        DateTime DataCadastro { get; set; }

        //METODOS
        public void Cadastrar(){//CADASTRAR USUÁRIO
            Nome = "Carlos";
            Email = "admin@admin.com";
            Senha = "123456";
            DataCadastro = DateTime.UtcNow; 
        }

        public void Deletar(){//DELETAR USUÁRIO
            Nome = "";
            Email = "";
            Senha = "";
            DataCadastro = DateTime.Parse("0000-00-00T00:00:00");
        }                      
    }
}