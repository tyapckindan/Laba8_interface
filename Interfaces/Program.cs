internal class Program
{
    private static void Main(string[] args)
    {
        ISpecialTransport ambulance = new Ambulance();
        ISpecialTransport towtruck = new TowTruck();
        ISpecialTransport largecrane = new LargeCrane();

        ambulance.Move();

        towtruck.Move();

        largecrane.Move();
    }
}