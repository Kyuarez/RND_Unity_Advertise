using UnityEngine.Advertisements;

namespace Advertise.UnityAds
{
    /// <summary>
    /// Unity Ads 초기화 지원 클래스 : 이벤트 지원
    /// </summary>
    public class UnityAdsInitializer : IUnityAdsInitializationListener
    {
        /// <summary>
        /// Ads 초기화 메소드
        /// </summary>
        /// <param name="gameID">유니티 대시보드에서 발급받은 id</param>
        /// <param name="isTest">test 여부</param>
        public void Initialize(string gameID, bool isTest)
        {
            Advertisement.Initialize(gameID, isTest, this);
        }

        public void OnInitializationComplete()
        {
            //TODO : UITestAds에 Text 반영
        }

        public void OnInitializationFailed(UnityAdsInitializationError error, string message)
        {
            //TODO : UITestAds에 Text 반영
        }
    }
}
