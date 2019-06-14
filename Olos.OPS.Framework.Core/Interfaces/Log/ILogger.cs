using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olos.OPS.Framework.Core.Interfaces.Log
{
    public interface ILogger
    {
        //void AlterLogName(string name);

        /// <summary>
        /// Gera Log para o processo de Debug
        /// </summary>
        /// <param name="message">Mensagem q ser gravada</param>
        void Debug(string message);

        /// <summary>
        /// Gera Log para o processo de Info
        /// </summary>
        /// <param name="message">Mensagem q ser gravada</param>
        void Info(string message);

        /// <summary>
        /// Gera Log para o processo de Warning
        /// </summary>
        /// <param name="message">Mensagem q ser gravada</param>
        void Warning(string message);

        /// <summary>
        /// Gera Log para o processo de Erro
        /// </summary>
        /// <param name="message">Mensagem q ser gravada</param>
        void Error(string message);

        /// <summary>
        /// Gera Log para o processo de Error Sobrecarga
        /// </summary>
        /// <param name="message">Mensagem q ser gravada</param>
        void Error(string message, Exception ex);

        /// <summary>
        /// Gera Log para o processo de Error Sobrecarga
        /// </summary>
        /// <param name="message">Mensagem q ser gravada</param>
        void Error(string message, Exception ex, object obj);

    }
}
