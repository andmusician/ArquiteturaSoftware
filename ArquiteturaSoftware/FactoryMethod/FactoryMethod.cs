using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquiteturaSoftware.FactoryMethod
{
    internal class FactoryMethod
    {
        public static void Execute()
        {
            CriadorFormasGeometricas[] criadorFormasGeometricas = new CriadorFormasGeometricas[3];

            criadorFormasGeometricas[0] = new CriadorCirculos();
            criadorFormasGeometricas[1] = new CriadorRetangulos();
            criadorFormasGeometricas[2] = new CriadorTriangulos();

            foreach (var item in criadorFormasGeometricas)
            {
                FormaGeometrica formaGeometrica = item.FabricaFormaGeometrica();
                Console.WriteLine("Result: {0}, {1}", formaGeometrica.GetArea(), formaGeometrica.GetPerimetro());
            }

            Console.ReadKey();
        }
    }

    abstract class CriadorFormasGeometricas
    {
        public abstract FormaGeometrica FabricaFormaGeometrica();
    }

    class CriadorCirculos : CriadorFormasGeometricas
    {
        public override FormaGeometrica FabricaFormaGeometrica()
        {
            return new Circulo();
        }
    }

    class CriadorRetangulos : CriadorFormasGeometricas
    {
        public override FormaGeometrica FabricaFormaGeometrica()
        {
            return new Retangulo();
        }
    }

    class CriadorTriangulos : CriadorFormasGeometricas
    {
        public override FormaGeometrica FabricaFormaGeometrica()
        {
            return new Triangulo();
        }
    }

    abstract class FormaGeometrica
    {
        public abstract string GetArea();
        public abstract string GetPerimetro();
    }

    class Retangulo : FormaGeometrica
    {
        public override string GetArea()
        {
            return "Area do Retangulo";
        }

        public override string GetPerimetro()
        {
            return "Perimetro do Retangulo";
        }
    }

    class Circulo : FormaGeometrica
    {
        public override string GetArea()
        {
            return "Area do circulo";
        }

        public override string GetPerimetro()
        {
            return "Perimetro do circulo";
        }
    }

    class Triangulo : FormaGeometrica
    {
        public override string GetArea()
        {
            return "Area do triangulo";
        }

        public override string GetPerimetro()
        {
            return "Perimetro do triangulo";
        }
    }
}
