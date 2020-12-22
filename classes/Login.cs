using System;

namespace Projeto_de_Produtos_POO.classes
{
    public class Login
    {
        public bool Logado { get; set; }

        public Login(){
            Usuario user = new Usuario();
            Logar(user);

            if(Logado){
                GerarMenu();
            }
        }

        public void GerarMenu(){

            Produto produto = new Produto();
            Marca marca = new Marca();

            int opcao;

            do
            {
                System.Console.WriteLine();
                System.Console.WriteLine("-----MENU DE OPÇÕES-----");
                System.Console.WriteLine();
                System.Console.WriteLine("----ESCOLHA A OPÇÃO----");
                System.Console.WriteLine("[1] - CADASTRAR PRODUTO");
                System.Console.WriteLine("[2] - LISTAR PRODUTOS");
                System.Console.WriteLine("[3] - REMOVER PRODUTO");
                System.Console.WriteLine("[4] - CADASTRAR MARCA");
                System.Console.WriteLine("[5] - LISTAR MARCAS");
                System.Console.WriteLine("[6] - REMOVER MARCA");
                System.Console.WriteLine("[0] - SAIR");                

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        produto.Cadastrar();
                    break;

                    case 2:
                        produto.Listar();
                    break;

                    case 3:
                        System.Console.Write("CÓDIGO PARA REMOVER: ");
                        int cod = int.Parse(Console.ReadLine());
                        produto.Deletar(cod);
                    break;

                    case 4:
                        marca.CadastrarMarca();
                    break;

                    case 5:
                        marca.Listar();
                    break;

                    case 6:
                        System.Console.Write("CÓDIGO PARA REMOVER: ");
                        int codMarca = int.Parse(Console.ReadLine());
                        marca.Deletar(codMarca);
                    break;

                    case 0:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        System.Console.WriteLine("APP ENCERRADO !");
                        Console.ResetColor();
                    break;

                    default:

                    break;
                }
                
                
            } while (opcao != 0);

        }

        public void Logar(Usuario usuario){
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.Write("INSIRA SEU EMAIL: ");
            string emailLogin = Console.ReadLine();
            
            System.Console.Write("INSIRA SUA SENHA: ");
            string senhaLogin = Console.ReadLine();
            Console.ResetColor();
            
            if(emailLogin == usuario.Email && senhaLogin == usuario.Senha){
                
                Console.ForegroundColor = ConsoleColor.Green;
                Logado = true;
                System.Console.WriteLine("LOGIN EFETUADO !");
                Console.ResetColor();

            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("FALHA AO LOGAR - USUÁRIO OU SENHA INCORRETO !");
                Console.ResetColor();
            }
        }
        
        public void Deslogar(){
            Logado = false;
        }
        
    }
}