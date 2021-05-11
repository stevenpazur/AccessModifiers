using System;

namespace AccessModifiers {
    class Vehicle {

        protected void getManufacturer() {
            Console.WriteLine("Mitsubishi");
        }

        protected void getModel() {
            Console.WriteLine("Outlander");
        }
    }
}