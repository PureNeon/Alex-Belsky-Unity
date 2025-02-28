using UnityEngine;
using UnityEngine.UI;

public class SettingMusicController : MonoBehaviour
{
    [SerializeField] private Slider _volumeSlider;
    [SerializeField] private Toggle _muteToggle;

    private void Start()
    {
        _volumeSlider.value = AudioManager.Instance.Volume;
        _muteToggle.isOn = AudioManager.Instance.Mute;
    }

    public void ChangeVolume() => AudioManager.Instance.ChangeVolume(_volumeSlider.value);
    public void ChangeMute() => AudioManager.Instance.ChangeMute(_muteToggle.isOn);
}
