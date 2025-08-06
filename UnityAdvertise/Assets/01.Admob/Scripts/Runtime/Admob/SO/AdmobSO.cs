using UnityEngine;

namespace Advertise.Admob
{
    [HelpURL("https://developers.google.com/admob/android/test-ads?hl=ko")]
    [CreateAssetMenu(menuName = "Container/Admob", fileName = "AdmobContainer")]
    public class AdmobSO : ScriptableObject
    {
        [Header("Unit ID")]
        public string UnitID;
        public string TestUnitID;
        public string TestDeviceID;

        [Header("Dummy Ad ID")]
        public string DUMMY_AppOpeningID = "ca-app-pub-3940256099942544/9257395921";
        public string DUMMY_AdaptingID = "ca-app-pub-3940256099942544/9214589741";
        public string DUMMY_FixedSizeBannerID = "ca-app-pub-3940256099942544/6300978111";
        public string DUMMY_InterstitialID = "ca-app-pub-3940256099942544/1033173712";
        public string DUMMY_RewardID = "ca-app-pub-3940256099942544/5224354917";
        public string DUMMY_RewardInterstitialID = "ca-app-pub-3940256099942544/5354046379";
        public string DUMMY_NativeID = "ca-app-pub-3940256099942544/2247696110";
        public string DUMMY_NativeVideoID = "ca-app-pub-3940256099942544/1044960115";

    }
}
