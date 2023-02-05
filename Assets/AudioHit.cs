using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioHit: MonoBehaviour
{
    public AudioSource punch1;
    public AudioSource punch2;
    public AudioSource punch3;
    public AudioSource chop;
    public List<AudioSource> hitList = new List<AudioSource>();

    public void Play()
    {
        hitList.Add(punch1);
        hitList.Add(punch2);
        hitList.Add(punch3);
        hitList.Add(chop);
        int soundSelect = Random.Range(0, hitList.Count);
        var audio = hitList[soundSelect];
        audio.Play();
    }
}
