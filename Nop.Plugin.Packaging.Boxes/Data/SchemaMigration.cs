using FluentMigrator;
using Nop.Data.Migrations;
using Nop.Plugin.Packaging.Boxes.Domain;

namespace Nop.Plugin.Packaging.Boxes.Data
{
    [SkipMigrationOnUpdate]
    [NopMigration("2021/11/26 12:20:55:1687541", "Packaging.Boxes base schema")]
    public class SchemaMigration : AutoReversingMigration
    {
        protected IMigrationManager _migrationManager;

        public SchemaMigration(IMigrationManager migrationManager)
        {
            _migrationManager = migrationManager;
        }

        public override void Up()
        {
            _migrationManager.BuildTable<PackagingBoxesRecords>(Create);
        }
    }
}