using NUnit.Framework;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Hearttests
{
    private Image m_image;
    private Heart heart;

    [SetUp]
    public void init()
    {
        m_image = new GameObject().AddComponent<Image>();
        heart = new Heart(m_image);
    }

    public class TheReplenishMethod : Hearttests
    {
        [Test]
        public void _0_Sets_Image_With_0_Fill_To_0_Fill()
        {
            heart.m_image.fillAmount = 0;
            heart.Replenish(0);

            Assert.AreEqual(0, heart.m_image.fillAmount);
        }

        [Test]
        public void _1_Sets_Image_With_0_Fill_To_25_Percent_Fill()
        {
            heart.m_image.fillAmount = 0;
            heart.Replenish(1);

            Assert.AreEqual(0.25f, heart.m_image.fillAmount);
        }

        [Test]
        public void _1_Sets_Image_With_25_Fill_To_50_Percent_Fill()
        {
            heart.m_image.fillAmount = 0.25f;
            heart.Replenish(1);

            Assert.AreEqual(0.5f, heart.m_image.fillAmount);
        }

        [Test]
        public void _Throws_Exception_For_Negative_Number_Of_Heart_Pieces()
        {
            Assert.Throws<ArgumentException>(() => heart.Replenish(-1));
        }
    }

    public class TheDepleteMethod : Hearttests
    {
        private Image m_image;
        private Heart heart;

        [SetUp]
        public void init()
        {
            m_image = new GameObject().AddComponent<Image>();
            heart = new Heart(m_image);
        }

        [Test]
        public void _0_Sets_Image_With_0_Fill_To_0_Fill()
        {
            heart.m_image.fillAmount = 0;
            heart.Deplete(0);

            Assert.AreEqual(0, heart.m_image.fillAmount);
        }

        [Test]
        public void _1_Sets_Image_With_25_Fill_To_0_Fill()
        {
            heart.m_image.fillAmount = 0.25f;
            heart.Deplete(1);

            Assert.AreEqual(0, heart.m_image.fillAmount);
        }

        [Test]
        public void _1_Sets_Image_With_50_Fill_To_25_Fill()
        {
            heart.m_image.fillAmount = 0.5f;
            heart.Deplete(1);

            Assert.AreEqual(0.25f, heart.m_image.fillAmount);
        }


        [Test]
        public void _1_Sets_Image_With_100_Fill_To_75_Fill()
        {
            heart.m_image.fillAmount = 1;
            heart.Deplete(1);

            Assert.AreEqual(0.75f, heart.m_image.fillAmount);
        }

        [Test]
        public void _1_Sets_Image_With_75_Fill_To_50_Fill()
        {
            heart.m_image.fillAmount = 0.75f;
            heart.Deplete(1);

            Assert.AreEqual(0.5f, heart.m_image.fillAmount);
        }

        [Test]
        public void _2_Sets_Image_With_75_Fill_To_25_Fill()
        {
            heart.m_image.fillAmount = 0.75f;
            heart.Deplete(2);

            Assert.AreEqual(0.25f, heart.m_image.fillAmount);
        }

        [Test]
        public void _Throws_Exception_For_Negative_Number_Of_Heart_Pieces()
        {
            Assert.Throws<ArgumentException>(() => heart.Deplete(-1));
        }
    }
}
