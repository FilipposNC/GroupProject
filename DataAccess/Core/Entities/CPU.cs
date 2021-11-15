﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DataAccess.Core.Entities
{
    public class CPU
    {
        public int ID { get; set; }
        public string Brand { get; set; }
        public string Socket { get; set; }
        public string Model { get; set; }
        public int Cores { get; set; }
        public int Threads { get; set; }
        public int Frequency { get; set; }
        public int Watt { get; set; }
        public string Thumbnail { get; set; }
        public HttpPostedFileBase ImageFile { get; set; } // NotMapped
    }
}
