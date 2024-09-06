namespace mutaFinal.Pages.CodeBehind
{
    public static class OneBpInsertionRateService
    {
        public static void OneBpInsertionRate(string content)
        {
            double sumInsertedReads = 0;
            foreach (var line in GlobalState.EditedSequences)
            {
                var columns = line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
                if (double.Parse(columns[4]) == 1)
                {
                    sumInsertedReads += double.Parse(columns[6]);
                }
            }
            GlobalState.OneBpInsertionRate = Math.Round(sumInsertedReads / GlobalState.RecalculatedTER * 100, 2);
        }
    }
}