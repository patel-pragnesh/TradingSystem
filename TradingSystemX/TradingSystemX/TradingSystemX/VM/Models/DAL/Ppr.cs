//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Oybab.DAL
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class Ppr
    {
        public long PprId { get; set; }
        public long ProductId { get; set; }
        public long PrinterId { get; set; }
    

        [JsonIgnore]
        public virtual Product tb_product { get; set; }
        [JsonIgnore]
        public virtual Printer tb_printer { get; set; }
    }
}
