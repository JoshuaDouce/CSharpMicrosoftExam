using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Example3_17SymetricEncryptionAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            EncryptText();
        }

        public static void EncryptText() {
            string original = "Secret message";

            //Symetric Decryption
            using (SymmetricAlgorithm symetricAlgorithm = new AesManaged())
            {
                //Encrypted byte array
                byte[] encrypted = Encrypt(symetricAlgorithm, original);

                //Decrypted Byte array
                string roundtrip = Decrypt(symetricAlgorithm, encrypted);

                Console.WriteLine("Original: {0}", original);
                Console.WriteLine(encrypted.ToString());
                Console.WriteLine("Roundtrip: {0}", roundtrip);
            }
        }

        static byte[] Encrypt(SymmetricAlgorithm aesAlg, string text) {
            ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

            using (MemoryStream msEncrypt = new MemoryStream()) {
                using (CryptoStream cs = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter sw = new StreamWriter(cs)) {
                        sw.Write(text);
                    }

                    return msEncrypt.ToArray();
                }
            }
        }

        static string Decrypt(SymmetricAlgorithm aesAlg, byte[] cipherText) {
            ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

            using (MemoryStream msDecrypt = new MemoryStream(cipherText))
            {
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                {
                    using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                    {
                        return srDecrypt.ReadToEnd();
                    }
                }
            }
        }
    }
}
