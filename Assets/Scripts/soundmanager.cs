using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class soundmanager : MonoBehaviour
{

    public Sounds[] sounds;

    public static soundmanager Instance;
    //public AudioSource BG;
    // Start is called before the first frame update
    void Awake()
    {
        
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
         
        foreach (Sounds s in sounds)
        {
            s.AudioSource=gameObject.AddComponent<AudioSource>();
            s.AudioSource.clip = s.AudioClip;
            s.AudioSource.pitch = s.pitch;
            s.AudioSource.volume = s.Volume;
        }
        
        
    }

    private void Start()
    {
        PlaySoundManager("Bg");
    }
    public void PlaySoundManager(string name) 
    {
      Sounds s=  Array.Find(sounds,sound => sound.ClipName == name);
        if (s == null)
            return;
        s.AudioSource.Play();
    }
}
