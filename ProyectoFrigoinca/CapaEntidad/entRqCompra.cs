﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entRqCompra
    {
        public Int64 idReqComp {  get; set; }
        public string DesReqComp {  get; set; }
        public int cantidad {  get; set; }
        public Boolean estado { get; set; }
        public int idInv {  get; set; }
    }
}
