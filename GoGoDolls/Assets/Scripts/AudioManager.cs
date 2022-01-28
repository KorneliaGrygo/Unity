using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public List<Sound> ListOfSounds;
    private void Awake()
    {
        foreach (var sound in ListOfSounds)
        {
            sound.audioSource = gameObject.AddComponent<AudioSource>();
            sound.audioSource.clip = sound.clip;
            sound.audioSource.volume = sound.volume;
            sound.audioSource.pitch = sound.pitch;
            sound.audioSource.loop = sound.isLooped;
        }
    }
    public void Play(string name)
    {
        var song = ListOfSounds.FirstOrDefault(x => x.name == name);
        if(song != null)
            song.audioSource.Play();

    }
    public void Stop()
    {
        foreach (var item in ListOfSounds)
        {
            item.audioSource.Stop();
        }
    }
}
