using System;
using UnityEngine;
using UnityEngine.Advertisements;
using static UnityEngine.Video.VideoPlayer;

namespace Advertise.UnityAds
{
    /// <summary>
    /// Unity Ads Legacy API 지원 서비스 클래스
    /// </summary>
    public class LegacyAdsService : IAdsService
    {
        public UnityAdsSO Container { get; set; }

        private UnityAdsInitializer m_initializer;
        private UnityAdsEventHandler m_eventHandler;

        public LegacyAdsService(UnityAdsSO container, UnityAdsEventHandler eventHandler)
        {
            Container = container;
            m_eventHandler = eventHandler;
        }

        public void Initialize()
        {
            string gameID = string.Empty;
            if (Application.platform == RuntimePlatform.Android) 
            {
                gameID = Container.AndroidGameID;
            }
            else if(Application.platform == RuntimePlatform.IPhonePlayer)
            {
                gameID = Container.IOSGameID;
            }

            m_initializer = new UnityAdsInitializer();
            m_initializer.Initialize(gameID, true);

            //광고 로드
            Advertisement.Load(Container.interstitialPlacementID, m_eventHandler);
            Advertisement.Load(Container.rewardPlacementID, m_eventHandler);
        }

        public void ShowInterstitial()
        {
            if (m_eventHandler.InterstitialReady)
            {
                Advertisement.Show(Container.interstitialPlacementID, m_eventHandler);
            }
        }

        public void ShowReward()
        {
            if (m_eventHandler.RewardReady)
            {
                Advertisement.Show(Container.rewardPlacementID, m_eventHandler);
            }
        }
    }
}
