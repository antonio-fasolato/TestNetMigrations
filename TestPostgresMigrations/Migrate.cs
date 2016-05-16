using System;
using System.Configuration;
using FluentMigrator;
using FluentMigrator.Runner;
using FluentMigrator.Runner.Announcers;
using FluentMigrator.Runner.Initialization;
using FluentMigrator.Runner.Processors.Postgres;
using PostgresMigrations;
using Xunit;

namespace TestPostgresMigrations
{
    public class Migrate
    {
        public class MigrationsOptions : IMigrationProcessorOptions
        {
            public bool PreviewOnly { get; set; }
            public int Timeout { get; set; }
            public string ProviderSwitches { get; set; }
        }

        [Fact]
        public void Down()
        {
            var announcer = new TextWriterAnnouncer(Console.WriteLine);
            var assembly = typeof(M1Tenant).Assembly;

            var migrationContext = new RunnerContext(announcer)
            {
                Namespace = "PostgresMigrations"
            };

            var options = new MigrationsOptions {PreviewOnly = false, Timeout = 60};
            var factory = new PostgresProcessorFactory();
            using (
                var processor = factory.Create(ConfigurationManager.ConnectionStrings["Migrations"].ConnectionString,
                    announcer, options))
            {
                var runner = new MigrationRunner(assembly, migrationContext, processor);
                runner.MigrateDown(0, true);
            }
        }

        [Fact]
        public void Up()
        {
            var announcer = new TextWriterAnnouncer(Console.WriteLine);
            var assembly = typeof(M1Tenant).Assembly;

            var migrationContext = new RunnerContext(announcer)
            {
                Namespace = "PostgresMigrations"
            };

            var options = new MigrationsOptions {PreviewOnly = false, Timeout = 60};
            var factory = new PostgresProcessorFactory();
            using (
                var processor = factory.Create(ConfigurationManager.ConnectionStrings["Migrations"].ConnectionString,
                    announcer, options))
            {
                var runner = new MigrationRunner(assembly, migrationContext, processor);
                runner.MigrateUp(true);
            }
        }
    }
}