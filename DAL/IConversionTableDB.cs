using DTO;

namespace DAL
{
    public interface IConversionTableDB
    {
        ConversionTable GetConversionTable();
        void UpdatePrice(decimal price);
    }
}