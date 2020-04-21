using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Enc
{
    class DemoAES
    {
        AesCryptoServiceProvider AesCryptoServiceProvider;

        public DemoAES()
        {
            byte[] key = { 63, 145, 10, 166, 158, 126, 221, 10, 161, 193, 40, 94, 221, 6, 226, 252 };
            byte[] IV = { 161, 238, 253, 121, 130, 149, 95, 147, 101, 121, 230, 136, 23, 11, 173, 6 };

            AesCryptoServiceProvider = new AesCryptoServiceProvider
            {
                BlockSize = 128,
                KeySize = 128,
                Key = key,
                IV = IV
            };
            //AesCryptoServiceProvider.GenerateIV();
            //AesCryptoServiceProvider.GenerateKey();
            AesCryptoServiceProvider.Mode = CipherMode.CBC;
            AesCryptoServiceProvider.Padding = PaddingMode.PKCS7;
        }

        public string Encrypt(String text)
        {
            ICryptoTransform cryptoTransform = AesCryptoServiceProvider.CreateEncryptor();
            byte[] vs = cryptoTransform.TransformFinalBlock(ASCIIEncoding.ASCII.GetBytes(text), 0, text.Length);
            string str = Convert.ToBase64String(vs);
            return str;
        }

    }
}
