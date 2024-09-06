using mutaFinal.Pages;

namespace mutaFinal.Pages.CodeBehind.Utility
{
    public static class InsertedSequencesService
    {
        public static void InsertedSequences(string content)
        {
            foreach (var line in GlobalState.EditedSequences)
            {
                var columns = line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
                if (double.Parse(columns[4]) == 1)
                {
                    GlobalState.InsertedSequences.Add(line);
                }
            }
        }
    }
}
