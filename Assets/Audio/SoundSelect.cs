using UnityEngine;
using System.Collections;

public class SoundSelect : MonoBehaviour
{

    public AudioSource randomSound;

    public AudioClip[] audioSources;

    // Use this for initialization
    void Start()
    {
        CallAudio();
    }


    void CallAudio()
    {
        int a = RandInt();
        Invoke("RandomSoundness(int a)", GetLength(a));
    }

    int RandInt()
    {
        return Random.Range(0, audioSources.Length);
    }

    float GetLength(int a)
    {
        return audioSources[a].length;
    }

    void RandomSoundness(int a)
    {
        randomSound.clip = audioSources[a];
        randomSound.Play();
        CallAudio();
    }
}