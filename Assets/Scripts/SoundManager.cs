using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private Slider musicSlider;

    void Start() {
        if (!PlayerPrefs.HasKey("musicVolume")) {
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
        }

        else {
            Load();
        }
    }

    public void SetVolume(float volume) {
        AudioListener.volume = musicSlider.value;
        Save();
    }

    public void Load() {
        musicSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }

    public void Save() {
        PlayerPrefs.SetFloat("musicVolume", musicSlider.value);
    }
}
