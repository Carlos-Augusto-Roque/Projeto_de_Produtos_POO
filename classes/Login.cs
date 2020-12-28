using System;

namespace Projeto_de_Produtos_POO.classes
{
    public class Login
    {
        //ATRIBUTO DO TIPO BOOL PARA SABER SE ESTÁ LOGADO OU NÃO
        public bool Logado { get; set; }

        //MÉTODOS
        public void Logar(Usuario usuario){//MÉTODO LOGAR COM O OBJETO USUÁRIO COMO ARGUMENTO
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.Write("INSIRA SEU EMAIL: ");//EXIBIÇÃO DA MENSAGEM
            string emailLogin = Console.ReadLine();//ENTRADA E ARMAZENAMENTO DO EMAIL
            
            System.Console.Write("INSIRA SUA SENHA: ");//EXIBIÇÃO DA MENSAGEM
            string senhaLogin = Console.ReadLine();//ENTRADA E ARMAZENAMENTO DA SENHA 
            Console.ResetColor();
            
            //ESTRUTURA CONDICIONAL
            //SE O EMAIL E SENHA DIGITADO FOREM IGUAIS AOS JÁ DEFINIDOS NA CLASSE USUÁRIO,ENTÃO.. 
            if(emailLogin == usuario.Email && senhaLogin == usuario.Senha){
                
                Console.ForegroundColor = ConsoleColor.Green;
                Logado = true;//USUÁRIO ESTÁ LOGADO
                System.Console.WriteLine("LOGIN EFETUADO !");//EXIBIÇÃO DA MENSAGEM
                Console.ResetColor();

            }else{//SENÃO , EXIBIR A MENSAGEM DE QUE HOUVE FALHA AO LOGAR
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("FALHA AO LOGAR - USUÁRIO OU SENHA INCORRETO !");
                Console.ResetColor();
            }
        }
        
        //MÉTODO PARA DESLOGAR
        public void Deslogar(){
            Logado = false;//O USUÁRIO ESTARÁ DESLOGADO SE LOGADO= FALSE
        }

        //MÉTODO PARA LOGIN
        public Login(){
            Usuario user = new Usuario();//INSTANCIAMENTO DE UM USUÁRIO (USER)
            Logar(user);//LOGAR ESSE USUÁRIO

            if(Logado){//SE O USER ESTIVER LOGADO,ENTÃO 
                GerarMenu();//GERAR O MENU DE OPÇÕES
            }
        }

        public void GerarMenu(){//MÉTODO PARA GERAR O MENU
            //O MENU TRABALHARÁ COM AS CLASSES PRODUTOS E MARCA , ENTÃO É NECESSÁRIO INSTANCIAR ESSAS CLASSES CRIANDO UM OBJETO NOVO PARA CADA UMA
            Produto produto = new Produto();//INTANCIAMENTO DE UM NOVO PRODUTO
            Marca marca = new Marca();//INSTANCIAMENTO DE UMA NOVA MARCA

            int opcao;//VARIÁVEL PARA ESCOLHER A OPÇÃO DO MENU ...PODERIA SER DO TIPO STRING TBM..

            do//ESTRUTURA DE REPETIÇÃO TIPO DO-WHILE , PRIMEIRO FAZ A LEITURA DAS OPÇÕES
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

                opcao = int.Parse(Console.ReadLine());//ENTRADA E ARMAZENAMENTO DA OPÇÃO ESCOLHIDA
                
                //ESTRUTURA CONDICIONAL SWITCH-CASE, AVALIAR CADA OPÇÃO DO MENU
                switch (opcao)
                {
                    case 1://CASO A OPÇÃO SEJA 1
                        produto.Cadastrar();//CADASTRAR O PRODUTO , CHAMANDO O OBJETO INSTANCIADO ACIMA(produto) + O MÉTODO "CADASTRAR" CRIADO NA CLASSE PRODUTOS
                    break;

                    case 2://CASO A OPÇÃO SEJA 2
                        produto.Listar();//LISTAR OS PRODUTOS CADASTRADOS, CHAMANDO O OBJETO INSTANCIADO ACIMA(produto)+ O MÉTODO "CADASTRAR" CRIADO NA CLASSE PRODUTOS
                    break;

                    case 3://CASO A OPÇÃO SEJA 3
                        System.Console.Write("CÓDIGO PARA REMOVER: ");//EXIBIÇÃO DA MENSAGEM
                        int cod = int.Parse(Console.ReadLine());//ENTRADA E ARMAZENAMENTO DO CÓDIGO DO PRODUTO A SER REMOVIDO
                        produto.Deletar(cod);//DELETRAR O PRODUTO COM O CÓDIGO DIGITADO, CHAMANDO O OBJETO INSTANCIADO ACIMA(produto) + O MÉTODO "DELETAR" CRIADO NA CLASSE PRODUTOS
                    break;

                    case 4://CASO A OPÇÃO SEJA 4
                        marca.CadastrarMarca();//CADASTRAR A MARCA, CHAMANDO O OBJETO INSTANCIADO ACIMA(marca) + O MÉTODO "CADASTRARMARCA" CRIADO NA CLASSE MARCA
                    break;

                    case 5://CASO A OPÇÃO SEJA 5
                        marca.Listar();////LISTAR AS MARCAS CADASTRADOS, CHAMANDO O OBJETO INSTANCIADO ACIMA(marca) + O MÉTODO "LISTAR" CRIADO NA CLASSE MARCA
                    break;

                    case 6://CASO A OPÇÃO SEJA 6
                        System.Console.Write("CÓDIGO PARA REMOVER: ");//EXIBIÇÃO DA MENSAGEM
                        int codMarca = int.Parse(Console.ReadLine());//ENTRADA E ARMAZENAMENTO DO CÓDIGO DA MARCA A SER REMOVIDA
                        marca.Deletar(codMarca);////DELETRAR A MARCA COM O CÓDIGO DIGITADO, CHAMANDO O OBJETO INSTANCIADO ACIMA(marca) + O MÉTODO "DELETAR" CRIADO NA CLASSE MARCA
                    break;

                    case 0://CASO A OPÇÃO SEJA 0
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        System.Console.WriteLine("APP ENCERRADO !");//EXIBIÇÃO DA MENSAGEM
                        Console.ResetColor();
                    break;

                    default:

                    break;
                }
                
                
            } while (opcao != 0);//O LAÇO SERÁ INFINITO ATÉ QUE A OPÇÃO SEJA DIFERENTE DE 0

        }

        
    }
}