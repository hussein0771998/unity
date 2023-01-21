using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{

    public AudioClip[] audioClips;
    private void Start()
    {
        SoundPlayer(1, 5);
    }
    public void SoundPlayer(int num , float time)
    {
        GameObject audio = new GameObject();
        audio.AddComponent<AudioSource>();
        GameObject soundObject = Instantiate(audio, transform.position, Quaternion.identity, null);
        soundObject.GetComponent<AudioSource>().clip= audioClips[num];
        soundObject.GetComponent<AudioSource>().Play();
        Destroy(soundObject, time);
    }

}
