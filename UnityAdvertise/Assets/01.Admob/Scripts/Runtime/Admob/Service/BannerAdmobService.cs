using System;
using GoogleMobileAds.Api;

namespace Advertise.Admob
{
    public class BannerAdmobService : IAdmobService
    {
        private AdmobSO m_Container;
        private BannerView m_BannerView;

        public BannerAdmobService(AdmobSO container)
        {
            m_Container = container;
        }

        public void Initialize()
        {
            m_BannerView = new BannerView(m_Container.TestUnitID, AdSize.SmartBanner, AdPosition.Bottom);
        }

        public void LoadAd()
        {
            AdRequest request = new AdRequest();
            m_BannerView.LoadAd(request);
        }

        public void HideAd()
        {
            m_BannerView.Hide();
        }

        public void ShowAd()
        {
            m_BannerView.Show();
        }        
    }
}
