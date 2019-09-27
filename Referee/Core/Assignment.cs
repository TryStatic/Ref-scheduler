using System.Collections.Generic;

namespace Referee.Core
{
    public class Assignment
    {
        public Field field;
        public Team guest;
        public Referee helperA;
        public Referee helperB;
        public Team home;
        public Period period;
        public Referee referee;
        public string time;
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