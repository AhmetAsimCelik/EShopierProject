﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshopier.DAL.Messages
{
    public class ErrorMessageObj
    {
        public ErrorMessageCode Code { get; set; }
        public string Message { get; set; }
    }
}
