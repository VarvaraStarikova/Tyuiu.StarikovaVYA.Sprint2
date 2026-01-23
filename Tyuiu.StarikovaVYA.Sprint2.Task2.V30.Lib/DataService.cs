using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.StarikovaVYA.Sprint2.Task2.V30.Lib
{
    public class DataService : ISprint2Task2V30
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            x--;
            y--;
            bool[,] array = new bool[15, 15];
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    if (i == 2)
                    {
                        if (j > 1 & j < 5)
                        {
                            array[i, j] = true;
                        }
                        if (j > 7 & j < 12)
                        {
                            array[i, j] = true;
                        }
                    }
                    if (i == 3)
                    {
                        if (j > 0 & j < 5)
                        {
                            array[i, j] = true;
                        }
                        if (j > 7 & j < 12)
                        {
                            array[i, j] = true;
                        }
                    }
                    if (i == 4)
                    {
                        if (j > 0 & j < 12)
                        {
                            array[i, j] = true;
                        }
                    }
                    if (i == 5)
                    {
                        if (j > 0 & j < 13)
                        {
                            array[i, j] = true;
                        }
                    }
                    if (i == 6)
                    {
                        if (j > 1 & j < 13)
                        {
                            array[i, j] = true;
                        }
                    }
                    if (i > 6 & i < 10)
                    {
                        array[i, 5] = true;
                    }
                    if (i == 10)
                    {
                        if (j > 1 & j < 12)
                        {
                            array[i, j] = true;
                        }
                    }
                    if (i == 11)
                    {
                        if (j > 5 & j < 10)
                        {
                            array[i, j] = true;
                        }
                    }
                }
            }
            return array[x, y];
        }
    }
}
