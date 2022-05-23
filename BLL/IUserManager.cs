using DTO;

namespace BLL
{
    public interface IUserManager
    {
        User GetUserByUID(int UID);
        User GetUserByUsername(string username);
        void TransferMoneyByUID(int UID, decimal credit);
        void TransferMoneyByUsername(string username, decimal credit);
    }
}