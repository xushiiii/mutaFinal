using mutaFinal.Pages;

namespace mutaFinal.Pages.CodeBehind
{
    public static class GInsertionRateService
    {
        public static void GInsertionRate(string content)
        {
            double gCount = 0;
            double sumIS = 0;
            foreach (var line in GlobalState.InsertedSequences)
            {
                var columns = line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
                sumIS += double.Parse(columns[6]);
                if (double.Parse(columns[4]) == 1)
                {
                    if (columns[0][20] == 'G')
                    {
                        gCount += double.Parse(columns[6]);
                    }
                }
            }
            GlobalState.GInsertionRate = Math.Round((gCount / sumIS) * 100, 2);
        }
    }
}