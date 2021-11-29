using Nop.Core;
using System;

namespace Nop.Plugin.Packaging.Boxes.Domains
{
    /// <summary>
    /// Represents a packaging boxes record
    /// </summary>
    public partial class PackagingBoxesRecords : BaseEntity
    {
        //primary key
        public int BoxID { get; set; }
        //category id -- not a foregin key
        public int CategoryID { get; set; }
        public string BoxName { get; set; }
        public string BoxDetails { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }
        public DateTime AddedDateTime { get; set; }
    }
}
