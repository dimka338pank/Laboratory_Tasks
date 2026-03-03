using System;

namespace Task2
{
    /// <summary>
    /// Структура для зберігання результатів розв'язання квадратного рівняння, включаючи кількість коренів та самі корені.
    /// </summary>
    public struct StructResults
    {
        public int AmountOfRoots;
        public double x1;
        public double x2;
    }
    public class SquareSolver
    {
        /// <summary>
        /// Квадратне рівнняня з змінними out параметрами для коренів. Повертає кількість коренів, а також самі корені через out параметри.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="x1"></param>
        /// <param name="x2"></param>
        /// <returns></returns>
        public int SolverWithOut(double a, double b, double c, out double x1, out double x2)
        {
            x1 = x2 = 0;
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c==0)
                        return -1;
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    x1 = -c / b;
                    return 1;
                }
            }
            double d = b * b - 4 * a * c;
            if (d < 0) 
                return 0;
            if (d == 0)
            {
                x1 = -b / (2 * a);
                return 1;
            }

            x1 = (-b + Math.Sqrt(d)) / (2 * a);
            x2 = (-b - Math.Sqrt(d)) / (2 * a);
            return 2;
        }
        /// <summary>
        /// Функція для розв'язання квадратного рівняння, яка повертає результати у вигляді структури StructResults, 
        /// що містить кількість коренів та самі корені. 
        /// Використовує метод SolverWithOut для обчислення коренів та заповнення структури результатів.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public StructResults SolveWithStruct(double a, double b, double c)
        {
            StructResults result = new StructResults();
            double root1, root2;
            int rootsCount = SolverWithOut(a, b, c, out root1, out root2);
            result.AmountOfRoots = rootsCount;
            result.x1 = root1;
            result.x2 = root2;
            return result;
        }
        /// <summary>
        /// 3. Повернення кортежу.
        /// </summary>
        public (int count, double x1, double x2) SolveWithTuple(double a, double b, double c)
        {
            double r1, r2;
            int rootsCount = SolverWithOut(a, b, c, out r1, out r2);
            return (rootsCount, r1, r2);
        }

    }
}
