using System;
using System.Collections.Generic;
using System.Linq;

namespace LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            /*List<string> cidades = new List<string>();
            cidades.Add("Campinas");
            cidades.Add("Guarulhos");
            cidades.Add("Salvador");
            cidades.Add("Belo Horizonte");

            var cid = cidades.Where(x => x.Length < 5);
            foreach(String c in cid){
                Console.WriteLine(c);
            }

            List<Aluno> alunos = new List<Aluno>(){
                new Aluno{Id = 10, Nome = "Pedro", Email = "pedro@terra.com.br", Idade = 35},
                new Aluno{Id = 11, Nome = "Helena", Email = "helena@uol.com.br", Idade = 24},
                new Aluno{Id = 58, Nome = "Tadeu", Email = "tadeu@terra.com.br", Idade = 55},
                new Aluno{Id = 7, Nome = "Vanessa", Email = "vanessa@gmail.com", Idade = 15}
            };*/

            /*var alunosSelecionados = from aluno in alunos where aluno.Idade > 20 && aluno.Idade < 40 select aluno;
            foreach(Aluno al in alunosSelecionados){
                Console.WriteLine(al.Id + " - " + al.Nome + " - " + al.Email + " - " + al.Idade);
            }*/

            /*var alunosSelecionados = alunos.Where(a => a.Idade > 20 && a.Idade < 50);
            foreach(var aluno in alunosSelecionados){
                Console.WriteLine(aluno.Id + " - " + aluno.Nome + " - " + aluno.Email + " - " + aluno.Idade);
            }*/

            /*var alunosSelecionados = from x in alunos where x.Email.Contains("terra") orderby x.Id descending select x;
            foreach(var aluno in alunosSelecionados){
                Console.WriteLine(aluno.Id + " - " + aluno.Nome + " - " + aluno.Email + " - " + aluno.Idade);
            }*/

            /*var alunosSelecionados = alunos.Where(a => a.Email.Contains("terra"));
            foreach(var aluno in alunosSelecionados){
                Console.WriteLine(aluno.Id + " - " + aluno.Nome + " - " + aluno.Email + " - " + aluno.Idade);
            }*/

            /*var alunosSelecionados = alunos.Count(x => x.Email.Contains("terra"));
            Console.WriteLine(alunosSelecionados);*/

            List<Produto> prod = new List<Produto>(){
                new Produto{IdProduto = 1, NomeProduto = "Lápis", Preco = 2, IdFornecedor = 30},
                new Produto{IdProduto = 2, NomeProduto = "Borracha", Preco = 5, IdFornecedor = 41},
                new Produto{IdProduto = 3, NomeProduto = "Caneta", Preco = 6 , IdFornecedor = 30},
                new Produto{IdProduto = 4, NomeProduto = "Caderno", Preco = 20, IdFornecedor = 51}
            };

            List<Fornecedor> forne = new List<Fornecedor>(){
                new Fornecedor{IdFornecedor = 30, RazaoSocial = "Faber Castel", Telefone = "11"},
                new Fornecedor{IdFornecedor = 41, RazaoSocial = "Bic", Telefone = "56"},
                new Fornecedor{IdFornecedor = 51, RazaoSocial = "Chameco", Telefone = "45"}
            };

            var resultado = prod.Join(
                forne,
                p => p.IdFornecedor,
                f => f.IdFornecedor,
                (p,f) => new {
                    pNome = p.NomeProduto,
                    fRazao = f.RazaoSocial
                }
            );

            foreach(var prodForne in resultado){
                Console.WriteLine(prodForne.pNome + " - " + prodForne.fRazao);
            }
        }
    }
}