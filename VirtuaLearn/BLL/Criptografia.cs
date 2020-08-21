using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

namespace VirtuaLearn.BLL
{
    public class Criptografia
    {
        public static string getMdIHash(string Senha)
        {  //instancia o objeto  MD5CryptoServiceProvider
            MD5 md5Hasher = MD5.Create();
            //converte a string em uma matriz de bytes calcula o hash 
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(Senha));
            //cria uma nova string para coletar os bytes 
            StringBuilder sBuilder = new StringBuilder();

            //faz um laço em cada dados em hash e formata em string hexadecimal 

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            //retorna a string hexa
            return sBuilder.ToString();
        }
    }
}