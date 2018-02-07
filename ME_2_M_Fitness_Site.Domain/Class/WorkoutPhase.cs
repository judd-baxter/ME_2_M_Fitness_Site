using System.Collections.Generic;

namespace ME_2_M_Fitness_Site.Domain.Class
{
    public class WorkoutPhase
    {
        public int Identifier { get; set; }

        public int WorkoutPlanIdentidifier { get; set; }

        public int WeekCap { get; set; }

        public string NoteForUser { get; set; }

        public List<Day> Days { get; set; }
    }
}
