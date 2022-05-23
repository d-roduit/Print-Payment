using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ConversionTableManager : IConversionTableManager
    {
        private IConversionTableDB ConversionTableDB { get; }

        public ConversionTableManager(IConversionTableDB conversionTableDB)
        {
            ConversionTableDB = conversionTableDB;
        }

        public ConversionTable GetConversionTable()
        {
            return ConversionTableDB.GetConversionTable();
        }

        public void UpdatePrice(decimal price)
        {
            ConversionTableDB.UpdatePrice(price);
        }
    }
}
