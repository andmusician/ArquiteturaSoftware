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
        }
    }

    abstract class SistemaPagamentoDosPaises
    {
        public abstract MeiosPagamento RealizaPagamento();
    }

    abstract class MeiosPagamento
    {
        public abstract void Pagar();
    }

    class CartaoCredito : MeiosPagamento
    {
        public override void Pagar()
        {
            throw new NotImplementedException();
        }
    }

    class Pix : MeiosPagamento
    {
        public override void Pagar()
        {
            throw new NotImplementedException();
        }
    }

    class Boleto : MeiosPagamento
    {
        public override void Pagar()
        {
            throw new NotImplementedException();
        }
    }

    class SistemaPagamentoEUA : SistemaPagamentoDosPaises
    {
        public override MeiosPagamento RealizaPagamento()
        {
            throw new NotImplementedException();
        }
    }

    class SistemaPagamentoBrasil : SistemaPagamentoDosPaises
    {
        public override MeiosPagamento RealizaPagamento()
        {
            throw new NotImplementedException();
        }
    }

    class SistemaPagamentoFranca : SistemaPagamentoDosPaises
    {
        public override MeiosPagamento RealizaPagamento()
        {
            throw new NotImplementedException();
        }
    }

    class Client
    {
        private MeiosPagamento _pagamento;

        public Client(SistemaPagamentoDosPaises sistemaPagamentoDosPaises)
        {
            _pagamento = sistemaPagamentoDosPaises.RealizaPagamento();
        }

        public void Run()
        {
            _pagamento.Pagar();
        }

    }
}
