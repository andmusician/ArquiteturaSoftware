using ArquiteturaSoftware.AbstractFactory2;
using ArquiteturaSoftware.FactoryMethod;
using ArquiteturaSoftware.Singleton;

internal class Program
{
    private static void Main(string[] args)
    {
        AbstractFactoryImplementation2.Execute();
        FactoryMethod.Execute();
        Singleton.Execute();
    }
}
