using mutaFinal.Pages;

namespace mutaFinal.Pages.CodeBehind
{
    public static class ClearDataService
    {
        public static void ClearData()
        {
            foreach (var item in GlobalState.MutationRates)
            {
                item.Value = 0;
            }
            GlobalState.EditedSequences.Clear();
            GlobalState.InsertedSequences.Clear();
            GlobalState.RecalculatedTER = 0;
            GlobalState.SumDeletionReads = 0;
            GlobalState.TotalATCGReads = 0;
            GlobalState.DashCount = 0;
            GlobalState.isFormulaVisible = false;
            GlobalState.SumEditedReads = 0;
            GlobalState.SumInsertedReads = 0;
            GlobalState.PercentReadsSum = 0;
            GlobalState.ReadsPercentage = 0;
            GlobalState.AInsertionRate = 0;
            GlobalState.OneBpInsertionRate = 0;
            GlobalState.GInsertionRate = 0;
            GlobalState.CInsertionRate = 0;
            GlobalState.NonTemplatedOneBpInsertionRate = 0;
            GlobalState.TemplatedOneBpInsertionRate = 0;
            GlobalState.TInsertionRate = 0;
            GlobalState.OverallMutagenesisRate = 0;
            GlobalState.SmallDeletionRate = 0;
            GlobalState.OneBpDeletionRate = 0;
            GlobalState.TwoBpDeletionRate = 0;
            GlobalState.ThreeBpDeletionRate = 0;
            GlobalState.FourBpDeletionRate = 0;
            GlobalState.FiveBpDeletionRate = 0;
            GlobalState.SixBpDeletionRate = 0;
            GlobalState.SevenBpDeletionRate = 0;
            GlobalState.EightBpDeletionRate = 0;
            GlobalState.NineBpDeletionRate = 0;
            GlobalState.TenBpDeletionRate = 0;
            GlobalState.TotalEditedReads = 0;
        }
    }
}