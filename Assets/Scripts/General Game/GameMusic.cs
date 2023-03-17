using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMusic : MonoBehaviour
{
    public AudioSource gameAudio;

    private void Awake()
    {
        gameAudio.Play();
    }
}
