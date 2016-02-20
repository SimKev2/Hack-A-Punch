using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class AudioScript : MonoBehaviour
{
    public AudioClip impact;
    AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.name == "Bag")
        {
            audio.PlayOneShot(impact, 0.7F);
        }
    }
}