using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExplorandoPropriedades.Models
{
    public class Curso
    {
        // Construtores
        public Curso()
        {
            ListaDeCursos = new List<Curso>();
        }
        // Propriedades
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }
        public List<Curso> ListaDeCursos { get; set; }

        // Métodos
        public void AdicionarAluno(Pessoa aluno)
        {
            if (Alunos.Any(a => a.NomeCompleto == aluno.NomeCompleto))
            {
                Console.WriteLine($"O aluno {aluno.NomeCompleto} já está matriculado neste curso.");
            }
            else
            {
                Alunos.Add(aluno);
                Console.WriteLine($"O aluno {aluno.NomeCompleto} foi matriculado com sucesso.");
            }
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            
            if (Alunos.Count == 0)
            {
                Console.WriteLine($"Nenhum aluno no curso de {Nome}");
            }

            else
            {
                Console.WriteLine($"Alunos do curso de {Nome}");
                foreach (Pessoa aluno in Alunos)
                {
                    Console.WriteLine(aluno.NomeCompleto);
                }
            }
            
        }

        public void ListarCursos()
        {
            Console.WriteLine("Os cursos disponíveis são:");
            for (int indicadorCurso = 0; indicadorCurso < ListaDeCursos.Count; indicadorCurso++)
            {
                Console.WriteLine($"{indicadorCurso+1} - Curso de {ListaDeCursos[indicadorCurso].Nome}.");
            }
        }
    }
}