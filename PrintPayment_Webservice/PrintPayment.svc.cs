using DTO;
using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PrintPayment_Webservice
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "PrintPayment" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez PrintPayment.svc ou PrintPayment.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class PrintPayment : IPrintPayment
    {
        private IUserDB UserDB;
        private IConversionTableDB ConversionTableDB;
        private IUserManager UserManager;
        private IConversionTableManager ConversionTableManager;

        public PrintPayment()
        {
            UserDB = new UserDB();
            ConversionTableDB = new ConversionTableDB();
            UserManager = new UserManager(UserDB, ConversionTableDB);
            ConversionTableManager = new ConversionTableManager(ConversionTableDB);
        }

        public ConversionTable GetConversionTable()
        {
            return ConversionTableManager.GetConversionTable();
        }

        public User GetUserByUID(int UID)
        {
            return UserManager.GetUserByUID(UID);
        }

        public User GetUserByUsername(string username)
        {
            return UserManager.GetUserByUsername(username);
        }

        public void TransferMoneyByUID(int UID, decimal credit)
        {
            UserManager.TransferMoneyByUID(UID, credit);
        }

        public void TransferMoneyByUsername(string username, decimal credit)
        {
            UserManager.TransferMoneyByUsername(username, credit);
        }

        public void UpdatePrice(decimal price)
        {
            ConversionTableManager.UpdatePrice(price);
        }
    }
}
