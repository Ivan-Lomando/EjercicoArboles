using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text;

namespace Library
{

    public class SumaEdades: Visitor<Persona>{
        public int sumaedad {get;set;}
        public override void Visit(Node<Persona> node)
        {
            sumaedad += node.Dato.Edad;
            foreach(Node<Persona> children in node.children){
                children.Accept(this);
            }   

        }


    }





}

    

