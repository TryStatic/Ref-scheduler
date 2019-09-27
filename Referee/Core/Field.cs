using System.Collections.Generic;

namespace Referee.Core
{
    public class Field
    {
        public string fieldName;

        public override bool Equals(object obj)
        {
            var field = obj as Field;
            return field != null &&
                   fieldName == field.fieldName;
        }

        public override int GetHashCode()
        {
            return -315875868 + EqualityComparer<string>.Default.GetHashCode(fieldName);
        }
    }
}
