namespace OOBootcamp
{
    public class SmartParkingBoy
    {
        private readonly ParkingLot[] parkingLots;

        public SmartParkingBoy(params ParkingLot[] parkingLots)
        {
            this.parkingLots = parkingLots;
        }

        public int Park(Car car)
        {
            var parkingLotWithMostVacancyCount = new VacancyCountParkingLotFinder().FindParkingLot(parkingLots);
            return parkingLotWithMostVacancyCount.Park(car);
        }

        public Car Pick(int ticket)
        {
            foreach (var parkingLot in parkingLots)
            {
                try
                {
                    return parkingLot.Pick(ticket);
                }
                catch (NoCarException e)
                {
                    continue;
                }
            }
            throw new NoCarException();
        }
    }
}