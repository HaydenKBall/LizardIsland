namespace LizardIsland.Extensions
{
    public static class RngExtension
    {
        public static int RandomNumber(int low, int high)
        {
            Random random = new Random();

            int number = random.Next(low, high);

            return number;
        }
    }
}   
