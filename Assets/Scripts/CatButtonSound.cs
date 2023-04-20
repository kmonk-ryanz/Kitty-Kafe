using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatButtonSound : MonoBehaviour
{
    public AudioSource _meow;

    public void playThisSound()
    {
        _meow.Play();
    }
}
