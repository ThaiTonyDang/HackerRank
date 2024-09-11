namespace GradingStudents
{
    internal class Program
    {
        public static List<int> GradingStudents(List<int> grades)
        {
            List<int> result = new();
            foreach (int grade in grades)
            {
                if(grade < 38)
                {
                    result.Add(grade);
                }
                else
                {
                    var mul = GetNextMultipleOf5(grade);
                    if (mul - grade < 3)
                    {
                        result.Add(mul);
                    }
                    else
                    {
                        result.Add(grade);
                    }
                }
            }

            return result;
        }

        public static int GetNextMultipleOf5(int number)
        {
            var mul = number;
            while (mul % 5 != 0)
            {
                mul++;
            }
            return mul;
        }

        public static void Main(string[] args)
        {
            List<int> grades = [74, 75, 33, 38, 67, 43];

            List<int> result = GradingStudents(grades);
            foreach (var grade in result)
            {
                Console.WriteLine(grade);
            }
        }
    }
}
