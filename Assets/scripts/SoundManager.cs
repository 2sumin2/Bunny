using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audioSource;
    public AudioClip step;
    public AudioClip start;
    public AudioClip click;

    public AudioClip jump;

    public AudioClip oww;
    public AudioClip shock;
    public AudioClip die;
    public AudioClip item;
    public AudioClip carrot;
    public AudioClip crack;
    public AudioClip destroy;

    public static SoundManager instance;

    void Awake()
    {
        if (SoundManager.instance == null)
        {
            SoundManager.instance = this;
        }
    }

    public void PlayStepSound()
    {
        audioSource.PlayOneShot(step);
    }

    public void PlayStartSound()
    {
        audioSource.PlayOneShot(start);
    }
    public void PlayClickSound()
    {
        audioSource.PlayOneShot(click);
    }
    public void PlayOwwSound()
    {
        audioSource.PlayOneShot(oww);
    }
    public void PlayShockSound()
    {
        audioSource.PlayOneShot(shock);
    }
    public void PlayDieSound()
    {
        audioSource.PlayOneShot(die);
    }
    public void PlayJumpSound()
    {
        audioSource.PlayOneShot(jump);
    }
    public void PlayItemSound()
    {
        audioSource.PlayOneShot(item);
    }
    public void PlayCarrotSound()
    {
        audioSource.PlayOneShot(carrot);
    }
    public void PlayCrackSound()
    {
        audioSource.PlayOneShot(crack);
    }
    public void PlayDestroySound()
    {
        audioSource.PlayOneShot(destroy);
    }

}
