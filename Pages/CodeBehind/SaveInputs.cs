using mutaFinal.Pages;

namespace mutaFinal.Pages.CodeBehind
{
    public static class SaveInputsService
    {
        public static Task SaveInputs(InputRow input)
        {
            var existingRow = GlobalState.InputRows.Find(r => r.Id == input.Id);
            string Error = null;
            if (existingRow != null)
            {
                existingRow.Genotype = input.Genotype;
                existingRow.PlasmidID = input.PlasmidID;
                existingRow.TargetSite = input.TargetSite;
                if (input.FourthNucleotide == "A" || input.FourthNucleotide == "T" || input.FourthNucleotide == "C" || input.FourthNucleotide == "G" || string.IsNullOrEmpty(input.FourthNucleotide))
                {
                    existingRow.FourthNucleotide = input.FourthNucleotide;
                }
                else
                {
                    input.FourthNucleotide = "";
                    Error = "ERROR, 'Fourth Nucleotide' input expects either 'A', 'T', 'C', or 'G' as an input.";
                    GlobalState.InputErrors.Add(Error);
                }
                existingRow.Rep = input.Rep;
            }
            else
            {
                GlobalState.InputRows.Add(input);
            }
            return Task.CompletedTask;
        }
    }
}