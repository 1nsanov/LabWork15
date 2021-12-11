namespace Task
{
    public class Add : ICalculation
    {
        private double Value { get; set; }

        public Add(double value)
        {
            Value = value;
        }

        public double Perform(double number)
        {
            return number + Value;
        }

        public override string ToString()
        {
            return $"Value: {Value}";
        }
    }
}
