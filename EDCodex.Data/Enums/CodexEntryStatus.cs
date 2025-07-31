namespace EDCodex.Data.Enums;

public enum CodexEntryStatus
{
    Undefined = 0, // Entry was created, but never filled with any properties
    
    NotExists = 1,
    
    NotFound = 2,
    
    Found = 3,
}
