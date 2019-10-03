﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customerdetail.Model
{
    public class CustomerModel
    {
        public int Id { set; get; }
        public string Code { set; get; }
        public string Name { set; get; }
        public string Address { set; get; }
        public string Contact { set; get; }
        public string District { set; get; }
    }
}
