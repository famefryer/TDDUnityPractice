using System;
using UnityEngine;
using UnityEngine.UI;

public class Heart 
{
    public Image m_image;
    public const float fillPerHeartPieces = 0.25f;

    public Heart(Image m_image)
    {
        this.m_image = m_image;
    }

    public void Replenish(int numberOfHeartPieces)
    {
        if (numberOfHeartPieces < 0) throw new ArgumentException("numberOfheartPieces must be greater than or equal 0");
        m_image.fillAmount += numberOfHeartPieces * fillPerHeartPieces;
    }

    public void Deplete(int numberOfHeartPieces)
    {
        if(numberOfHeartPieces < 0) throw new ArgumentException("numberOfheartPieces must be greater than or equal 0");
        
        m_image.fillAmount -= numberOfHeartPieces * fillPerHeartPieces;
    }
}
