using mutaFinal.Pages;

namespace mutaFinal.Pages.CodeBehind
{
    public static class TInsertionRateService
    {
        public static void TInsertionRate(string content)
        {
            double tCount = 0;
            double sumIS = 0;
            foreach (var line in GlobalState.InsertedSequences)
            {
                var columns = line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
                sumIS += double.Parse(columns[6]);
                if (columns[0][20] == 'T')
                {
                    tCount += double.Parse(columns[6]);
                }
            }
            GlobalState.TInsertionRate = Math.Round((tCount / sumIS) * 100, 2);
        }
    }
}