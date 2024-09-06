using mutaFinal.Pages;

namespace mutaFinal.Pages.CodeBehind
{
    public static class TemplatedOneBpInsertionRateService
    {
        public static void TemplatedOneBpInsertionRate(string content)
        {
            char fourthNuc = GlobalState.SelectedRow.FourthNucleotide[0];
            var lines = content.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            if (fourthNuc == '\0')
            {
                return;
            }
            switch (fourthNuc)
            {
                case 'A':
                    double aCount = 0;
                    foreach (var line in GlobalState.InsertedSequences)
                    {
                        var columns = line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
                        if (columns[0][20] == 'A')
                        {
                            aCount += double.Parse(columns[6]);
                        }
                    }
                    GlobalState.TemplatedOneBpInsertionRate = Math.Round((aCount / GlobalState.SumInsertedReads), 2);
                    break;
                case 'T':
                    double tCount = 0;
                    foreach (var line in GlobalState.InsertedSequences)
                    {
                        var columns = line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
                        if (columns[0][20] == 'T')
                        {
                            tCount += double.Parse(columns[6]);
                        }
                    }
                    GlobalState.TemplatedOneBpInsertionRate = Math.Round((tCount / GlobalState.SumInsertedReads) * 100, 2);
                    break;
                case 'C':
                    double cCount = 0;
                    foreach (var line in GlobalState.InsertedSequences)
                    {
                        var columns = line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
                        if (columns[0][20] == 'C')
                        {
                            cCount += double.Parse(columns[6]);
                        }
                    }
                    GlobalState.TemplatedOneBpInsertionRate = Math.Round((cCount / GlobalState.SumInsertedReads) * 100, 2);
                    break;
                case 'G':
                    double gCount = 0;
                    foreach (var line in GlobalState.InsertedSequences)
                    {
                        var columns = line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
                        if (columns[0][20] == 'G')
                        {
                            gCount += double.Parse(columns[6]);
                        }
                    }
                    GlobalState.TemplatedOneBpInsertionRate = Math.Round((gCount / GlobalState.SumInsertedReads) * 100, 2);
                    break;
                default:
                    break;
            }

        }
    }
}