namespace CountingValleys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 8; 
            string s = "DDUUDDUDUUUD";

            int valleys = countingValleys(n, s);
            Console.WriteLine(valleys);
        }

        public static int countingValleys(int steps, string path)
        {
            int valleyCount = 0;

            int altitude = 0;

            bool inValley = false;

            foreach (char step in path)
            {
                if (step == 'U')
                {
                    altitude++; 
                }
                else if (step == 'D')
                {
                    altitude--; 
                }

                if (altitude < 0 && !inValley)
                {
                    inValley = true;
                }

                if (altitude == 0 && inValley)
                {
                    valleyCount++;
                    inValley = false;
                }
            }

            return valleyCount;
        }

        public int ConvertToStepUpDown(char step)
        {
            switch (step)
            {
                case 'U': return 1;
                default: return -1;
            }         
        }

        
    }
}
