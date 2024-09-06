using mutaFinal.Pages;

namespace mutaFinal.Pages.CodeBehind.Utility
{
    public static class SumDeletionReadsService
    {
        public static void SumDeletionReads(string content)
        {
            foreach (var line in GlobalState.EditedSequences)
            {
                var columns = line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
                if (double.Parse(columns[3]) != 0)
                {
                    GlobalState.SumDeletionReads += double.Parse(columns[6]);
                }
            }
        }
    }
}