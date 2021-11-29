using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.Packaging.Boxes.Models
{
    public record Boxes : BaseNopModel
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
        public record PackagingBoxesSearchModel : BaseSearchModel
        {
        }
    }
}
