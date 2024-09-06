using mutaFinal.Pages;

namespace mutaFinal.Pages.CodeBehind
{
    public static class OnModalVisibilityChangedService
    {
        public static void OnModalVisibilityChanged(bool isVisible)
        {
            GlobalState.IsModalVisible = isVisible;
        }
    }
}