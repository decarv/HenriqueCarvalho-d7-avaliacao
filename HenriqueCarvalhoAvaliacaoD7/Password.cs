
namespace D7
{
    internal class Password
    {
        static public byte[] ComputeHash(string password)
        {
            byte[] passBytes = System.Text.UnicodeEncoding.UTF8.GetBytes(password);
            System.Security.Cryptography.SHA256? hashAlgorithm = System.Security.Cryptography.SHA256.Create();
            byte[] hash = hashAlgorithm.ComputeHash(passBytes);
            return hash;
        }
    }
}
