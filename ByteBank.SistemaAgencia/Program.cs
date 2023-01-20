using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
			string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(urlParametros);

			string valor = extrator.GetValor("moedaDestino");
			Console.WriteLine("Valor de moedaDestino: " + valor);

			string valorMoedaOrigem = extrator.GetValor("moedaOrigem");
			Console.WriteLine("Valor de moedaOrigem: " + valorMoedaOrigem);

			Console.WriteLine(extrator.GetValor("VALOR"));

			Console.ReadLine();
		}
    }
}
