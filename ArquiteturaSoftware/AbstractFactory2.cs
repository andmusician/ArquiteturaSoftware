using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquiteturaSoftware
{
    internal class AbstractFactoryImplementation2
    {
        public static void Execute()
        {
            SistemaPagamentoDosPaises Eua = new SistemaPagamentoEUA();
            Client client = new Client(Eua);
            client.Run();

            SistemaPagamentoDosPaises Brasil = new SistemaPagamentoBrasil();
            client = new Client(Brasil);
            client.Run();

            SistemaPagamentoDosPaises Franca = new SistemaPagamentoFranca();
            client = new Client(Franca);
            client.Run();
        }
    }

    abstract class SistemaPagamentoDosPaises
    {
        public abstract CartaoCredito GetCartaoCredito();
        public abstract Pix GetPix();
        public abstract Boleto GetBoleto();
    }    

    class CartaoCredito 
    {
        
    }

    class Pix 
    {
        
    }

    class Boleto 
    {
       
    }

    class BoletoBrasil : Boleto
    {

    }

    class BoletoEUA : Boleto
    {

    }

    class BoletoFranca : Boleto
    {

    }

    class PixBrasil : Pix
    {

    }

    class PixEUA : Pix
    {

    }

    class PixFranca : Pix
    {

    }

    class CartaoCreditoBrasil : CartaoCredito
    {

    }

    class CartaoCreditoEUA : CartaoCredito
    {

    }

    class CartaoCreditoFranca : CartaoCredito
    {

    }

    class SistemaPagamentoEUA : SistemaPagamentoDosPaises
    {
        public override Boleto GetBoleto()
        {
            return new BoletoEUA();
        }

        public override CartaoCredito GetCartaoCredito()
        {
            return new CartaoCreditoEUA();
        }

        public override Pix GetPix()
        {
            return new PixEUA();
        }
    }

    class SistemaPagamentoBrasil : SistemaPagamentoDosPaises
    {
        public override Boleto GetBoleto()
        {
            return new BoletoBrasil();
        }

        public override CartaoCredito GetCartaoCredito()
        {
            return new CartaoCreditoBrasil();
        }

        public override Pix GetPix()
        {
            return new PixBrasil();
        }
    }

    class SistemaPagamentoFranca : SistemaPagamentoDosPaises
    {
        public override Boleto GetBoleto()
        {
            return new BoletoFranca();
        }

        public override CartaoCredito GetCartaoCredito()
        {
            return new CartaoCreditoFranca();
        }

        public override Pix GetPix()
        {
            return new PixFranca();
        }
    }

    class Client
    {
        private SistemaPagamentoDosPaises _pagamentos;

        public Client(SistemaPagamentoDosPaises sistemaPagamentoDosPaises)
        {
            _pagamentos = sistemaPagamentoDosPaises;
        }

        public void Run()
        {
            CartaoCredito cartaoCredito = _pagamentos.GetCartaoCredito();
            Boleto boleto = _pagamentos.GetBoleto();
            Pix pix = _pagamentos.GetPix();
        }

    }
}
