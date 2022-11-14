using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text;

namespace Library
{
    public abstract class Visitor<T>
{

    public abstract void Visit(Node<T> node);
}
}



