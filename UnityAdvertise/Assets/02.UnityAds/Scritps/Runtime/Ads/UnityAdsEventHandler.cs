using UnityEngine.Advertisements;

namespace Advertise.UnityAds
{
    /// <summary>
    /// Unity Ads 이벤트 지원 클래스(광고 로드, 광고 Show)
    /// </summary>
    public class UnityAdsEventHandler : IUnityAdsLoadListener, IUnityAdsShowListener
    {
        public bool InterstitialReady { get; private set; }
        public bool RewardReady { get; private set; }

        private UnityAdsSO m_Container;

        public UnityAdsEventHandler(UnityAdsSO container)
        {
            m_Container = container;
        }

        /// <summary>
        /// placement ID에 따른 광고 로드 메소드
        /// </summary>
        /// <param name="placementId"></param>
        public void OnUnityAdsAdLoaded(string placementId)
        {
            if (placementId.Equals(m_Container.interstitialPlacementID))
            {
                InterstitialReady = true;
            }
            else if (placementId.Equals(m_Container.rewardPlacementID))
            {
                RewardReady = true;
            }
        }

        /// <summary>
        /// 광고 로드 실패 메소드
        /// </summary>
        /// <param name="placementId"></param>
        /// <param name="error"></param>
        /// <param name="message"></param>
        public void OnUnityAdsFailedToLoad(string placementId, UnityAdsLoadError error, string message)
        {
            //TODO : UnityTest Ads 연동
        }

        public void OnUnityAdsShowStart(string placementId)
        {
            //TODO : UnityTest Ads 연동
        }

        public void OnUnityAdsShowClick(string placementId)
        {
            //TODO : UnityTest Ads 연동
        }

        public void OnUnityAdsShowComplete(string placementId, UnityAdsShowCompletionState showCompletionState)
        {
            //TODO : UnityTest Ads 연동

            if (placementId == "rewarded" && showCompletionState == UnityAdsShowCompletionState.COMPLETED)
            {
                //TODO : UnityTest Ads 연동
                //보상 요청 로직...
            }

            Advertisement.Load(placementId, this);
        }

        public void OnUnityAdsShowFailure(string placementId, UnityAdsShowError error, string message)
        {
            //TODO : UnityTest Ads 연동
        }
    }
}
