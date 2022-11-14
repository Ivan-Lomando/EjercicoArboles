using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text;

namespace Library
{

    public class EdadMayor: Visitor<Persona>{
        public int Edad {get;set;} 
        public string mayor {get;set;}

        public override void Visit(Node<Persona> node)
        {
            if( Edad < node.Dato.Edad)
            {
                Edad = node.Dato.Edad;
                mayor = node.Dato.Nombre;
            }
            foreach(Node<Persona> children in node.children){
                children.Accept(this);
            }   
        }







    }


}