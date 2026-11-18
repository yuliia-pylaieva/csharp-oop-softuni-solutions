using System;
using System.Threading;

namespace NeedForSpeed;

public class Vehicle
{
    private const double DefaultFuelConsumption  = 1.25;
    
    public Vehicle(
        int horsePower,
        double fuel
        )
    {
        this.Fuel = fuel;
        this.HorsePower = horsePower;
    }
    
    public virtual double FuelConsumption => DefaultFuelConsumption;
    public double Fuel { get; private set;  }
    public int HorsePower { get; }
    
    public void Drive(double kilometers)
    {
        if( kilometers <= 0){
            throw new ArgumentException("kilometers must be greater than zero");
        }
        
        this.Fuel -= kilometers * this.FuelConsumption;
    }

    public override string ToString()
    {
        return $"{nameof(FuelConsumption)}={FuelConsumption}, " +
                          $"{nameof(Fuel)}={Fuel}, " +
                          $"{nameof(HorsePower)}={HorsePower}.";
    }
}