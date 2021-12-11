namespace Task
{
    public class Multiply : ICalculation
    {
        private double Value { get; set; }

        public Multiply(double value)
        {
            Value = value;
        }

        public double Perform(double number)
        {
            return number * Value;
        }

        public override string ToString()
        {
            return $"Value: {Value}";
        }
    }
}
