namespace MySchedule.Domain.Security.PasswordHashing;

public interface IPasswordHasher
{
    string HashPassword(string password);
    bool VeriryPassword(string password, string passwordHash);
}