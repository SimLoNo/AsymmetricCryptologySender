using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AsymmetricCryptology
{
	public class RsaEncrypter
	{
		public byte[] Encrypt(string publicKey, string originalMessage)
		{
			byte[] bytedMessage = Encoding.UTF8.GetBytes(originalMessage);
			byte[] encryptedMessage;
			using (var rsa = new RSACryptoServiceProvider(2048))
			{
				rsa.PersistKeyInCsp = false;
				rsa.FromXmlString(publicKey);

                encryptedMessage = rsa.Encrypt(bytedMessage, false);
			}
			return encryptedMessage;

		}
	}
}
