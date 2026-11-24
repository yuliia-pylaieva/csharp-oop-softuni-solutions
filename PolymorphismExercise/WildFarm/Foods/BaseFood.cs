using WildFarm.Interfaces;

namespace WildFarm.Foods;

public class BaseFood  : IFood
{
    protected BaseFood(int quantity)
    {
        Quantity = quantity;
    }

    public int Quantity { get; }
}