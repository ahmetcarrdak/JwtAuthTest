using System.Security.Cryptography;
using System.Text;

public class KeyGenerator
{
    public static string GenerateKey()
    {
        using (var rng = new RNGCryptoServiceProvider())
        {
            var byteKey = new byte[32]; // 256 bit anahtar için 32 byte
            rng.GetBytes(byteKey);
            return Convert.ToBase64String(byteKey);
        }
    }
}