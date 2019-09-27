using System.Collections.Generic;

namespace Referee.Core
{
    public class Period
    {
        public string periodos;
        public string diorganwsi;
        public int agwnistiki;
        public List<Assignment> assignments;

        public Period()
        {
            assignments = new List<Assignment>();
        }

        public override bool Equals(object obj)
        {
            var period = obj as Period;
            return period != null &&
                   periodos == period.periodos &&
                   diorganwsi == period.diorganwsi &&
                   agwnistiki == period.agwnistiki;
        }

        public override int GetHashCode()
        {
            var hashCode = -7557925;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(periodos);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(diorganwsi);
            hashCode = hashCode * -1521134295 + agwnistiki.GetHashCode();
            return hashCode;
        }
    }
}