using System.Collections.Generic;

namespace Referee.Core
{
    public class DataBank
    {
        public List<Team> Teams { get; }
        public List<Field> Fields { get; }
        public List<Referee> Refs { get; }
        public List<WatchRef> WatchRefs { get; }
        public List<Period> Periods { get; }

        public Period GetLastPeriod(Period currP)
        {
            foreach (var p in Periods)
            {
                if (p.agwnistiki == currP.agwnistiki - 1 && p.periodos == currP.periodos && p.diorganwsi == currP.diorganwsi)
                    return p;
            }
            return null;
        }

        public Period GetSecondToLastPeriod(Period currP)
        {
            foreach (var p in Periods)
            {
                if (p.agwnistiki == currP.agwnistiki - 2 && p.periodos == currP.periodos && p.diorganwsi == currP.diorganwsi)
                    return p;
            }
            return null;
        }

        public void AddPeriod(Period p)
        {
            if(!Periods.Contains(p))
                Periods.Add(p);
        }

        public void AddTeam(Team t)
        {
            if (!Teams.Contains(t))
                Teams.Add(t);
        }

        public void RemoveTeam(Team t)
        {
            if (Teams.Contains(t))
                Teams.Remove(t);
        }

        public void AddField(Field f)
        {
            if(!Fields.Contains(f))
                Fields.Add(f);
        }

        public void RemoveField(Field f)
        {
            if (Fields.Contains(f))
                Fields.Remove(f);
        }

        public void AddRef(Referee r)
        {
            if (!Refs.Contains(r))
                Refs.Add(r);
        }

        public void RemoveRef(Referee r)
        {
            if (Refs.Contains(r))
            {
                Refs.Remove(r);
            }
        }

        public void AddWatchRef(WatchRef wr)
        {
            if (!WatchRefs.Contains(wr))
                WatchRefs.Add(wr);
        }

        public void RemoveWatchRef(WatchRef wr)
        {
            if (WatchRefs.Contains(wr))
            {
                WatchRefs.Remove(wr);
            }
        }


        public DataBank()
        {
            Teams = new List<Team>();
            Fields = new List<Field>();
            Refs = new List<Referee>();
            WatchRefs = new List<WatchRef>();
            Periods = new List<Period>();
        }

        public bool SaveData()
        {
            return Util.SerializeObject(this, "data.xml");
        }

        public static DataBank LoadData()
        {
            return Util.DeSerializeObject<DataBank>("data.xml");
        }
    }
}
