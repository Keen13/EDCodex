using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDCodex.Data.Enums;

public enum  CodexEntryStatus
{
    Undefined = 0, // Entry was created, but never filled with any properties
    
    NotExists = 1,
    
    Exists = 2,
    
    Found = 3,
}
