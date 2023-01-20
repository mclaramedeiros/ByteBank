using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(2000, cpf)
        {
        }

        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }
		// auxiliar é derivado de funcionario e pode usar o metodo GetBonificacao
        // e sobreescrevê-lo. se o metodo pai é internal o filho deve ser também 
		internal protected override double GetBonificacao()
        {
            return Salario * 0.2;
        }
    }
}
