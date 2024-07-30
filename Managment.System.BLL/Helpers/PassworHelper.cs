namespace Managment.System.BLL.Helpers;

public class PassworHelper
{
    public const string key = "6c9e6964-7425-40de-944b-e07fc1f91be3";
    public static(string hash, string salt) Hash(string password)
    {
        string salt = GenerateSalt();
        string hash = BCrypt.Net.BCrypt.HashPassword(salt + password + key);
        return (hash: hash, salt: salt);

    }
    public static bool Verify(string password, string hash, string salt)
        => BCrypt.Net.BCrypt.Verify(salt + password + key, hash);
    private static string GenerateSalt()
        => Guid.NewGuid().ToString();
}
