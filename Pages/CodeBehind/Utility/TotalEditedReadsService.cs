using mutaFinal.Pages;

namespace mutaFinal.Pages.CodeBehind.Utility
{
    public static class TotalEditedReadsService
    {
        public static void TotalEditedReads(string content)
        {
            var lines = content.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                var columns = line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
                if (columns[2] == "False")
                {
                    GlobalState.TotalEditedReads += double.Parse(columns[6]);
                }
            }
        }
    }
}