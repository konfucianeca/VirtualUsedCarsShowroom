using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsShowroom.Infrastructure.Data.Constants
{
    public static class DataConstants
    {
        // Vehicle
        public const int VehicleModelMaxLenght = 20;
        public const int VehicleModelMinLenght = 3;
        public const int RegionNameMaxLenght = 20;
        public const int RegionNameMinLenght = 3;
        public const int ColorNameMaxLenght = 10;
        public const int ColorNameMinLenght = 3;
        public const int VehicleFeaturesMaxLenght = 500;
        public const int VehicleFeaturesMinLenght = 3;
        public const int VehicleImageUrlMaxLenght = 2083;

        // Manufacturer
        public const int ManufacturerNameMaxLenght = 20;
        public const int ManufacturerNameMinLenght = 2;

        // Customer
        public const int CustomerNameMaxLenght = 50;
        public const int CustomerNameMinLenght = 50;
        public const int CustomerBirthDateMaxLenght = 15;
        public const int CustomerPhoneMaxLenght = 15;
        //public const int CustomerEmailMaxLenght = 100;
        public const int CustomerAddresslMaxLenght = 100;

        // Test drive
        public const int TestNotesMaxLenght = 500;

    }
}
