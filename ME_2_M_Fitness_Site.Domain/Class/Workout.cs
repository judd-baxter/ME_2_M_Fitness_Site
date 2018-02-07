using ME_2_M_Fitness_Site.Domain.Constants.Enumerations;

namespace ME_2_M_Fitness_Site.Domain.Class
{
    public class Workout
    {
        public int Identifier { get; set; }

        public int Repetitions { get; set; }

        public Excercise Excercise { get; set; }

        public string SetDescription { get; set; }

        public bool BothSides { get; set; }

        public RepetitionCategory RepetitionCategory { get; set; }
    }
}
