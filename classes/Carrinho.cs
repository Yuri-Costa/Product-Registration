using System;
using System.Collections.Generic;

namespace Carrinho_de_Compra.classes
{
    public class Carrinho 
    {
        List<Produto> carrinho = new List<Produto> ();

      

        public void MostrarMenu(){
            Console.WriteLine("----------------------------");
            Console.WriteLine("------------MENU------------");
            Console.WriteLine("");
            Console.WriteLine("CADASTRAR PRODUTO  ---> [1]");
            Console.WriteLine("LISTAR PRODUTO     ---> [2]");
            Console.WriteLine("ADICIONAR PRODUTO  ---> [3]");
            Console.WriteLine("REMOVER PRODUTO    ---> [4]");
            Console.WriteLine("SUBSTITUIR PRODUTO ---> [5]");
            Console.WriteLine("SAIR               ---> [0]");
            Console.WriteLine("--------------------------");
        }


        public void DarBoasVindas(){
            Console.WriteLine("Ola!");
            Console.WriteLine("Qual o seu nome?");
            string dbvNome = Console.ReadLine();
            Console.WriteLine($" {dbvNome} seja muito Bem Vindo ao sistema de Produtos :)");
        }

        public void Cadastrarproduto(){
             Console.WriteLine("ok! vamos cadastrar seus produtos!");
            Console.WriteLine(" Para começar, digite o codigo do seu produto");
            int CPcodigo = int.Parse(Console.ReadLine());
            Console.WriteLine($" Codigo [{CPcodigo}] cadastrado :)");
            Console.WriteLine("digite o nome do seu produto");
            string CPnome = Console.ReadLine();
            Console.WriteLine($" Nome [{CPnome}] cadastrado :)");
            Console.WriteLine("digite o Preço do seu produto");
            float CPpreco = int.Parse(Console.ReadLine());
            Console.WriteLine($" Preço de [R${CPpreco.ToString("n2")}] cadastrado :)");
            Produto p = new Produto(CPcodigo, CPnome, CPpreco );
            carrinho.Add(p);
            Console.WriteLine("Ótimo! seu produto foi cadastrado com sucesso :)");

        }

        public void AddProduto(Produto produto){
            carrinho.Add(produto);
        }

        public void MostrarLista(){
            foreach (var p in carrinho)
            {
                Console.WriteLine($"Código: {p.Codigo}, Nome: {p.Nome}, Preço: R${p.preco.ToString("n2")}");
            }
        }

        
        

            
    }
}