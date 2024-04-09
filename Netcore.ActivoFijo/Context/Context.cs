using Microsoft.EntityFrameworkCore;
using Netcore.ActivoFijo.Context;

namespace Netcore.ActivoFijo.Model
{
    public partial class Context
    {
        public string ConnectionString
        {
            get;
            set;
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Conventions.Add(_ => new BlankTriggerAddingConvention());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!string.IsNullOrEmpty(this.ConnectionString))
            {
                optionsBuilder.UseSqlServer

                (this.ConnectionString, sqlServerOptions => sqlServerOptions.CommandTimeout(3600));
            }

            base.OnConfiguring(optionsBuilder);
        }
    }
}