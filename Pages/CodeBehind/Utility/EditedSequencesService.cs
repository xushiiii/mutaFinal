using mutaFinal.Pages;

namespace mutaFinal.Pages.CodeBehind.Utility
{
    public static class EditedSequencesService
    {
        public static void EditedSequences(string content)
        {
            var lines = content.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines.Skip(1))
            {
                var columns = line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
                if (columns[2] == "False")
                {
                    if ((double.Parse(columns[6]) / GlobalState.TotalEditedReads * 100) >= 0.2)
                    {
                        GlobalState.EditedSequences.Add(line);
                    }
                }
            }
        }
    }
}