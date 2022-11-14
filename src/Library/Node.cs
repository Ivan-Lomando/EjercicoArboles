using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text;

namespace Library
{
    public class Node <T>
    {
        private T dato;
        public List<Node<T>> children = new List<Node<T>>();
        
        public T Dato{

          get{
            return this.dato;
          }  
        }
        public ReadOnlyCollection<Node<T>> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

       public Node (T dato){

            this.dato = dato;

       }
        public void AddChildren(Node<T> t)
        {
            this.children.Add(t);
        }
        
    public void Accept(Visitor<T> visitor)
    {
        visitor.Visit(this);
    }
    
    }
}
