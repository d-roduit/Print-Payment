using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PrintPayment_Webservice
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IPrintPayment" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IPrintPayment
    {
        [OperationContract]
        User GetUserByUID(int UID);

        [OperationContract]
        User GetUserByUsername(string username);

        [OperationContract]
        void TransferMoneyByUID(int UID, decimal credit);

        [OperationContract]
        void TransferMoneyByUsername(string username, decimal credit);

        [OperationContract]
        void UpdatePrice(decimal price);

        [OperationContract]
        ConversionTable GetConversionTable();
    }
}
