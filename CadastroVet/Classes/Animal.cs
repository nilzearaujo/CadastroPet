using CadastroPet.Enums;
using System;

namespace CadastroPet.Classes
{
    public class Animal: EntidadeBase
    {
        //Identificador Geral que incrementa a cada novo objeto criado
        private static int ID = 0;

        //Propriedades
        public string Nome { get; set; }
        public ETipoAnimal Tipo { get; set; }
        public string Cor { get; set; }
        public string Porte { get; set; }
        public double Peso { get; set; }
        public int Idade { get; set; }
        public string NomeDoTutor { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }

        //Construtor      
        public Animal()
        {
            //Incremente o id simulando um banco de dados
            Id = ID++;           
        }

        public void Detalhes()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Tipo: {Tipo}");
            Console.WriteLine($"Cor: {Cor}");
            Console.WriteLine($"Porte: {Porte}");
            Console.WriteLine($"Peso: {Peso}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Nome do Tutor: {NomeDoTutor}");
            Console.WriteLine($"Endereço: {Endereco}");
            Console.WriteLine($"Telefone: {Telefone}");
        }
    }
}
