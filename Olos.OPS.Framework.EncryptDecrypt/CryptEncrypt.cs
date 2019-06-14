using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Olos.OPS.Framework.Core.Interfaces.Crypt;

namespace Olos.OPS.Framework.Crypt
{
    internal sealed class CryptEncrypt : ICryptHelper
    {
        string key = "Key";


   
        private TripleDESCryptoServiceProvider GetTriple()
        {

            var _Md5 = new MD5CryptoServiceProvider();
            var _TripleDes = new TripleDESCryptoServiceProvider();
            byte[] convert = _Md5.ComputeHash(Encoding.ASCII.GetBytes(key));
            _Md5 = null;
            _TripleDes.Key = convert;
            _TripleDes.Mode = CipherMode.ECB;

            return _TripleDes;
        }

        public string Decrypt(string value)
        {
            byte[] convert = Convert.FromBase64String(value);

            string ret = Encoding.ASCII.GetString(GetTriple().CreateDecryptor().TransformFinalBlock(convert, 0, convert.Length));

            return ret;
        }

        public string Encrypt(string value)
        {

            byte[] convert = Encoding.ASCII.GetBytes(value);

            string ret = Convert.ToBase64String(GetTriple().CreateEncryptor().TransformFinalBlock(convert, 0, convert.Length));

            return ret;
        }
    }
}
