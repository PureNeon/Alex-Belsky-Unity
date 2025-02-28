using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    private AudioSource _audioSource;
    public float Volume { get => _audioSource.volume; }
    public bool Mute { get => _audioSource.mute; }
    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            _audioSource = GetComponent<AudioSource>();
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void ChangeVolume(float value) => _audioSource.volume = value;

    public void ChangeMute(bool mute) => _audioSource.mute = mute;
}
