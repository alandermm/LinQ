using System;
using System.Collections.Generic;
using System.Linq;

namespace LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cidades = new List<string>();
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
            };

            var alunosSelecionados = from aluno in alunos where aluno.Idade > 20 && aluno.Idade < 40 select aluno;
            foreach(Aluno al in alunosSelecionados){
                Console.WriteLine(al.Id + " - " + al.Nome + " - " + al.Email + " - " + al.Idade);
            }
        }
    }
}