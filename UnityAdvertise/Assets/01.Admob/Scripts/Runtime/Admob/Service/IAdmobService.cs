using UnityEngine;

namespace Advertise.Admob
{
    /// <summary>
    /// 구글 애드몹 서비스 인터페이스 : 초기화, 로드, 보여주기, 숨기기
    /// </summary>
    public interface IAdmobService
    {
        public void Initialize();
        public void LoadAd();
        public void ShowAd();
        public void HideAd();
    }

}
