namespace LeetCodeSolutions
{
    public class ParkingSystem
    {
        private int[] _parkingAvailable = new int[4];

        public ParkingSystem(int big, int medium, int small)
        {
            _parkingAvailable[1] = big;
            _parkingAvailable[2] = medium;
            _parkingAvailable[3] = small;
        }

        public bool AddCar(int carType)
        {
            if (_parkingAvailable[carType] > 0)
            {
                _parkingAvailable[carType]--;
                return true;
            }

            return false;
        }
    }

    /**
     * Your ParkingSystem object will be instantiated and called as such:
     * ParkingSystem obj = new ParkingSystem(big, medium, small);
     * bool param_1 = obj.AddCar(carType);
     */
}