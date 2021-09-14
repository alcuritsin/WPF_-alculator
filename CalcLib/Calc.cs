namespace CalcLib
{
    public class Calc : ICalc
    {
        private double buffer = 0;
        //private double memory = 0;

        public void Put_Buffer(double buffer)
        {
            this.buffer = buffer;
        }

        public void Clear_Beffer()
        {
            buffer = 0;
        }

        public double Mul(double value)
        {
            return buffer * value;
        }

        public double Div(double value)
        {
            return buffer / value;
        }

        public double Sum(double value)
        {
            return buffer + value;
        }

        public double Sub(double value)
        {
            return buffer - value;
        }

        public double GetBuffer()
        {
            return buffer;
        }
    }
}