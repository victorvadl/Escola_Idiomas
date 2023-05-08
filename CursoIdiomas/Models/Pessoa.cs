using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExplorandoPropriedades.Models
{
    public class Pessoa
    {
        // Construtores
        public Pessoa()
        {

        }

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }


        // Variáveis
        private string _nome;
        private int _idade;
        private string _sobrenome;

        // Propriedades
        public string Nome 
        { 
            get => _nome;
        
            set
            {
                while (string.IsNullOrEmpty(value))
                {
                    Console.Clear();
                    Console.WriteLine("O nome não pode ser vazio. Digite novamente:");
                    value = Console.ReadLine();
                }

                _nome = value;
            } 
        }

        public string Sobrenome 
        { 
            get => _sobrenome;
            
            set
            {
                while (string.IsNullOrEmpty(value))
                {
                    Console.Clear();
                    Console.WriteLine("O sobrenome não pode ser vazio. Digite novamente");
                    value = Console.ReadLine();
                }
                _sobrenome = value;
            } 
        }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public int Idade 
        {
            get => _idade; 

            set
            {
                if (value <0)
                {
                    throw new ArgumentException("A idade não pode ser menor que 0");
                }
                _idade = value;
            }
        }

        // Métodos
        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}