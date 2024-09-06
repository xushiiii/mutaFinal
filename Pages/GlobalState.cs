using Microsoft.AspNetCore.Components.Forms;

namespace mutaFinal.Pages
{
    public static class GlobalState
    {
        public static bool isErrorVisible = false;
        public static double SumInsertedSequences { get; set; } = 0;
        public static bool tester = true;
        public static List<string> InputErrors = new List<string>();
        public static string Formula { get; set; }
        public static bool isFormulaVisible = false;

        public static List<string> EditedSequences = new List<string>();
        public static List<string> InsertedSequences = new List<string>();
        public static List<IBrowserFile> UploadedFiles { get; set; } = new List<IBrowserFile>();
        public static Dictionary<int, string> FileContents { get; set; } = new Dictionary<int, string>();
        public static string SelectedFileName { get; set; }
        public static List<InputRow> InputRows { get; set; } = new List<InputRow>();
        public static InputRow SelectedRow { get; set; }
        public static int NextRowId { get; set; } = 1;
        public static bool IsModalVisible { get; set; } = false;
        public static int DashCount { get; set; }
        public static string FileContent { get; set; }
        public static bool IsDataAvailable { get; set; } = false;
        public static double SumEditedReads { get; set; }
        public static double SumInsertedReads { get; set; }
        public static double PercentReadsSum { get; set; }
        public static double ReadsPercentage { get; set; }
        public static double AInsertionRate { get; set; }
        public static double OneBpInsertionRate { get; set; }
        public static double GInsertionRate { get; set; }
        public static double CInsertionRate { get; set; }
        public static double NonTemplatedOneBpInsertionRate { get; set; }
        public static double TemplatedOneBpInsertionRate { get; set; }
        public static double TInsertionRate { get; set; }
        public static double OverallMutagenesisRate { get; set; }
        public static double SmallDeletionRate { get; set; }
        public static double OneBpDeletionRate { get; set; }
        public static double TwoBpDeletionRate { get; set; }
        public static double ThreeBpDeletionRate { get; set; }
        public static double FourBpDeletionRate { get; set; }
        public static double FiveBpDeletionRate { get; set; }
        public static double SixBpDeletionRate { get; set; }
        public static double SevenBpDeletionRate { get; set; }
        public static double EightBpDeletionRate { get; set; }
        public static double NineBpDeletionRate { get; set; }
        public static double TenBpDeletionRate { get; set; }
        public static double SumDeletionReads { get; set; }
        public static double TotalEditedReads { get; set; }
        public static double OneDeletionRate { get; set; }
        public static double TwoDeletionRate { get; set; }
        public static double ThreeDeletionRate { get; set; }
        public static double FourDeletionRate { get; set; }
        public static double FiveDeletionRate { get; set; }
        public static double SixDeletionRate { get; set; }
        public static double SevenDeletionRate { get; set; }
        public static double EightDeletionRate { get; set; }
        public static double NineDeletionRate { get; set; }
        public static double TenDeletionRate { get; set; }
        public static double OneInsertionRate { get; set; }
        public static double TwoInsertionRate { get; set; }
        public static double ThreeInsertionRate { get; set; }
        public static double TotalATCGReads { get; set; }
        public static double RecalculatedTER { get; set; } = 0;
        public static event Action StateChanged;
        public static void NotifyStateChanged() => StateChanged?.Invoke();
        public static List<MutationRate> MutationRates = new List<MutationRate>
        {
            new MutationRate {Name = "Overall Mutagenesis Rate", Value = OverallMutagenesisRate, Formula = "#Reads of total edited sequences / #Reads of all sequences."},
            new MutationRate {Name = "1-bp Insertion Profile", Value = 0, Formula = "" },
            new MutationRate {Name = "1-bp Insertion Rate", Value = OneBpInsertionRate, Formula = "#Reads of 1-bp inserted sequences / #Reads of total edited sequences."},
            new MutationRate {Name = "A Insertion Rate", Value = AInsertionRate, Formula = "#Reads of A / #Reads of (A + T + C +G)."},
            new MutationRate {Name = "T Insertion Rate", Value = TInsertionRate, Formula = "#Reads of T / #Reads of (A + T + C +G)."},
            new MutationRate {Name = "C Insertion Rate", Value = CInsertionRate, Formula = "#Reads of C / #Reads of (A + T + C +G)."},
            new MutationRate {Name = "G Insertion Rate", Value = GInsertionRate, Formula = "#Reads of G / #Reads of (A + T + C +G)."},
            new MutationRate {Name = "Templated 1-bp Insertion Rate", Value = TemplatedOneBpInsertionRate, Formula = "#Reads of templated 1-bp inserted sequences / #Reads of total edited sequences.\nPlease note this value will not be calculated without user given Fourth Nucleotide."},
            new MutationRate {Name = "Non-templated 1-bp Insertion Rate", Value = NonTemplatedOneBpInsertionRate, Formula = "Reads of non-templated 1-bp inserted sequences / #Reads of total edited sequences."},
            new MutationRate {Name = "Deletion Profile", Value = 0, Formula = ""},
            new MutationRate {Name = "Small Deletion Rate", Value = SmallDeletionRate, Formula = "#Reads of sequences less than 10-bp deletion / #Reads of total edited sequences."},
            new MutationRate {Name = "1-bp Deletion Rate", Value = OneBpDeletionRate, Formula = "#Reads of 1-bp deletion sequences / #Reads of total deletion sequences."},
            new MutationRate {Name = "2-bp Deletion Rate", Value = TwoBpDeletionRate, Formula = "#Reads of 2-bp deletion sequences / #Reads of total deletion sequences."},
            new MutationRate {Name = "3-bp Deletion Rate", Value = ThreeBpDeletionRate, Formula = "#Reads of 3-bp deletion sequences / #Reads of total deletion sequences."},
            new MutationRate {Name = "4-bp Deletion Rate", Value = FourBpDeletionRate, Formula = "#Reads of 4-bp deletion sequences / #Reads of total deletion sequences."},
            new MutationRate {Name = "5-bp Deletion Rate", Value = FiveBpDeletionRate, Formula = "#Reads of 5-bp deletion sequences / #Reads of total deletion sequences."},
            new MutationRate {Name = "6-bp Deletion Rate", Value = SixBpDeletionRate, Formula = "#Reads of 6-bp deletion sequences / #Reads of total deletion sequences."},
            new MutationRate {Name = "7-bp Deletion Rate", Value = SevenBpDeletionRate, Formula = "#Reads of 7-bp deletion sequences / #Reads of total deletion sequences."},
            new MutationRate {Name = "8-bp Deletion Rate", Value = EightBpDeletionRate, Formula = "#Reads of 8-bp deletion sequences / #Reads of total deletion sequences."},
            new MutationRate {Name = "9-bp Deletion Rate", Value = NineBpDeletionRate, Formula = "Reads of 9-bp deletion sequences / #Reads of total deletion sequences."},
            new MutationRate {Name = "10-bp Deletion Rate", Value = TenBpDeletionRate, Formula = "#Reads of 10-bp deletion sequences / #Reads of total deletion sequences."},
            new MutationRate {Name = "Normalized Indel Rate", Value = 0, Formula = ""},
            new MutationRate {Name = "1-bp Deletion Rate", Value = OneDeletionRate, Formula = "#Reads of 1-bp deleted sequences / #Reads of total edited sequences"},
            new MutationRate {Name = "2-bp Deletion Rate", Value = TwoDeletionRate, Formula = "#Reads of 2-bp deleted sequences / #Reads of total edited sequences"},
            new MutationRate {Name = "3-bp Deletion Rate", Value = ThreeDeletionRate, Formula = "#Reads of 3-bp deleted sequences / #Reads of total edited sequences"},
            new MutationRate {Name = "4-bp Deletion Rate", Value = FourDeletionRate, Formula = "#Reads of 4-bp deleted sequences / #Reads of total edited sequences"},
            new MutationRate {Name = "5-bp Deletion Rate", Value = FiveDeletionRate, Formula = "#Reads of 5-bp deleted sequences / #Reads of total edited sequences"},
            new MutationRate {Name = "6-bp Deletion Rate", Value = SixDeletionRate, Formula = "#Reads of 6-bp deleted sequences / #Reads of total edited sequences"},
            new MutationRate {Name = "7-bp Deletion Rate", Value = SevenDeletionRate, Formula = "#Reads of 7-bp deleted sequences / #Reads of total edited sequences"},
            new MutationRate {Name = "8-bp Deletion Rate", Value = EightDeletionRate, Formula = "#Reads of 8-bp deleted sequences / #Reads of total edited sequences"},
            new MutationRate {Name = "9-bp Deletion Rate", Value = NineDeletionRate, Formula = "#Reads of 9-bp deleted sequences / #Reads of total edited sequences"},
            new MutationRate {Name = "10-bp Deletion Rate", Value = TenDeletionRate, Formula = "#Reads of 10-bp deleted sequences / #Reads of total edited sequences"},
            new MutationRate {Name = "1-bp Insertion Rate", Value = OneInsertionRate, Formula = "#Reads of 1-bp Inserted sequences / #Reads of total edited sequences"},
            new MutationRate {Name = "2-bp Insertion Rate", Value = TwoInsertionRate, Formula = "#Reads of 2-bp Inserted sequences / #Reads of total edited sequences"},
            new MutationRate {Name = "3-bp Insertion Rate", Value = ThreeInsertionRate, Formula = "#Reads of 3-bp Inserted sequences / #Reads of total edited sequences"},

        };
        public static void UpdateMutationRates()
        {
            foreach (var rate in MutationRates)
            {
                switch (rate.Formula)
                {
                    case "#Reads of total edited sequences / #Reads of all sequences.":
                        rate.Value = OverallMutagenesisRate;
                        break;
                    case "#Reads of 1-bp inserted sequences / #Reads of total edited sequences.":
                        rate.Value = OneBpInsertionRate;
                        break;
                    case "#Reads of A / #Reads of (A + T + C +G).":
                        rate.Value = AInsertionRate;
                        break;
                    case "#Reads of T / #Reads of (A + T + C +G).":
                        rate.Value = TInsertionRate;
                        break;
                    case "#Reads of C / #Reads of (A + T + C +G).":
                        rate.Value = CInsertionRate;
                        break;
                    case "#Reads of G / #Reads of (A + T + C +G).":
                        rate.Value = GInsertionRate;
                        break;
                    case "#Reads of templated 1-bp inserted sequences / #Reads of total edited sequences.\nPlease note this value will not be calculated without user given Fourth Nucleotide.":
                        rate.Value = TemplatedOneBpInsertionRate;
                        break;
                    case "Reads of non-templated 1-bp inserted sequences / #Reads of total edited sequences.":
                        rate.Value = NonTemplatedOneBpInsertionRate;
                        break;
                    case "#Reads of sequences less than 10-bp deletion / #Reads of total edited sequences.":
                        rate.Value = SmallDeletionRate;
                        break;
                    case "#Reads of 1-bp deletion sequences / #Reads of total deletion sequences.":
                        rate.Value = OneBpDeletionRate;
                        break;
                    case "#Reads of 2-bp deletion sequences / #Reads of total deletion sequences.":
                        rate.Value = TwoBpDeletionRate;
                        break;
                    case "#Reads of 3-bp deletion sequences / #Reads of total deletion sequences.":
                        rate.Value = ThreeBpDeletionRate;
                        break;
                    case "#Reads of 4-bp deletion sequences / #Reads of total deletion sequences.":
                        rate.Value = FourBpDeletionRate;
                        break;
                    case "#Reads of 5-bp deletion sequences / #Reads of total deletion sequences.":
                        rate.Value = FiveBpDeletionRate;
                        break;
                    case "#Reads of 6-bp deletion sequences / #Reads of total deletion sequences.":
                        rate.Value = SixBpDeletionRate;
                        break;
                    case "#Reads of 7-bp deletion sequences / #Reads of total deletion sequences.":
                        rate.Value = SevenBpDeletionRate;
                        break;
                    case "#Reads of 8-bp deletion sequences / #Reads of total deletion sequences.":
                        rate.Value = EightBpDeletionRate;
                        break;
                    case "Reads of 9-bp deletion sequences / #Reads of total deletion sequences.":
                        rate.Value = NineBpDeletionRate;
                        break;
                    case "#Reads of 10-bp deletion sequences / #Reads of total deletion sequences.":
                        rate.Value = TenBpDeletionRate;
                        break;
                    case "#Reads of 1-bp deleted sequences / #Reads of total edited sequences":
                        rate.Value = OneDeletionRate;
                        break;
                    case "#Reads of 2-bp deleted sequences / #Reads of total edited sequences":
                        rate.Value = TwoDeletionRate;
                        break;
                    case "#Reads of 3-bp deleted sequences / #Reads of total edited sequences":
                        rate.Value = ThreeDeletionRate;
                        break;
                    case "#Reads of 4-bp deleted sequences / #Reads of total edited sequences":
                        rate.Value = FourDeletionRate;
                        break;
                    case "#Reads of 5-bp deleted sequences / #Reads of total edited sequences":
                        rate.Value = FiveDeletionRate;
                        break;
                    case "#Reads of 6-bp deleted sequences / #Reads of total edited sequences":
                        rate.Value = SixDeletionRate;
                        break;
                    case "#Reads of 7-bp deleted sequences / #Reads of total edited sequences":
                        rate.Value = SevenDeletionRate;
                        break;
                    case "#Reads of 8-bp deleted sequences / #Reads of total edited sequences":
                        rate.Value = EightDeletionRate;
                        break;
                    case "#Reads of 9-bp deleted sequences / #Reads of total edited sequences":
                        rate.Value = NineDeletionRate;
                        break;
                    case "#Reads of 10-bp deleted sequences / #Reads of total edited sequences":
                        rate.Value = TenDeletionRate;
                        break;
                    case "#Reads of 1-bp Inserted sequences / #Reads of total edited sequences":
                        rate.Value = OneInsertionRate;
                        break;
                    case "#Reads of 2-bp Inserted sequences / #Reads of total edited sequences":
                        rate.Value = TwoInsertionRate;
                        break;
                    case "#Reads of 3-bp Inserted sequences / #Reads of total edited sequences":
                        rate.Value = ThreeInsertionRate;
                        break;
                    default:
                        // Handle cases where the formula does not match any known case
                        rate.Value = 0; // or another default value if appropriate
                        break;
                }
            }
        }

    }

    public class InputRow
    {
        public string FileName { get; set; } = "Select File";
        public int Id { get; set; }
        public string Genotype { get; set; }
        public string PlasmidID { get; set; }
        public string TargetSite { get; set; }
        public string FourthNucleotide { get; set; }
        public string Rep { get; set; }
    }

    public class MutationRate
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public string Formula { get; set; }
        public bool ShowTooltip { get; set; }

        public void SetShowTooltip(bool value)
        {
            ShowTooltip = value;
            GlobalState.NotifyStateChanged();
        }
    }
}


