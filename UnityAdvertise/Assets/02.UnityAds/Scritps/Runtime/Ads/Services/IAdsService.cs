using UnityEngine;
using System;

namespace Advertise.UnityAds
{
    /// <summary>
    /// Unity Ads ���� �������̽�
    /// </summary>
    public interface IAdsService
    {
        public UnityAdsSO Container { get; set; }

        /// <summary>
        /// SDK �ʱ�ȭ �޼ҵ�
        /// </summary>
        public void Initialize();
        /// <summary>
        /// ���� ���� ��û �޼ҵ�
        /// </summary>
        public void ShowInterstitial();
        /// <summary>
        /// ���� ���� ȣ�� �޼ҵ�
        /// </summary>
        public void ShowReward();
    
    }

    /// <summary>
    /// Unity Ads Ÿ��
    /// </summary>
    public enum AdsType
    {
        Legacy,
        LevelPlay,
    }
}

