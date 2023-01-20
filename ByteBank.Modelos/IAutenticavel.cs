using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public interface IAutenticavel
    {
        // contrato que assegura que as classes que implementam
        // essa interace vão possuir um método public que retorna um bool que
        // se chama autenticar e recebe string como argumento
        bool Autenticar(string senha);
    }
}
