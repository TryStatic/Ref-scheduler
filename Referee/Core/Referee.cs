using System.Collections.Generic;

namespace Referee.Core
{
    public class Referee
    {
        public List<Team> blocks;
        public string name;

        public Referee()
        {
            blocks = new List<Team>();
        }

        public override bool Equals(object obj)
        {
            var referee = obj as Referee;
            return referee != null &&
                   name == referee.name;
        }

        public override int GetHashCode()
        {
            return 279473228 + EqualityComparer<string>.Default.GetHashCode(name);
        }
    }
}