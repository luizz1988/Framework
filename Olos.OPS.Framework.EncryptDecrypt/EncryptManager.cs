using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olos.OPS.Framework.Crypt
{
    public class EncryptManager
    {
        #region "Attributes"

        private static readonly Olos.OPS.Framework.Core.Interfaces.Crypt.ICryptHelper _CryptHelper = new CryptEncrypt();

        #endregion

        #region "Properties"

        public static Olos.OPS.Framework.Core.Interfaces.Crypt.ICryptHelper Instance = _CryptHelper;

        #endregion
    }
}
