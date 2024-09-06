using mutaFinal.Pages;

namespace mutaFinal.Pages.CodeBehind
{
    public static class _1bpDeletionRateService
    {
        public static void _1bpDeletionRate(string content)
        {
            double editedReads = 0;
            foreach (var item in GlobalState.EditedSequences)
            {
                var columns = item.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
                editedReads += double.Parse(columns[6]);
            }
            double sumOneDeletionReads = 0;
            double sumTwoDeletionReads = 0;
            double sumThreeDeletionReads = 0;
            double sumFourDeletionReads = 0;
            double sumFiveDeletionReads = 0;
            double sumSixDeletionReads = 0;
            double sumSevenDeletionReads = 0;
            double sumEightDeletionReads = 0;
            double sumNineDeletionReads = 0;
            double sumTenDeletionReads = 0;
            foreach (var item in GlobalState.EditedSequences)
            {
                var columns = item.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
                if (columns[2] == "False")
                {
                    double n_deleted = double.Parse(columns[3]);
                    double reads = double.Parse(columns[6]);
                    switch (n_deleted)
                    {
                        case 1.0:
                            sumOneDeletionReads += reads;
                            break;
                        case 2.0:
                            sumTwoDeletionReads += reads;
                            break;
                        case 3.0:
                            sumThreeDeletionReads += reads;
                            break;
                        case 4.0:
                            sumFourDeletionReads += reads;
                            break;
                        case 5.0:
                            sumFiveDeletionReads += reads;
                            break;
                        case 6.0:
                            sumSixDeletionReads += reads;
                            break;
                        case 7.0:
                            sumSevenDeletionReads += reads;
                            break;
                        case 8.0:
                            sumEightDeletionReads += reads;
                            break;
                        case 9.0:
                            sumNineDeletionReads += reads;
                            break;
                        case 10.0:
                            sumTenDeletionReads += reads;
                            break;
                        default:
                            continue;
                    }
                }
            }
            GlobalState.OneBpDeletionRate = Math.Round((sumOneDeletionReads / GlobalState.SumDeletionReads) * 100, 2);
            GlobalState.TwoBpDeletionRate = Math.Round((sumTwoDeletionReads / GlobalState.SumDeletionReads) * 100, 2);
            GlobalState.ThreeBpDeletionRate = Math.Round((sumThreeDeletionReads / GlobalState.SumDeletionReads) * 100, 2);
            GlobalState.FourBpDeletionRate = Math.Round((sumFourDeletionReads / GlobalState.SumDeletionReads) * 100, 2);
            GlobalState.FiveBpDeletionRate = Math.Round((sumFiveDeletionReads / GlobalState.SumDeletionReads) * 100, 2);
            GlobalState.SixBpDeletionRate = Math.Round((sumSixDeletionReads / GlobalState.SumDeletionReads) * 100, 2);
            GlobalState.SevenBpDeletionRate = Math.Round((sumSevenDeletionReads / GlobalState.SumDeletionReads) * 100, 2);
            GlobalState.EightBpDeletionRate = Math.Round((sumEightDeletionReads / GlobalState.SumDeletionReads) * 100, 2);
            GlobalState.NineBpDeletionRate = Math.Round((sumNineDeletionReads / GlobalState.SumDeletionReads) * 100, 2);
            GlobalState.TenBpDeletionRate = Math.Round((sumTenDeletionReads / GlobalState.SumDeletionReads) * 100, 2);
            GlobalState.SmallDeletionRate = Math.Round((sumOneDeletionReads + sumTwoDeletionReads + sumThreeDeletionReads +
                               sumFourDeletionReads + sumFiveDeletionReads + sumSixDeletionReads +
                               sumSevenDeletionReads + sumEightDeletionReads + sumNineDeletionReads +
                               sumTenDeletionReads) / editedReads * 100, 2);
        }
    }
}