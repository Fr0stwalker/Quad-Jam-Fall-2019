using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource mainAudioSource;
    [SerializeField] private AudioSource sfxAudioSource;
    [SerializeField] private AudioClip gameOverSound;
    [SerializeField] private AudioClip eatBallDudeSound;
    public void StopMainLoop()
    {
        mainAudioSource.loop = false;
        mainAudioSource.Stop();
    }

    public void PlayEatBallDudeSound()
    {
        sfxAudioSource.PlayOneShot(eatBallDudeSound);
    }

    public void PlayGameOverSound()
    {
        sfxAudioSource.PlayOneShot(gameOverSound);
    }
}
