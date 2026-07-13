using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personagem p = new Personagem(70,65);
            Pocao v = new Pocao("vida", 25);
            Pocao m = new Pocao("magia", 30);

            Console.WriteLine("antes: ");
            Console.WriteLine($"Vida: {p.Vida} / {p.Vmaxima}");
            Console.WriteLine($"Vida: {p.Magia} / {p.Mmaxima}");

            Console.WriteLine("\nescolha uma poção: ");
            Console.WriteLine("1 - vida");
            Console.WriteLine("2 - magia");

            int opcao = int.Parse(Console.ReadLine());
            if (opcao == 1)
                p.usarPocao(v);
            else
                p.usarPocao(m);

            Console.WriteLine("\ndepois: ");
            Console.WriteLine($"vida: {p.Vida} / {p.Vmaxima}");
            Console.WriteLine($"magia: {p.Magia} / {p.Mmaxima}");

            Console.WriteLine("\nescolha uma poção: ");
            Console.WriteLine("1 - vida");
            Console.WriteLine("2 - magia");

            int opcao1 = int.Parse(Console.ReadLine());
            if (opcao1 == 1)
                p.usarPocao(v);
            else
                p.usarPocao(m);

            Console.WriteLine("\ndepois: ");
            Console.WriteLine($"vida: {p.Vida} / {p.Vmaxima}");
            Console.WriteLine($"magia: {p.Magia} / {p.Mmaxima}");
        }
    }
    public class Personagem
    {
        public int Vmaxima;
        public int Vida;
        public int Mmaxima;
        public int Magia;
        public Personagem(int vida, int magia)
        {
            Vmaxima = 100;
            Vida = vida;
            Mmaxima = 100;
            Magia = magia;
        }
        public void usarPocao(Pocao p)
        {
            if(p.Tipo == "vida")
            {
                Vida += p.Quantidade;
                if(Vida > Vmaxima)
                {
                    Vida = Vmaxima;
                }
            }
            else if (p.Tipo == "magia")
            {
                Magia += p.Quantidade;
                if(Magia > Mmaxima)
                {
                    Magia = Mmaxima;
                }
            }
        }
    }
    public class Pocao
    {
        public string Tipo;
        public int Quantidade;
        public Pocao(string tipo, int quantidade)
        {   
            Tipo = tipo;
            Quantidade = quantidade;
        }
    }
}
