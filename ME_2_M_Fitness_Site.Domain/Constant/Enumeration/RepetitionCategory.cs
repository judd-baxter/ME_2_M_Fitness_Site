using System.ComponentModel;

namespace ME_2_M_Fitness_Site.Domain.Constants.Enumerations
{
    public enum RepetitionCategory
    {
        [Description("Complete To Exaustion")]
        Exaust,

        [Description("Complete within this range of numbers")]
        Range,

        [Description("Do an exact number of sets")]
        SetNumber
    }
}
