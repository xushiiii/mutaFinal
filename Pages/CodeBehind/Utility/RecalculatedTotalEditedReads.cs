using mutaFinal.Pages;

namespace mutaFinal.Pages.CodeBehind.Utility
{
    public static class RecalculatedTotalEditedReads
    {
        public static void RecalculatedTER()
        {
            foreach (var item in GlobalState.EditedSequences)
            {
                var columns = item.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
                GlobalState.RecalculatedTER += double.Parse(columns[6]);
            }
        }

    }
}