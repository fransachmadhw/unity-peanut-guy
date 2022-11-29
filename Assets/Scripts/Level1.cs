using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1 : MonoBehaviour
{
    public AudioSource level1Music;
    // public AudioClip level1Music;
    public GameObject PlayerNut;
    public Finish scriptFinish;
    [Range(0, 20)] public float level1MusicVolume = 3f;

    // Start is called before the first frame update
    void Start()
    {
        level1Music.Play();

    }

    // Update is called once per frame
    void Update()
    {
        if (scriptFinish.isFinished == false)
        {
            level1Music.volume = level1MusicVolume;
        }
    }
}
