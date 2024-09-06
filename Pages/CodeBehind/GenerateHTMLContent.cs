using System.Text;
using mutaFinal.Pages;

namespace mutaFinal.Pages.CodeBehind
{
    public static class GenerateHTMLContentService
    {
        public static string GenerateHTMLContent()
        {
            GlobalState.UpdateMutationRates();
            GlobalState.NotifyStateChanged();
            StringBuilder htmlBuilder = new StringBuilder();

            htmlBuilder.AppendLine("<html>");
            htmlBuilder.AppendLine("<head><title>Mutagenesis Profile Report</title></head>");
            htmlBuilder.AppendLine("<body>");

            htmlBuilder.AppendLine("<h1>Mutagenesis Profile Report</h1>");
            htmlBuilder.AppendLine($"<p><strong>Plasmid Id:</strong> {GlobalState.SelectedRow.PlasmidID} ");
            htmlBuilder.AppendLine($"<strong>Genotype:</strong> {GlobalState.SelectedRow.Genotype} ");
            htmlBuilder.AppendLine($"<strong>Target Size:</strong> {GlobalState.SelectedRow.TargetSite} ");
            htmlBuilder.AppendLine($"<strong>Replicate:</strong> {GlobalState.SelectedRow.Rep} ");
            htmlBuilder.AppendLine($"<strong>Fourth Nucleotide:</strong> {GlobalState.SelectedRow.FourthNucleotide}</p>");

            htmlBuilder.AppendLine($"<p>Mutagenesis Rate: {GlobalState.OverallMutagenesisRate}</p>");

            htmlBuilder.AppendLine("<h2>1-bp Insertion Profile</h2>");
            htmlBuilder.AppendLine($"<p>1-bp Insertion Rate: {GlobalState.OneBpInsertionRate}</p>");
            htmlBuilder.AppendLine($"<p>A Insertion Rate: {GlobalState.AInsertionRate}</p>");
            htmlBuilder.AppendLine($"<p>T Insertion Rate: {GlobalState.TInsertionRate}</p>");
            htmlBuilder.AppendLine($"<p>C Insertion Rate: {GlobalState.CInsertionRate}</p>");
            htmlBuilder.AppendLine($"<p>G Insertion Rate: {GlobalState.GInsertionRate}</p>");
            htmlBuilder.AppendLine($"<p>Templated 1-bp Insertion Rate: {GlobalState.TemplatedOneBpInsertionRate}</p>");
            htmlBuilder.AppendLine($"<p>Non-Templated 1-bp Insertion Rate: {GlobalState.NonTemplatedOneBpInsertionRate}</p>");

            htmlBuilder.AppendLine("<h2>Deletion Profile</h2>");
            htmlBuilder.AppendLine($"<p>Small Deletion Rate: {GlobalState.SmallDeletionRate}</p>");
            htmlBuilder.AppendLine($"<p>1-bp Deletion Rate: {GlobalState.OneBpDeletionRate}</p>");
            htmlBuilder.AppendLine($"<p>2-bp Deletion Rate: {GlobalState.TwoBpDeletionRate}</p>");
            htmlBuilder.AppendLine($"<p>3-bp Deletion Rate: {GlobalState.ThreeBpDeletionRate}</p>");
            htmlBuilder.AppendLine($"<p>4-bp Deletion Rate: {GlobalState.FourBpDeletionRate}</p>");
            htmlBuilder.AppendLine($"<p>5-bp Deletion Rate: {GlobalState.FiveBpDeletionRate}</p>");
            htmlBuilder.AppendLine($"<p>6-bp Deletion Rate: {GlobalState.SixBpDeletionRate}</p>");
            htmlBuilder.AppendLine($"<p>7-bp Deletion Rate: {GlobalState.SevenBpDeletionRate}</p>");
            htmlBuilder.AppendLine($"<p>8-bp Deletion Rate: {GlobalState.EightBpDeletionRate}</p>");
            htmlBuilder.AppendLine($"<p>9-bp Deletion Rate: {GlobalState.NineBpDeletionRate}</p>");
            htmlBuilder.AppendLine($"<p>10-bp Deletion Rate: {GlobalState.TenBpDeletionRate}</p>");

            htmlBuilder.AppendLine("<h2>Normalized Indel Rate</h2>");
            htmlBuilder.AppendLine($"<p>1-bp Deletion Rate: {GlobalState.OneDeletionRate}</p>");
            htmlBuilder.AppendLine($"<p>2-bp Deletion Rate: {GlobalState.TwoDeletionRate}</p>");
            htmlBuilder.AppendLine($"<p>3-bp Deletion Rate: {GlobalState.ThreeDeletionRate}</p>");
            htmlBuilder.AppendLine($"<p>4-bp Deletion Rate: {GlobalState.FourDeletionRate}</p>");
            htmlBuilder.AppendLine($"<p>5-bp Deletion Rate: {GlobalState.FiveDeletionRate}</p>");
            htmlBuilder.AppendLine($"<p>6-bp Deletion Rate: {GlobalState.SixDeletionRate}</p>");
            htmlBuilder.AppendLine($"<p>7-bp Deletion Rate: {GlobalState.SevenDeletionRate}</p>");
            htmlBuilder.AppendLine($"<p>8-bp Deletion Rate: {GlobalState.EightDeletionRate}</p>");
            htmlBuilder.AppendLine($"<p>9-bp Deletion Rate: {GlobalState.NineDeletionRate}</p>");
            htmlBuilder.AppendLine($"<p>10-bp Deletion Rate: {GlobalState.TenDeletionRate}</p>");
            htmlBuilder.AppendLine($"<p>1-bp Insertion Rate: {GlobalState.OneInsertionRate}</p>");
            htmlBuilder.AppendLine($"<p>2-bp Insertion Rate: {GlobalState.TwoInsertionRate}</p>");
            htmlBuilder.AppendLine($"<p>3-bp Insertion Rate: {GlobalState.ThreeInsertionRate}</p>");

            htmlBuilder.AppendLine("</body>");
            htmlBuilder.AppendLine("</html>");

            return htmlBuilder.ToString();
        }
    }
}