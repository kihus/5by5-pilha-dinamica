using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaDinamica
{
    internal class Pilha
    {
        public Roupa Head { get; set; }

        public Pilha()
        {
            Head = null;
        }

        public bool Vazia()
        {
            if (Head == null)
                return true;
            else
                return false;

        }
        public void InserirPilha(Roupa r)
        {
            if (Vazia())
            {
                Head = r;
            }
            else
            {
                r.Proximo = Head;
                this.Head = r;   
            }
        }

        public Roupa Desempilhar()
        {
            if (Vazia())
            {
                Console.WriteLine("Pilha vazia");
                return null;
            }
            else
            {
                var aux = Head;
                Head = Head.Proximo;
                return aux;
            }
                
        }

        public void MostrarPilha()
        {
            if (Vazia())
            {
                Console.WriteLine("Pilha vazia!");
           
            }
            else
            {
                var aux = Head;
                while(aux != null)
                {
                    Console.WriteLine(aux);
                    aux = aux.Proximo;
                }

            }
            
        }
    }
}
