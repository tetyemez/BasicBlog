using System;
using System.Collections.Generic;
using System.Text;

namespace TrackWorkout.Models
{
    public class Workout
    {
        public int Id { get; set; }
        public DateTimeOffset Date { get; set; }

        public int DistanceInMeters { get; set; }

        public long TimeInSeconds { get; set; }
    }
}
