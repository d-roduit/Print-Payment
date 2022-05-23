using DTO;

namespace DAL
{
    public interface IUserDB
    {
        User GetUserByUID(int UID);
        User GetUserByUsername(string Username);
        void TransferMoneyByUID(int UID, decimal credit);
        void TransferMoneyByUsername(string username, decimal credit);
    }
}