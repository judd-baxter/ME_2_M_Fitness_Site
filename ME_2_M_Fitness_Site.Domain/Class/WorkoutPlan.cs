using System;
using System.Collections.Generic;

namespace ME_2_M_Fitness_Site.Domain.Class
{
    public class WorkoutPlan
    {
        public int Identifier { get; set; }

        public Client RegisteredClient { get; set; }

        public DateTime CreateDate { get; set; }

        public List<WorkoutPhase> WorkoutPhases { get; set; }
    }
}
