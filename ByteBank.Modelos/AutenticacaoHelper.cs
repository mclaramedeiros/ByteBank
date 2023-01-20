using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
	public class AutenticacaoHelper
	{
		internal bool CompararSenhas(string senhaTentativa, string senhaVerdadeira)
		{
			return senhaTentativa == senhaVerdadeira;
		}
	}
}
