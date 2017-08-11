using Sardf.Entity;
using Sardf.Platform.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sardf.Platform.Entities
{
    public class SysConfigExpress: SysConfig
    {
        [StringColumn("IMG_PATH", "系统图片", true, 1, 1000)]
        public string ImgPath { get; set; }
    }
}
