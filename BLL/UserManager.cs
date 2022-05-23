using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserManager : IUserManager
    {
        private IUserDB UserDB { get; }
        private IConversionTableDB ConversionTableDB { get; }

        public UserManager(IUserDB userDB, IConversionTableDB conversionTableDB)
        {
            UserDB = userDB;
            ConversionTableDB = conversionTableDB;
        }

        public User GetUserByUID(int UID)
        {
            User user = UserDB.GetUserByUID(UID);

            if (user == null) return null;

            ConversionTable conversionTable = ConversionTableDB.GetConversionTable();

            if (conversionTable == null) return null;

            decimal pricePerSheet = conversionTable.Price;
            decimal userCredit = user.Credit;

            if (userCredit == 0)
            {
                user.NbSheets = 0;
            } else
            {
                user.NbSheets = (int)Math.Floor(userCredit / pricePerSheet);
            }

            return user;
        }

        public User GetUserByUsername(string username)
        {
            User user = UserDB.GetUserByUsername(username);

            if (user == null) return null;

            ConversionTable conversionTable = ConversionTableDB.GetConversionTable();

            if (conversionTable == null) return null;

            decimal pricePerSheet = conversionTable.Price;
            decimal userCredit = user.Credit;

            if (userCredit == 0)
            {
                user.NbSheets = 0;
            }
            else
            {
                user.NbSheets = (int)Math.Floor(userCredit / pricePerSheet);
            }

            return user;
        }

        public void TransferMoneyByUID(int UID, decimal credit)
        {
            UserDB.TransferMoneyByUID(UID, credit);
        }

        public void TransferMoneyByUsername(string username, decimal credit)
        {
            UserDB.TransferMoneyByUsername(username, credit);
        }
    }
}
