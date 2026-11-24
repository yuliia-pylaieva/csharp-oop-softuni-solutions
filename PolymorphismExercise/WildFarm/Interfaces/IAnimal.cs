namespace WildFarm.Interfaces;

public interface IAnimal
{
    string Name { get; }
    double Weight { get; }
    int FoodEaten { get; }
    
    string AskForFood();
    bool EatFood(IFood food);
    
    
    
}