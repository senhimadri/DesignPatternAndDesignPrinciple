﻿namespace DIby_IAmTimCorey.Logic;

public class DemoLogic
{
    public int Value1 { get; private set; }
    public int Value2 { get; private set; }


    public DemoLogic()
    {
        Value1 = Random.Shared.Next(1, 1001);
        Value2 = Random.Shared.Next(1, 1001);
    }
}
