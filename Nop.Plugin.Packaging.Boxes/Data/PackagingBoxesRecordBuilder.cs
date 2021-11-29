using FluentMigrator.Builders.Create.Table;
using Nop.Data.Mapping.Builders;
using Nop.Plugin.Packaging.Boxes.Domain;

namespace Nop.Plugin.Packaging.Boxes.Data
{
    public class PackagingBoxesRecordBuilder : NopEntityBuilder<PackagingBoxesRecords>
    {
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
                //map the primary key (not necessary if it is Id field)
                .WithColumn(nameof(PackagingBoxesRecords.BoxID)).AsInt32().PrimaryKey()
                .WithColumn(nameof(PackagingBoxesRecords.CategoryID))
                .AsInt32()
                .Nullable()
                .WithColumn(nameof(PackagingBoxesRecords.BoxName))
                .AsString(1000)
                .WithColumn(nameof(PackagingBoxesRecords.BoxDetails))
                .AsString(1000)
                .Nullable()
                .WithColumn(nameof(PackagingBoxesRecords.Height))
                .AsInt32()
                .WithColumn(nameof(PackagingBoxesRecords.Width))
                .AsInt32()
                .WithColumn(nameof(PackagingBoxesRecords.Length))
                .AsInt32()
                .WithColumn(nameof(PackagingBoxesRecords.AddedDateTime))
                .AsDateTime();
        }
    }
}
