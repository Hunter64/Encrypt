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
            AesCryptoServiceProvider = new AesCryptoServiceProvider
            {
                BlockSize = 128,
                KeySize = 256
            };
            AesCryptoServiceProvider.GenerateIV();
            AesCryptoServiceProvider.GenerateKey();
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
