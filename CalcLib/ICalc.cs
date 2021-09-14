namespace CalcLib
{
    public interface ICalc
    {
        //  buffer - левый операнд
        //  value - правый операнд
        
        void Put_Buffer(double buffer);  //  Сохранение левого операнда
        void Clear_Beffer();  //  Очистка левого операнда

        double Mul(double value);  //  Умножение (Multiplication) - (buffer * value)
        double Div(double value);  //  Деление (Division) - (buffer / value)
        double Sum(double value);  //  Сложение (Summ) - (buffer + value)
        double Sub(double value);  //  вычитание (Subtraction) - (buffer - value)
    }
}