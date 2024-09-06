using mutaFinal.Pages;

namespace mutaFinal.Pages.CodeBehind
{
    public static class ShowFormulaService
    {
        public static void ShowFormula(MutationRate rate)
        {
            GlobalState.Formula = rate.Formula;
            GlobalState.isFormulaVisible = true;
            GlobalState.NotifyStateChanged();
        }
    }
}