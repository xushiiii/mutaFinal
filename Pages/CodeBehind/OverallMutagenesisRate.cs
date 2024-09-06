using mutaFinal.Pages;

namespace mutaFinal.Pages.CodeBehind
{
    public static class MutagenesisRateService
    {
        public static void MutagenesisRate(string content)
        {
            double totalReads = 0;
            var lines = content.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines.Skip(1))
            {
                var columns = line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
                totalReads += double.Parse(columns[6]);
            }
            GlobalState.OverallMutagenesisRate = Math.Round((GlobalState.TotalEditedReads / totalReads) * 100, 2);
        }
    }
}