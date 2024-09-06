using mutaFinal.Pages;

namespace mutaFinal.Pages.CodeBehind
{
    public static class NonTemplatedOneBpInsertionRateService
    {
        public static void NonTemplatedOneBpInsertionRate(string content)
        {
            GlobalState.NonTemplatedOneBpInsertionRate = 1 - GlobalState.TemplatedOneBpInsertionRate;
        }
    }
}