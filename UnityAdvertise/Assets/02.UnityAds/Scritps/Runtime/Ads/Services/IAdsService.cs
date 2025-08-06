using UnityEngine;
using System;

namespace Advertise.UnityAds
{
    /// <summary>
    /// Unity Ads 서비스 인터페이스
    /// </summary>
    public interface IAdsService
    {
        public UnityAdsSO Container { get; set; }

        /// <summary>
        /// SDK 초기화 메소드
        /// </summary>
        public void Initialize();
        /// <summary>
        /// 전면 광고 요청 메소드
        /// </summary>
        public void ShowInterstitial();
        /// <summary>
        /// 보상 광고 호출 메소드
        /// </summary>
        public void ShowReward();
    
    }

    /// <summary>
    /// Unity Ads 타입
    /// </summary>
    public enum AdsType
    {
        Legacy,
        LevelPlay,
    }
}

