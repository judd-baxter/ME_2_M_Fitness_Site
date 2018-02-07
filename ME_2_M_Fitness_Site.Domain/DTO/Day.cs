using System.Collections.Generic;

namespace ME_2_M_Fitness_Site.Domain.DTO
{
    public class Day
    {
        public int Identidifier { get; set; }

        public int WorkoutPhaseIdentifier { get; set; }

        public int OrderNumber { get; set; }

        public List<Workout> Workouts { get; set; }
    }
}
