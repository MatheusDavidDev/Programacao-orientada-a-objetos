using System;

namespace Nova_pasta2
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem personagem1 = new Personagem();

            personagem1.nome = "Matheus David";
            personagem1.idade = 18;
            personagem1.armadura = "Armadura de fogo";

            Personagem personagem2 = new Personagem();

            personagem2.nome = "Pereira";
            personagem2.idade = 20;
            personagem2.armadura = "Voadora";

            Console.WriteLine($"Personagem 1 ={personagem1.nome} - {personagem1.Atacar()}");

            Console.WriteLine($"Personagem 1 ={personagem2.nome} - {personagem2.Defender()}");
        }
    }
}
