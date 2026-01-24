using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.StarikovaVYA.Sprint2.Task7.V12.Lib
{
    public class DataService : ISprint2Task7V12
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            bool a = ((x >= 0) && (x <= 2) && (y >= 0) && (y <= 1)); //нижняя закрашенная область
            bool b = ((x <= -2) && (x >= -4) && (y >= 4) && (y <= 6)); //Верхняя закрашенная область
            if (a || b)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
