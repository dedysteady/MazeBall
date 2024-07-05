using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundsfx : MonoBehaviour
{
    public AudioClip click;

    private AudioSource player;

    private void Start()
    {
        player = GetComponent<AudioSource>();
    }

    private void Update()
    {

    }

    public void PlayClick()
    {
        player.PlayOneShot(click);
    }
}