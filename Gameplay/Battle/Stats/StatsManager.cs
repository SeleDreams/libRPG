﻿// Copyright - SeleDreams - 2019
namespace SeleDreams.libRPG
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    public class StatsManager : IStatsManager
    {
        public StatsManager() =>
                _stats = new Dictionary<int, IStat>();

        public void Save() => 
            throw new System.NotImplementedException();

        public IStat GetStat(int id) => _stats[id];

        public void SetStat(int id, IStat value) => _stats[id] = value;

        private readonly Dictionary<int, IStat> _stats;

    }
}
