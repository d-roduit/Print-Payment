using DTO;

namespace BLL
{
    public interface IConversionTableManager
    {
        ConversionTable GetConversionTable();
        void UpdatePrice(decimal price);
    }
}