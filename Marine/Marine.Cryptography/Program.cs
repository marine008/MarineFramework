using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace Marine.Cryptography
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTest();
        }

        static void HashTest()
        {
            //形成某个文件的散列值
            FileStream fileStream = new FileStream(@"D:\studybook\MoreWindows白话经典算法之七大排序第2版.pdf", FileMode.Open);
            SHA1CryptoServiceProvider sha1Provider = new SHA1CryptoServiceProvider();
            byte[] sha1Bytes = sha1Provider.ComputeHash(fileStream);
            string sha1Value = Convert.ToBase64String(sha1Bytes);

            Console.WriteLine(string.Format("sha1 value : {0}", sha1Value));

            //对该散列值进行加密操作
            RSACryptoServiceProvider rsaProvider = new RSACryptoServiceProvider();
            byte[] rsaBytes = rsaProvider.Encrypt(sha1Bytes, true);
            string rsaValue = Convert.ToBase64String(rsaBytes);

            Console.WriteLine(string.Format("rsa value : {0}", rsaValue));

            //对该散列值进行解密操作
            byte[] rsaDBytes = rsaProvider.Decrypt(rsaBytes, true);
            string rsaDValue = Convert.ToBase64String(rsaDBytes);

            Console.WriteLine(string.Format("rsa Decrypt value : {0}", rsaDValue));

            Console.ReadLine();
        }
    }
}
