using mutaFinal.Pages;

namespace mutaFinal.Pages.CodeBehind
{
    public static class NormalizedIndelRateService
    {
        public static void NormalizedIndelRate(string content)
        {
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
            double sumOneInsertedReads = 0;
            double sumTwoInsertedReads = 0;
            double sumThreeInsertedReads = 0;
            var lines = content.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var sequence in GlobalState.EditedSequences)
            {
                var columns = sequence.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
                double n_inserted = double.Parse(columns[4]);
                switch (n_inserted)
                {
                    case 1.0:
                        sumOneInsertedReads += double.Parse(columns[6]);
                        break;
                    case 2.0:
                        sumTwoInsertedReads += double.Parse(columns[6]);
                        break;
                    case 3.0:
                        sumThreeInsertedReads += double.Parse(columns[6]);
                        break;
                    default:
                        continue;
                }
            }
            foreach (var sequence in GlobalState.EditedSequences)
            {
                var columns = sequence.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
                double deletions = double.Parse(columns[3]);
                switch (deletions)
                {
                    case 1.0:
                        sumOneDeletionReads += double.Parse(columns[6]);
                        break;
                    case 2.0:
                        sumTwoDeletionReads += double.Parse(columns[6]);
                        break;
                    case 3.0:
                        sumThreeDeletionReads += double.Parse(columns[6]);
                        break;
                    case 4.0:
                        sumFourDeletionReads += double.Parse(columns[6]);
                        break;
                    case 5.0:
                        sumFiveDeletionReads += double.Parse(columns[6]);
                        break;
                    case 6.0:
                        sumSixDeletionReads += double.Parse(columns[6]);
                        break;
                    case 7.0:
                        sumSevenDeletionReads += double.Parse(columns[6]);
                        break;
                    case 8.0:
                        sumEightDeletionReads += double.Parse(columns[6]);
                        break;
                    case 9.0:
                        sumNineDeletionReads += double.Parse(columns[6]);
                        break;
                    case 10.0:
                        sumTenDeletionReads += double.Parse(columns[6]);
                        break;
                    default:
                        continue;
                }
            }
            GlobalState.OneDeletionRate = Math.Round((sumOneDeletionReads / GlobalState.RecalculatedTER) * 100, 2);
            GlobalState.TwoDeletionRate = Math.Round((sumTwoDeletionReads / GlobalState.RecalculatedTER) * 100, 2);
            GlobalState.ThreeDeletionRate = Math.Round((sumThreeDeletionReads / GlobalState.RecalculatedTER) * 100, 2);
            GlobalState.FourDeletionRate = Math.Round((sumFourDeletionReads / GlobalState.RecalculatedTER) * 100, 2);
            GlobalState.FiveDeletionRate = Math.Round((sumFiveDeletionReads / GlobalState.RecalculatedTER) * 100, 2);
            GlobalState.SixDeletionRate = Math.Round((sumSixDeletionReads / GlobalState.RecalculatedTER) * 100, 2);
            GlobalState.SevenDeletionRate = Math.Round((sumSevenDeletionReads / GlobalState.RecalculatedTER) * 100, 2);
            GlobalState.EightDeletionRate = Math.Round((sumEightDeletionReads / GlobalState.RecalculatedTER) * 100, 2);
            GlobalState.NineDeletionRate = Math.Round((sumNineDeletionReads / GlobalState.RecalculatedTER) * 100, 2);
            GlobalState.TenDeletionRate = Math.Round((sumTenDeletionReads / GlobalState.RecalculatedTER) * 100, 2);
            GlobalState.OneInsertionRate = Math.Round((sumOneInsertedReads / GlobalState.RecalculatedTER) * 100, 2);
            GlobalState.TwoInsertionRate = Math.Round((sumTwoInsertedReads / GlobalState.RecalculatedTER) * 100, 2);
            GlobalState.ThreeInsertionRate = Math.Round((sumThreeInsertedReads / GlobalState.RecalculatedTER) * 100, 2);

        }
    }
}