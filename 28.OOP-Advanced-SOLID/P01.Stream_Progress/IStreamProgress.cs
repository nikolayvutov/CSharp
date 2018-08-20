using System;

public interface IStreamProgress
{
    int BytesSent { get; }

    int Length { get; }
}

