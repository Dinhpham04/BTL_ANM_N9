using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

public static class AESEncryption
{
    public static string Encrypt(string plainText, string key)
    {
        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = Convert.FromBase64String(key);
            aesAlg.GenerateIV();
            aesAlg.Mode = CipherMode.CBC;

            using (ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV))
            {
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    msEncrypt.Write(aesAlg.IV, 0, aesAlg.IV.Length); // Ghi IV vào đầu mảng
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                    }
                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }
    }

    public static string Decrypt(string cipherText, string key)
    {
        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = Convert.FromBase64String(key);
            byte[] cipherBytes = Convert.FromBase64String(cipherText);

            using (MemoryStream msDecrypt = new MemoryStream(cipherBytes))
            {
                byte[] iv = new byte[16];
                msDecrypt.Read(iv, 0, iv.Length); // Lấy IV từ mảng đầu tiên
                aesAlg.IV = iv;

                using (ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV))
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

    public static string EncryptMessage(string message, byte[] key)
    {
        Console.WriteLine(key.Length);
        using (Aes aes = Aes.Create())
        {
            aes.Key = key;
            aes.Mode = CipherMode.ECB;
            aes.Padding = PaddingMode.PKCS7;

            ICryptoTransform encryptor = aes.CreateEncryptor();
            byte[] plainText = Encoding.UTF8.GetBytes(message);
            byte[] cipherText = encryptor.TransformFinalBlock(plainText, 0, plainText.Length);

            return Convert.ToBase64String(cipherText);
        }
    }



    public static string DecryptMessage(string encryptedMessage, byte[] key)
    {
        try
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.Mode = CipherMode.ECB;
                aes.Padding = PaddingMode.PKCS7;
                ICryptoTransform decryptor = aes.CreateDecryptor();
                byte[] cipherText = Convert.FromBase64String(encryptedMessage);
                byte[] plainText = decryptor.TransformFinalBlock(cipherText, 0, cipherText.Length);

                return Encoding.UTF8.GetString(plainText);
            }
        } catch (Exception ex)
        {
            return "0";
        }
    }
    public static byte[] ConvertHexStringTo32ByteArray(string hex)
{
    if (hex.Length % 2 != 0)
    {
        hex = "0" + hex;
    }

    int numberChars = hex.Length;
    byte[] bytes = new byte[numberChars / 2];
    for (int i = 0; i < numberChars; i += 2)
    {
        bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
    }

    byte[] key = new byte[32];
    if (bytes.Length >= 32)
    {
        Array.Copy(bytes, key, 32);
    }
    else
    {
        Array.Copy(bytes, key, bytes.Length);
    }
    return key;
}
   
}

