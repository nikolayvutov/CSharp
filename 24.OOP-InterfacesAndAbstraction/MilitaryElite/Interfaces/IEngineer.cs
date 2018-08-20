using System;
using System.Collections.Generic;

public interface IEngineer
{
    ICollection<Repair> Repairs { get; }
}

