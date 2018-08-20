using System;
using System.Collections.Generic;

public interface ICommando
{
    ICollection<Mission> Missions { get; }
}

