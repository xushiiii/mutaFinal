using mutaFinal.Pages;
using mutaFinal.Pages.CodeBehind;
using mutaFinal.Pages.CodeBehind.Utility;
namespace mutaFinal.Pages.CodeBehind
{
    public static class SelectFileService
    {
        public static async Task SelectFile(int rowId)
        {
            GlobalState.IsDataAvailable = false;
            GlobalState.NotifyStateChanged();

            var inputRow = GlobalState.InputRows.FirstOrDefault(r => r.Id == rowId);
            if (inputRow == null)
            {
                GlobalState.NotifyStateChanged();
                return;
            }
            try
            {
                if (GlobalState.FileContents.TryGetValue(rowId, out var content))
                {
                    GlobalState.FileContent = content;

                    TotalEditedReadsService.TotalEditedReads(content);
                    TotalReadsService.TotalReads(content);
                    EditedSequencesService.EditedSequences(content);
                    InsertedSequencesService.InsertedSequences(content);
                    SumInsertedReadsService.SumInsertedReads(content);
                    SumDeletionReadsService.SumDeletionReads(content);
                    RecalculatedTotalEditedReads.RecalculatedTER();
                    MutagenesisRateService.MutagenesisRate(content);
                    OneBpInsertionRateService.OneBpInsertionRate(content);

                    AInsertionRateService.AInsertionRate(content);
                    TInsertionRateService.TInsertionRate(content);
                    CInsertionRateService.CInsertionRate(content);
                    GInsertionRateService.GInsertionRate(content);



                    _1bpDeletionRateService._1bpDeletionRate(content);


                    //SmallDeletionRateService.SmallDeletion(content);


                    NormalizedIndelRateService.NormalizedIndelRate(content);
                    TemplatedOneBpInsertionRateService.TemplatedOneBpInsertionRate(content);
                    NonTemplatedOneBpInsertionRateService.NonTemplatedOneBpInsertionRate(content);

                    GlobalState.IsDataAvailable = true;
                    GlobalState.NotifyStateChanged();
                }
                else
                {
                    GlobalState.NotifyStateChanged();
                    return;
                }
            }
            catch (Exception ex)
            {
                GlobalState.IsDataAvailable = false;
            }
            finally
            {
                GlobalState.NotifyStateChanged();
            }
        }
    }
}