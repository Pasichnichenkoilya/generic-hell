using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class VehicleProduct : Product, IVehicleProduct
    {
        float maxSpeed;

        public VehicleProduct() { }

        public VehicleProduct(string name, float price, float maxSpeed) : base(name, price)
        {
            SetMaxSpeed(maxSpeed);
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n" +
                $"Max speed: {maxSpeed}";
        }

        public float GetMaxSpeed() => maxSpeed;

        public void SetMaxSpeed(float maxSpeed)
        {
            this.maxSpeed = maxSpeed;
        }
    }
}
