using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Advertise.UnityAds
{

    /// <summary>
    /// Unity Ads 테스트를  위한 UI 프리팹 스크립트
    /// </summary>
    public class UITestAds : MonoBehaviour
    {
        [SerializeField] AdsType m_AdsType;
        [SerializeField] UnityAdsSO m_Container;
        [SerializeField] Button m_interstitialBtn;
        [SerializeField] Button m_rewardBtn;
        [SerializeField] TextMeshProUGUI m_stateText;

        private IAdsService m_Service;

        private void Awake()
        {
            InitializeAdsService(m_AdsType);
            m_Service.Initialize();
        }

        private void InitializeAdsService(AdsType adsType)
        {
            if (adsType == AdsType.Legacy)
            {
                UnityAdsEventHandler handler = new UnityAdsEventHandler(m_Container);
                m_Service = new LegacyAdsService(m_Container, handler);
            }
            else
            {

            }
        }

        private void Start()
        {
            m_interstitialBtn.onClick.AddListener(m_Service.ShowInterstitial);
            m_rewardBtn.onClick.AddListener(m_Service.ShowReward);
        }

    }

}
