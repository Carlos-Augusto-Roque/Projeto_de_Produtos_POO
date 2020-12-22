using System;
using System.Collections.Generic;

namespace Projeto_de_Produtos_POO.classes
{
    public class Produto
    {
        //ATRIBUTOS
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Marca Marca = new Marca();
        public Usuario CadastradoPor { get; set; }

        //LISTA DOS PRODUTOS
        public List<Produto> ListaDeProdutos = new List<Produto>();
        
        //METODOS
        public void Cadastrar(){//METODO PARA CADASTRAR PRODUTOS

            Produto novoProduto = new Produto();//INSTANCIADO NOVO OBJETO DO TIPO PRODUTO
            
            System.Console.Write("CÓDIGO DO PRODUTO: ");//EXIBIÇÃO DA MENSAGEM
            novoProduto.Codigo = int.Parse(Console.ReadLine());//ENTRADA E ARMAZENAMENTO DO CÓDIGO DO PRODUTO

            System.Console.Write("NOME DO PRODUTO: ");//EXIBIÇÃO DA MENSAGEM
            novoProduto.NomeProduto = Console.ReadLine();//ENTRADA E ARMAZENAMENTO DO NOME DO PRODUTO

            System.Console.Write("PREÇO DO PRODUTO: ");//EXIBIÇÃO DA MENSAGEM
            novoProduto.Preco = float.Parse(Console.ReadLine());//ENTRADA E ARMAZENAMENTO DO PREÇO DO PRODUTO

            novoProduto.DataCadastro = DateTime.UtcNow;//EXIBIÇÃO DA DATA E HORA

            //ATRIBUIÇÃO DA MARCA ATRAVÉS DE UM MÉTODO CRIADO PARA CADASTRO
            novoProduto.Marca = Marca.CadastrarMarca();//CHAMAR O MÉTODO "CADASTRARMARCA" DA CLASSE MARCA

            //ATRIBUIÇÃO DO USUÁRIO ATRAVÉS DE UM MÉTODO CONSTRUTOR
            novoProduto.CadastradoPor = new Usuario(); 

            //SALVAR O PRODUTO NA LISTA
            ListaDeProdutos.Add(novoProduto);
           
        }

        //MÉTODO PARA LISTAR OS ITENS DA ARMAZENADOS NA LISTA
        public void Listar(){
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var item in ListaDeProdutos)
            {
                System.Console.WriteLine($"CÓDIGO: {item.Codigo}");
                System.Console.WriteLine($"PRODUTO: {item.NomeProduto}");
                System.Console.WriteLine($"PREÇO: {item.Preco}");
                System.Console.WriteLine($"DATA DE CADASTRO: {item.DataCadastro}");
                System.Console.WriteLine($"MARCA: {item.Marca.NomeMarca}");
                System.Console.WriteLine($"CADASTRADO POR: {item.CadastradoPor.Nome}");
                System.Console.WriteLine();
            }
            Console.ResetColor();
        }

        //MÉTODO PARA DELETAR ALGUM PRODUTO CADASTRADO
        public void Deletar(int cod){//VIA CÓDIGO DO PRODUTO, PROCURAR O PRODUTO E DELETAR DA LISTA
            Produto prodDelete = ListaDeProdutos.Find(p => p.Codigo == cod);
            ListaDeProdutos.Remove(prodDelete);
        }
    }
}