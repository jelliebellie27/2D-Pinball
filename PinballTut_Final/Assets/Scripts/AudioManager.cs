using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AudioManager : MonoBehaviour
{
    public Button btnOn;
    public Button btnOff;

    public AudioSource audioSource;

    // Use this for initialization
    public void Start()
    {
        btnOn = GetComponent<Button>();
        btnOff = GetComponent<Button>();

        // Either use this, or assign the component from inspector
        audioSource = GetComponent<AudioSource>();

        btnOn.onClick.AddListener(() => PlayAudio());
        btnOff.onClick.AddListener(() => StopAudio());
    }

    public void PlayAudio()
    {
        audioSource.volume = 0.5f;
    }

    public void StopAudio()
    {
        audioSource.volume = 0f;
    }
}