using AssymetricCyptologyReciever;
using System;
using System.Text;

var rsa = new RSAWithXmlKey();

const string original = "Text to encrypt";
const string publicKeyPath = "c:\\temp\\publickey.xml";
const string privateKeyPath = "c:\\temp\\privatekey.xml";

Console.WriteLine(File.ReadAllText(publicKeyPath));
Console.ReadLine();