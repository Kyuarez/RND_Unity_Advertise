using System;
using UnityEngine;

namespace Advertise.UnityAds
{
    /// <summary>
    /// Unity Ads 관련 키 값 데이터 컨테이너
    /// </summary>
    [CreateAssetMenu(menuName = "Container/UnityAds", fileName ="UnityAdsContainer")]
    public class UnityAdsSO : ScriptableObject
    {
        public string AndroidGameID;
        public string IOSGameID;
        public string rewardPlacementID;
        public string interstitialPlacementID;
    }
}
