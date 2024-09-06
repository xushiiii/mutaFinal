using mutaFinal.Pages;

namespace mutaFinal.Pages.CodeBehind
{
    public static class AddNewRowService
    {
        public static void AddNewRow()
        {
            GlobalState.InputRows.Add(new InputRow { Id = GlobalState.NextRowId++ });
            GlobalState.NotifyStateChanged();
        }
    }
}