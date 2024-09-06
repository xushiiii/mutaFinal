using mutaFinal.Pages;

namespace mutaFinal.Pages.CodeBehind.Utility
{
    public static class TotalReadsService
    {
        public static void TotalReads(string content)
        {
            var lines = content.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines.Skip(1))
            {
                var columns = line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
                if (columns[0][20] == 'A' || columns[0][20] == 'T' || columns[0][20] == 'C' || columns[0][20] == 'G')
                {
                    GlobalState.TotalATCGReads += double.Parse(columns[6]);
                }

            }
        }
    }
}