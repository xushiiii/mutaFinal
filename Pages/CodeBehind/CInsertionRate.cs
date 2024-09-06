using mutaFinal.Pages;

namespace mutaFinal.Pages.CodeBehind
{
    public static class CInsertionRateService
    {
        public static void CInsertionRate(string content)
        {
            double cCount = 0;
            double sumIS = 0;
            foreach (var line in GlobalState.InsertedSequences)
            {
                var columns = line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
                sumIS += double.Parse(columns[6]);
                if (columns[0][20] == 'C')
                {
                    cCount += double.Parse(columns[6]);
                }
            }
            GlobalState.CInsertionRate = Math.Round((cCount / sumIS) * 100, 2);
        }
    }
}