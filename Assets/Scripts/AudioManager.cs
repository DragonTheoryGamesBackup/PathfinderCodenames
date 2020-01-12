using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour {

    [SerializeField]
    AudioSource click;
    [SerializeField]
    AudioSource music;

    [SerializeField]
    Slider clickSlider;
    [SerializeField]
    Slider musicSlider;



    private float musicVolume = .3f;
    private float soundVolume = .5f;

    private void Update() {
        click.volume = soundVolume;
        music.volume = musicVolume * .3f;
    }

    public void PlayClick() {
        click.Play();
    }

    public void SetOptionsVolume() {
        clickSlider.value = soundVolume;
        musicSlider.value = musicVolume;
    }

    public void SetClickVolume(float vol) {
        soundVolume = vol;
    }

    public void SetMusicVolume(float vol) {
        musicVolume = vol;
    }
}
