﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YiZhan.Common.ViewModelComponents
{
    [AttributeUsage(AttributeTargets.Property,AllowMultiple=true )]
    public class SelfReferentialItemSpecification:Attribute
    {
        public string RelevanceID { get; set; }
        public SelfReferentialItemSpecification(string id) 
        {
            RelevanceID = id;
        }
    }
}
