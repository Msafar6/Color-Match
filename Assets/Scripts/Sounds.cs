using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Sounds 
{
    public string ClipName;
    [HideInInspector]
    public AudioSource AudioSource;
    
    public AudioClip AudioClip;
    [Range(0,1)]
    public float pitch;
    [Range(0, 1)]
    public float Volume;

}
