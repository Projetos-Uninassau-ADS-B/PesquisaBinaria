using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesquisaBinaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criação de uma lista com todos as fichas dispostas em ordem alfabética dos sobrenomes dos pacientes cadastrados
            
            
            string[] nomes = {"Abreu", "Aguiar", "Albuquerque", "Almeida", "Amaral", "Andrade", "Antunes", "Araújo", "Azevedo",
"Barbosa", "Batista", "Bezerra", "Borges", "Brandão", "Brito", "Bueno", "Buzatti",
"Campos", "Cardoso", "Carvalho", "Castro", "Cavalcante", "Coelho", "Correia", "Costa", "Coutinho", "Cruz",
"Damasceno", "Dantas", "Dias", "Diniz", "Domingues", "Duarte",
"Esteves", "Evangelista",
"Fagundes", "Farias", "Fernandes", "Ferraz", "Ferreira", "Figueiredo", "Fonseca", "Fraga", "Freitas",
"Garcia", "Gonçalves", "Gomes", "Guedes", "Guimarães",
"Henriques", "Holanda", "Homem",
"Inácio", "Irmão",
"Jardim", "Jesus", "Junqueira",
"Klein", "Krause",
"Lacerda", "Leal", "Leite", "Lima", "Lopes", "Luz",
"Machado", "Magalhães", "Marques", "Martins", "Medeiros", "Melo", "Miranda", "Monteiro", "Moraes", "Moura",
"Nascimento", "Navarro", "Neves", "Nogueira",
"Oliveira", "Ornelas",
"Pacheco", "Peixoto", "Pereira", "Pinto", "Porto", "Prado",
"Queiroz",
"Ramos", "Reis", "Ribeiro", "Rocha", "Rodrigues", "Sampaio", "Santana", "Santos", "Silva", "Souza", "Teixeira", "Torres",
"Uchoa", "Valente", "Vasconcelos", "Vieira", "Wagner", "Xavier", "Yamamoto", "Zanetti" };
            
            
            
            string procurado = "Silva";

            // Criação de variáveis inteiras denominadas início, fim e meio
            int inicio = 0;
            int fim = nomes.Length - 1;
            int meio;

            // Criação de uma variável que servirá como contador para que seja verificada a quantidade de passos realizados até encontrar a ficha correspondente
            int contadorPassos = 0;

            // Criação de uma variável que traz a situação atual da problemática
            bool achou = false;

            // Utilização de um laço que vai ser executado até que a variável início seja maior do que a variável fim ou caso a variável "achou" possua valor "true"
            while (inicio <= fim && !achou)
            {
                // Cálculo para encontrar a posição do meio da lista
                meio = (inicio + fim) / 2;
                contadorPassos++;

                // Condicional para alterar o fluxo do código a depender da comparação de valores
                if (nomes[meio] == procurado)
                {
                    achou = true;
                    Console.WriteLine($"A ficha do paciente Silva foi encontrada na posição {meio + 1} em {contadorPassos} passos!");
                }
                else if (string.Compare(nomes[meio], procurado) < 0)
                {
                    inicio = meio + 1;
                }
                else
                {
                    fim = meio - 1;
                }
            }

            if (!achou)
            {
                Console.WriteLine("A ficha do paciente não foi encontrada!");
            }
        }
    }
}
