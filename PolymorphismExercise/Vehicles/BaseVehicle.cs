using System.Globalization;

namespace Vehicles;

public abstract class BaseVehicle : IVehicle
{
    protected BaseVehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
    {
        if (fuelQuantity <= tankCapacity)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            TankCapacity = tankCapacity;
        }
    }

    public double FuelQuantity { get; private set; }
    public double FuelConsumption { get; }
    public double TankCapacity { get; }
    
    protected virtual double ConsumptionIncrease { get; }
    
    public bool Drive(double distance, bool ecoMode) {
        
        double fuelConsumption = this.FuelConsumption;
        if(!ecoMode) fuelConsumption += this.ConsumptionIncrease;
        
        if(distance < 0) throw new ArgumentException("Distance must be a positive number");
        double requiredFuel = distance * fuelConsumption;
        
        if (requiredFuel > this.FuelQuantity) return false;
        this.FuelQuantity -= requiredFuel;
        return true;
    }

    public virtual bool Refuel(double liters)
    {
        if(liters <= 0) throw new ArgumentException("Fuel must be a positive number");
        double newFuelQuantity = FuelQuantity + liters;
        if (newFuelQuantity > TankCapacity) return false;
        FuelQuantity += liters;
        return true;
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}: {this.FuelQuantity.ToString("f2", CultureInfo.InvariantCulture)}";
    }
    
}