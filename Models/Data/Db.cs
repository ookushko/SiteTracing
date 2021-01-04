﻿using System.Data.Entity;

namespace SiteTracing.Models.Data
{
    public class Db : DbContext
    {
        public DbSet<SearchesHistoryDTO> SearchesHistory { get; set; }

        public DbSet<TraceDetailsDTO> TraceDetails { get; set; }

        public DbSet<SearchDTO> Searches { get; set; }

        public System.Data.Entity.DbSet<SiteTracing.Models.ViewModels.SearchVM> SearchVMs { get; set; }
    }
}