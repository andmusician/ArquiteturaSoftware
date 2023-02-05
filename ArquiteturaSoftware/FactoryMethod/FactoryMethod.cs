using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquiteturaSoftware.FactoryMethod
{
    internal class FactoryMethod
    {
    }

    abstract class FormaGeometrica
    {
        public abstract double GetArea();
        public abstract double GetPerimetro();
    }

    class Retangulo : FormaGeometrica
    {
        public override double GetArea()
        {
            throw new NotImplementedException();
        }

        public override double GetPerimetro()
        {
            throw new NotImplementedException();
        }
    }

    class Circulo : FormaGeometrica
    {
        public override double GetArea()
        {
            throw new NotImplementedException();
        }

        public override double GetPerimetro()
        {
            throw new NotImplementedException();
        }
    }

    class Triangulo : FormaGeometrica
    {
        public override double GetArea()
        {
            throw new NotImplementedException();
        }

        public override double GetPerimetro()
        {
            throw new NotImplementedException();
        }
    }
}
