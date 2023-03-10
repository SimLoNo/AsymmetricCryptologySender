using AsymmetricCryptology;
using System.Text;

Console.WriteLine("Indtast besked");
string originalMessage = Console.ReadLine();
Console.WriteLine("Indtast offentlig nøgle.");
string publicKey = Console.ReadLine();

RsaEncrypter encrypter = new RsaEncrypter();
byte[] encryptedBytes = encrypter.Encrypt(publicKey, originalMessage);
Console.WriteLine("Krypterede besked:");
Console.WriteLine(Convert.ToBase64String(encryptedBytes));
Console.ReadLine(); ;