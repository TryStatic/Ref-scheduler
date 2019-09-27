using System.Collections.Generic;

namespace Referee.Core
{
    public class Team
    {
        public string teamName;

        public override bool Equals(object obj)
        {
            var team = obj as Team;
            return team != null &&
                   teamName == team.teamName;
        }

        public override int GetHashCode()
        {
            return -1311673729 + EqualityComparer<string>.Default.GetHashCode(teamName);
        }
    }
}
