using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace CalcLib
{
    public class Logic
    {
        private Calc _calc;
        public string IO { get; private set; } //  Инпут / Оутпут... Дисплей
        public string History { get; private set; } //  История выражений... Дисплей истории

        private double _memory; //  Память калькулятора

        private bool _canExecut; // Можно вычислить?

        private bool _isOperator; //  Введён оператор?
        private bool _isDotPosible; //  Точка ожидается?

        private KeyType _operator; //  

        public string Error;

        public Logic()
        {
            Init();
        }

        private void Init()
        {
            // Сброс всех значений на ноль
            _calc = new Calc();

            IO = "0";
            History = String.Empty;
            Error = String.Empty;

            _memory = 0;
            _isDotPosible = true;
            _isOperator = false;
            _operator = KeyType.Empty;

            _canExecut = false;
        }

        public void PushKey(KeyType key)
        {
            if (IO == "Error" && key != KeyType.C)
            {
                return;
            }

            switch (key)
            {
                case KeyType.Zero:
                    if (_isOperator)
                    {
                        _isOperator = false;
                        IO = String.Empty;
                    }

                    if (IO != "0")
                    {
                        IO += "0";
                    }
                    else
                    {
                        IO = "0";
                    }

                    if (_operator != KeyType.Empty)
                    {
                        _canExecut = true;
                    }

                    break;

                case KeyType.One:
                    if (_isOperator)
                    {
                        _isOperator = false;
                        IO = String.Empty;
                    }

                    if (IO != "0")
                    {
                        IO += "1";
                    }
                    else
                    {
                        IO = "1";
                    }

                    if (_operator != KeyType.Empty)
                    {
                        _canExecut = true;
                    }

                    break;

                case KeyType.Two:
                    if (_isOperator)
                    {
                        _isOperator = false;
                        IO = String.Empty;
                    }

                    if (IO != "0")
                    {
                        IO += "2";
                    }
                    else
                    {
                        IO = "2";
                    }

                    if (_operator != KeyType.Empty)
                    {
                        _canExecut = true;
                    }

                    break;

                case KeyType.Three:
                    if (_isOperator)
                    {
                        _isOperator = false;
                        IO = String.Empty;
                    }

                    if (IO != "0")
                    {
                        IO += "3";
                    }
                    else
                    {
                        IO = "3";
                    }

                    if (_operator != KeyType.Empty)
                    {
                        _canExecut = true;
                    }

                    break;

                case KeyType.Four:
                    if (_isOperator)
                    {
                        _isOperator = false;
                        IO = String.Empty;
                    }

                    if (IO != "0")
                    {
                        IO += "4";
                    }
                    else
                    {
                        IO = "4";
                    }

                    if (_operator != KeyType.Empty)
                    {
                        _canExecut = true;
                    }

                    break;

                case KeyType.Five:
                    if (_isOperator)
                    {
                        _isOperator = false;
                        IO = String.Empty;
                    }

                    if (IO != "0")
                    {
                        IO += "5";
                    }
                    else
                    {
                        IO = "5";
                    }

                    if (_operator != KeyType.Empty)
                    {
                        _canExecut = true;
                    }

                    break;

                case KeyType.Six:
                    if (_isOperator)
                    {
                        _isOperator = false;
                        IO = String.Empty;
                    }

                    if (IO != "0")
                    {
                        IO += "6";
                    }
                    else
                    {
                        IO = "6";
                    }

                    if (_operator != KeyType.Empty)
                    {
                        _canExecut = true;
                    }

                    break;

                case KeyType.Seven:
                    if (_isOperator)
                    {
                        _isOperator = false;
                        IO = String.Empty;
                    }

                    if (IO != "0")
                    {
                        IO += "7";
                    }
                    else
                    {
                        IO = "7";
                    }

                    if (_operator != KeyType.Empty)
                    {
                        _canExecut = true;
                    }

                    break;

                case KeyType.Eight:
                    if (_isOperator)
                    {
                        _isOperator = false;
                        IO = String.Empty;
                    }

                    if (IO != "0")
                    {
                        IO += "8";
                    }
                    else
                    {
                        IO = "8";
                    }

                    if (_operator != KeyType.Empty)
                    {
                        _canExecut = true;
                    }

                    break;

                case KeyType.Nine:
                    if (_isOperator)
                    {
                        _isOperator = false;
                        IO = String.Empty;
                    }

                    if (IO != "0")
                    {
                        IO += "9";
                    }
                    else
                    {
                        IO = "9";
                    }

                    if (_operator != KeyType.Empty)
                    {
                        _canExecut = true;
                    }

                    break;

                case KeyType.Dot:
                    if (_isOperator)
                    {
                        _isOperator = false;
                        IO = "0";
                    }

                    if (_isDotPosible)
                    {
                        if (IO != "0")
                        {
                            IO += ".";
                        }
                        else
                        {
                            IO = "0.";
                        }

                        _isDotPosible = false;
                    }

                    break;

                case KeyType.Div:
                    if (_canExecut)
                    {
                        Execut();
                    }

                    _calc.Put_Buffer(GetIO());
                    if (History == String.Empty)
                    {
                        History += $"{IO}";
                    }

                    _operator = KeyType.Div;
                    _isOperator = true;
                    _isDotPosible = true;
                    break;

                case KeyType.Mul:
                    if (_canExecut)
                    {
                        Execut();
                    }

                    _calc.Put_Buffer(GetIO());
                    if (History == String.Empty)
                    {
                        History += $"{IO}";
                    }

                    _operator = KeyType.Mul;
                    _isOperator = true;
                    _isDotPosible = true;
                    break;

                case KeyType.Sub:
                    if (_canExecut)
                    {
                        Execut();
                    }

                    _calc.Put_Buffer(GetIO());
                    if (History == String.Empty)
                    {
                        History += $"{IO}";
                    }

                    _operator = KeyType.Sub;
                    _isOperator = true;
                    _isDotPosible = true;
                    break;

                case KeyType.Add:
                    if (_canExecut)
                    {
                        Execut();
                    }


                    _calc.Put_Buffer(GetIO());
                    if (History == String.Empty)
                    {
                        History += $"{IO}";
                    }

                    _operator = KeyType.Add;
                    _isOperator = true;
                    _isDotPosible = true;
                    break;

                case KeyType.Enter:
                    if (_canExecut)
                    {
                        Execut();
                    }

                    break;

                case KeyType.CE:
                    CE();
                    break;

                case KeyType.C:
                    Init();
                    break;

                case KeyType.BackSpace:
                    BackSpace();
                    break;

                case KeyType.Empty:
                    break;
            }
        }

        private void CE()
        {
            IO = "0";
        }

        private void BackSpace()
        {
            if (IO.Length == 1)
            {
                IO = "0";
            }
            else
            {
                IO = IO.Remove(IO.Length - 1);
            }
        }

        private double GetIO()
        {
            if (IO == "0")
            {
                return 0;
            }

            double result = 0;
            string io;
            if (IO.Contains("."))
            {
                io = IO.Replace(oldValue: ".", newValue: ",");
            }
            else
            {
                io = IO + ",0";
            }

            try
            {
                result = Convert.ToDouble(io);
            }
            catch (Exception e)
            {
                Error = e.Message;
            }

            return result;
        }

        private string SetIO(double value)
        {
            string specifier = "G";
            string result = value.ToString(specifier, CultureInfo.InvariantCulture);

            return result;
        }

        private void Execut()
        {
            if (_operator == KeyType.Empty)
            {
                return;
            }

            switch (_operator)
            {
                case KeyType.Add:
                    History += $" + {IO}";
                    _memory = _calc.Sum(GetIO());
                    _operator = KeyType.Empty;
                    break;
                case KeyType.Sub:
                    History += $" - {IO}";
                    _memory = _calc.Sub(GetIO());
                    _operator = KeyType.Empty;
                    break;
                case KeyType.Mul:
                    History += $" * {IO}";
                    _memory = _calc.Mul(GetIO());
                    _operator = KeyType.Empty;
                    break;
                case KeyType.Div:
                    History += $" / {IO}";
                    if (IO != "0")
                    {
                        _memory = _calc.Div(GetIO());
                        _operator = KeyType.Empty;
                    }
                    else
                    {
                        IO = "Error";
                    }

                    break;
            }

            if (IO != "Error")
            {
                IO = SetIO(_memory);
            }

            _canExecut = false; // Пока запретить повторное вычисление.
        }
    }
}