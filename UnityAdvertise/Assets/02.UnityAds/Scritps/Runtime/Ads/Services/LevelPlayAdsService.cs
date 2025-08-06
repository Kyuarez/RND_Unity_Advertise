using UnityEngine;

namespace Advertise.UnityAds
{
    /// <summary>
    /// 현재 Unity Ads 방식(IronSource) 서비스 클래스
    /// </summary>
    public class LevelPlayAdsService : IAdsService
    {
        public UnityAdsSO Container { get; set; }
        public LevelPlayAdsService(UnityAdsSO container)
        {
            Container = container;
        }

        public void Initialize()
        {
            throw new System.NotImplementedException();
        }

        public void ShowInterstitial()
        {
            throw new System.NotImplementedException();
        }

        public void ShowReward()
        {
            throw new System.NotImplementedException();
        }
    }
}
