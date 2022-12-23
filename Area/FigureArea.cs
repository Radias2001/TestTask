using System.IO.Pipes;

namespace Area
{
    public class FigureArea
    {
        public double Round(double R)  // метод для вычисления площади круга
        {
            if (R < 0)  // радиус не может быть отрицательным
                throw new ArgumentException("Радиус не может быть отрицательным!");

            double ans = 3.14 * R * R;  //вычисление площади
            return ans;
        }

        public double Triangle(double A, double B, double C)  // метод для вычисления площади треугольника
        {
            if ((A < 0) || (B < 0) || (C < 0))  // сторона не может быть отрицательной
                throw new ArgumentException("Сторона не может быть отрицательной!");

            // для упрощения в "a" и "b" соответсвенно поместилнаибольшее и наименьшее значения, в c - оставшееся
            double a = Math.Max(A, Math.Max(B, C));
                
            double b = Math.Min(A, Math.Min(B, C));

            double c = A + B + C - a - b;

            // треугольник существует только если его наибольшая сторона меньше сумм оставшихся сторон
            if (a > b + c)
                throw new ArgumentException("Такого треугольника не существует!");
            
            // проверка на прямоугольность формулой Пифагора
            if (a == Math.Sqrt(c * c + b * b))
                return (c * b) / 2;

            // формула Герона
            double p = (a + b + c)/2;
            double ans = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return ans;
        }

        public double UnknownFigure(params double[] arr)  // метод для вычисления площади неизвестной фигуры
        {
            switch (arr.Length)  // по количеству переданных аргументов определяем фигуру
            {
                case 1:  // 1 аргумент, значит, вероятнее всего, круг
                    return Round(arr[0]); 
                case 2:  // 2 аргумента, значит, вероятнее всего, прямоугольник
                    if ((arr[0] < 0) || (arr[1] < 0))
                            throw new ArgumentException("Длина не может быть отрицательной");

                    return arr[0] * arr[1];
                case 3:  // 3 аргумента, значит, вероятнее всего, треугольник
                    return Triangle(arr[0], arr[1], arr[2]);
                default:
                    throw new ArgumentException("Для данной фигуры отсутфует функционал");
            }
        }
    }
}