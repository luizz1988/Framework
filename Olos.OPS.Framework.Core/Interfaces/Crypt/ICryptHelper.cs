using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olos.OPS.Framework.Core.Interfaces.Crypt
{
   public interface ICryptHelper
    {
        /// <summary>
        /// Efetua a conversão da criptografia
        /// </summary>
        /// <param name="value">valor para descriptografar</param>
        /// <returns>Retorno do processo</returns>
        string Decrypt(string value);

        /// <summary>
        /// Efetua a criptografia 
        /// </summary>
        /// <param name="value">valor para descriptografar</param>
        /// <returns>Retorno do processo</returns>
        string Encrypt(string value);


    }
}
