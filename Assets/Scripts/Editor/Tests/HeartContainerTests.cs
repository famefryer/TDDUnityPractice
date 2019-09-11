using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class HeartContainerTests 
{
    public class TheReplenishMethod
    {

        private Image m_image;
        private Heart m_heart;
        private HeartContainer m_HeartContainer;

        [SetUp]
        public void init()
        {
            m_image = new GameObject().AddComponent<Image>();
            m_heart = new Heart(m_image);
            m_HeartContainer = new HeartContainer(new List<Heart> { m_heart });
        }

        [Test]
        public void _0_Sets_Image_With_0_Fill_To_0_Fill()
        {
            m_image.fillAmount = 0;
            m_HeartContainer.Replenish(0);

            Assert.AreEqual(0, m_image.fillAmount);
        }

        [Test]
        public void _1_Sets_Image_With_0_Fill_To_25_Fill()
        {
            m_image.fillAmount = 0;
            m_HeartContainer.Replenish(1);

            Assert.AreEqual(0.25f, m_image.fillAmount);
        }

        [Test]
        public void _Emtry_Hearts_Are_Replenished()
        {

        }
    }
}
