using System;
using System.Collections.Generic;

namespace Referee.Core
{
    public class Assignment
    {
        public Period period;
        public Team home;
        public Team guest;
        public Field field;
        public string time;
        public Referee referee;
        public Referee helperA;
        public Referee helperB;
        public WatchRef watchRef;

        

        public override bool Equals(object obj)
        {
            var assignment = obj as Assignment;
            return assignment != null &&
                   EqualityComparer<Period>.Default.Equals(period, assignment.period);
        }

        public override int GetHashCode()
        {
            return -1641761884 + EqualityComparer<Period>.Default.GetHashCode(period);
        }
    }
}
