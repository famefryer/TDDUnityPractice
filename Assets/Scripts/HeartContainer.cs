using UnityEngine;
using System;
using System.Collections.Generic;

public class HeartContainer
{
    private List<Heart> m_hearts;
    public HeartContainer(List<Heart> hearts)
    {
        this.m_hearts = hearts;
    }

    public void Replenish(int numberOfHearts)
    {
        foreach(var heart in m_hearts)
        {
            heart.Replenish(numberOfHearts);
        }
    }
}
