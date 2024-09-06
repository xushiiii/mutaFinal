using mutaFinal.Pages;

namespace mutaFinal.Pages.CodeBehind
{
    public static class AInsertionRateService
    {
        public static void AInsertionRate(string content)
        {
            double aCount = 0;
            double sumIS = 0;
            foreach (var line in GlobalState.InsertedSequences)
            {
                var columns = line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
                sumIS += double.Parse(columns[6]);
                if (columns[0][20] == 'A')
                {
                    aCount += double.Parse(columns[6]);
                }
            }
            GlobalState.AInsertionRate = Math.Round((aCount / sumIS) * 100, 2);
        }
    }
}