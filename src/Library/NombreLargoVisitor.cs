using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text;

namespace Library
{

    public class NombreLargo: Visitor<Persona>{
        
        public string mayor1 = "";

        public override void Visit(Node<Persona> node)
        {
            if(node.Dato.Nombre.Length > mayor1.Length)
            {
                mayor1 = node.Dato.Nombre;
            }
            foreach(Node<Persona> children in node.children){
                children.Accept(this);
            }   
        }


    }
}