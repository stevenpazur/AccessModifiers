namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Does not work... as expected!
            
            // Vehicle v = new Vehicle();
            // v.getManufacturer();

            Car c = new Car();
            c.getCar();

            Semi s = new Semi();
            s.getSemi();

            // test different namespace
            AccessModifiersTest.Program prog = new AccessModifiersTest.Program();
            prog.Method1();
        }
    }
}

namespace AccessModifiersTest 
{
    class Program {
        public void Method1() {
            // does not work as expected!
            // AccessModifiers.Vehicle v = new AccessModifiers.Vehicle();
            // v.getManufacturer();

            AccessModifiers.Car c = new AccessModifiers.Car();
            c.getCar();

            AccessModifiers.Semi s = new AccessModifiers.Semi();
            s.getSemi();
        }
    }
}