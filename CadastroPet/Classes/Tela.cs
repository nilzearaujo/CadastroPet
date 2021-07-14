using CadastroPet.Enums;
using CadastroPet.Interfaces;
using System;

namespace CadastroPet.Classes
{
    public class Tela
    {
        private IRepositorio<Animal> repositorio;

        public Tela()
        {
            repositorio = new AnimalRepositorio();
        }

        //Metodos Publicos
        public void Mostrar()
        {
            string opcao;
            do
            {
                opcao = Menu();
                switch (opcao)
                {
                    case "1":
                        CadastrarPet();
                        break;
                    case "2":
                        ListarPets();
                        break;
                    case "3":
                        AtualizarPet();
                        break;
                    case "4":
                        ExcluirPet();
                        break;
                    case "5":
                        DetalhesPet();
                        break;
                    case "6":
                        Console.WriteLine("Obrigado por usar o sistema Cadastro Pet");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente...");
                        break;
                }
            }
            while (opcao != "6");
        }

        //Metodos Privados
        private string Menu()
        {
            Console.WriteLine();
            Console.WriteLine("##### Cadastro Pet #####");
            Console.WriteLine("# (1) - Cadastrar Pet  #");
            Console.WriteLine("# (2) - Listar Pets    #");
            Console.WriteLine("# (3) - Atualizar Pet  #");
            Console.WriteLine("# (4) - Excluir Pet    #");
            Console.WriteLine("# (5) - Detalhes Pet   #");
            Console.WriteLine("# (6) - Sair           #");
            Console.WriteLine("########################");
            Console.Write(">");
            return Console.ReadLine();
        }
        private void CadastrarPet()
        {
            Console.WriteLine();
            Animal animal = new Animal();
            Console.WriteLine("Digite o nome do animal:");
            Console.Write(">");
            animal.Nome = Console.ReadLine();
            Console.WriteLine("Digite o tipo do animal:");
            Console.WriteLine("(1) - Cachorro / (2) - Gato");
            Console.Write(">");
            animal.Tipo = (ETipoAnimal)int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o cor do animal:");
            Console.Write(">");
            animal.Cor = Console.ReadLine();
            Console.WriteLine("Digite o porte do animal:");
            Console.Write(">");
            animal.Porte = Console.ReadLine();
            Console.WriteLine("Digite o peso do animal:");
            Console.Write(">");
            animal.Peso = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o idade do animal:");
            Console.Write(">");
            animal.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do tutor do animal:");
            Console.Write(">");
            animal.NomeDoTutor = Console.ReadLine();
            Console.WriteLine("Digite o endereço do tutor:");
            Console.Write(">");
            animal.Endereco = Console.ReadLine();
            Console.WriteLine("Digite o telefone para contato:");
            Console.Write(">");
            animal.Telefone = Console.ReadLine();

            repositorio.Cadastrar(animal);
            Console.WriteLine("Animal cadastrado com sucesso!");
            Console.WriteLine();
        }
        private void ListarPets()
        {
            Console.WriteLine();
            foreach (Animal animal in repositorio.Listar())
            {
                animal.Detalhes();
                Console.WriteLine();
            }
        }

        private void AtualizarPet()
        {
            Console.WriteLine();
            Console.WriteLine("Digite o id do pet para atualizar:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Reinsira os dados do animal para atualizar:");

            Animal animal = repositorio.RetornarPorId(id);
            if (animal != null)
            {
                Console.WriteLine("Digite o nome do animal:");
                Console.Write(">");
                animal.Nome = Console.ReadLine();
                Console.WriteLine("Digite o tipo do animal:");
                Console.WriteLine("(1) - Cachorro / (2) - Gato");
                Console.Write(">");
                animal.Tipo = (ETipoAnimal)int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o cor do animal:");
                Console.Write(">");
                animal.Cor = Console.ReadLine();
                Console.WriteLine("Digite o porte do animal:");
                Console.Write(">");
                animal.Porte = Console.ReadLine();
                Console.WriteLine("Digite o peso do animal:");
                Console.Write(">");
                animal.Peso = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o idade do animal:");
                Console.Write(">");
                animal.Idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o nome do tutor do animal:");
                Console.Write(">");
                animal.NomeDoTutor = Console.ReadLine();
                Console.WriteLine("Digite o endereço do tutor:");
                Console.Write(">");
                animal.Endereco = Console.ReadLine();
                Console.WriteLine("Digite o telefone para contato:");
                Console.Write(">");
                animal.Telefone = Console.ReadLine();

                repositorio.Atualizar(id, animal);

                Console.WriteLine("Animal atualizado com sucesso!");
            }
            else
            {
                Console.WriteLine($"Animal com id {id} não existe!");
            }
            Console.WriteLine();
        }
        private void ExcluirPet()
        {
            Console.WriteLine();
            Console.WriteLine("Digite o id do pet para excluir:");
            int id = int.Parse(Console.ReadLine());
            repositorio.Excluir(id);

            Console.WriteLine();
        }
        private void DetalhesPet()
        {
            Console.WriteLine("Detalhes Pet");
            Console.WriteLine();
            Console.WriteLine("Digite o id do pet para ver seus detalhes:");
            int id = int.Parse(Console.ReadLine());
            Animal animal = repositorio.RetornarPorId(id);
            if (animal != null)
            {
                animal.Detalhes();
            }
            else
            {
                Console.WriteLine("Id não existe!");
            }

            Console.WriteLine();
        }
    }
}
