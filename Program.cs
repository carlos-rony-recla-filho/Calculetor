using System;
using System.Diagnostics;

namespace Calculator // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        enum opcoes {A=1,B,C,D,}
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Bem Vindo ao Calculetor:\n[1]Somar\n[2]Subtrair\n[3]Multiplicar\n[4]Dividir");

            int index = int.Parse(Console.ReadLine());
            opcoes opcaoSelecionada = (opcoes)index;

            switch(opcaoSelecionada){
                case opcoes.A:
                Somar();
                break;
                case opcoes.B:
                Subtrair();
                break;
                case opcoes.C:
                Multiplicar();
                break;
                case opcoes.D:
                Dividir();
                break;
            }
            Console.ReadLine();
            Console.Clear();
        }
        static void Somar(){
            Console.Clear();
            
            Console.WriteLine("Digite o primeiro valor:");
            int vl1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o Segundo valor:");
            int vl2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"O Resiltado é {vl1+vl2}");

        }

        static void Subtrair(){
            Console.Clear();
            
            Console.WriteLine("Digite o primeiro valor:");
            int vl1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o Segundo valor:");
            int vl2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"O Resiltado é {vl1-vl2}");

        }

        static void Multiplicar(){
            Console.Clear();
            
            Console.WriteLine("Digite o primeiro valor:");
            int vl1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o Segundo valor:");
            int vl2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"O Resiltado é {vl1*vl2}");

        }

        static void Dividir(){
            Console.Clear();
            
            Console.WriteLine("Digite o primeiro valor:");
            int vl1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o Segundo valor:");
            int vl2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"O Resiltado é {vl1/vl2}");

        }
    }
}