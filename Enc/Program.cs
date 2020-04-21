using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Enc
{
    class Program
    {
        static void Main(string[] args)
        {
            //Json MC examples
            string strc = Get_Value();
            string strc2 = "{\"AMO\":500,\"COM\":1,\"DAT\":\"1508230058706\",\"DES\":\"Venta menudeo\",\"IDC\":\"15f298452d2\",\"REF\":0,\"TYP\":19,\"v\":{\"ACC\":\"5872123456786012\",\"BAN\":\"40127\",\"DEV\":\"0754676270/8\",\"NAM\":\"Rafael Valenzuela Arenas\",\"TYC\":3}}";
            string stringify = "EOLSJWGSjTk69A5Eque6UFl+ozsNMbJCJzcLuaot4X7AgyNX30URLVYCPYKJvYsIuwgvNprNZTdcRulMjOVBRetbolqkPO2ZjmXiR66OmHHI9I1wDHt1maQD7uzFDlllSGRr6VyNNK4Lq/N1XoBlODiUzi/o5zPCxTygXOGJ7MI94BTU90xaOe8RVojN/obKbXAACiUbjuqCWq2wbSYEhZcibdTXHmf1GkGQb/y9sD2K51zLO+4pFxF/YUoV/lbvXF4ZeojERCmu4Yop4x+UJUKl/MTY2X7MYqd0nIrgnQuz8wNAgxGF7Ub2uGJ90W0l3i/FSmxpopLUGRiTY3ZHABplg6H77povwD42SPsSX/3E62rXXcal4Mf/j1m8r0K1HQwc5TdG";

            DemoAES demoAES = new DemoAES();
            Console.WriteLine(demoAES.Encrypt(strc));
            Console.WriteLine("------------------------------------------------------------ Éste es el bueno -> ");
            Console.WriteLine(demoAES.Encrypt(strc2));
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine(demoAES.Encrypt(stringify));
            Console.ReadKey();
        }

        private static string Get_Value()
        {            
            string json = @"{'IDC': '15f298452d2',
                'DES': 'Venta menudeo',
                'AMO': 500,
                'DAT': 1508230058706,'REF': 0,
                'COM': 1,
                'TYP': 19,
                'v': {
                'NAM': 'Rafael Valenzuela Arenas',
                'ACC': '5872123456786012',
                'BAN': 40127,
                'TYC': 3,
                'DEV': '0754676270/8'
                }}";

            var json_str = new JavaScriptSerializer().Serialize(json);

            return json_str;

        }
    }
}
