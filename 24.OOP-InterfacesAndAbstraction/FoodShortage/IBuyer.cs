using System;

public interface IBuyer : INameble
{
    int Food { get; }
    void BuyFood();
}

