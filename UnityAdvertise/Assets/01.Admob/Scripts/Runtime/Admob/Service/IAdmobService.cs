using UnityEngine;

namespace Advertise.Admob
{
    /// <summary>
    /// ���� �ֵ�� ���� �������̽� : �ʱ�ȭ, �ε�, �����ֱ�, �����
    /// </summary>
    public interface IAdmobService
    {
        public void Initialize();
        public void LoadAd();
        public void ShowAd();
        public void HideAd();
    }

}
