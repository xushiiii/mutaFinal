using mutaFinal.Pages;

namespace mutaFinal.Pages.CodeBehind.Utility
{
    public static class SumInsertedReadsService
    {
        public static void SumInsertedReads(string content)
        {
            foreach (var line in GlobalState.InsertedSequences)
            {
                var columns = line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
                GlobalState.SumInsertedReads += double.Parse(columns[6]);
            }
        }
    }
}