using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2 : MonoBehaviour
{
    public AudioSource level2Music;
    // public AudioClip level1Music;
    public GameObject PlayerNut;
    public Finish scriptFinish;
    [Range(0, 1)] public float level2MusicVolume = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        level2Music.Play();

    }

    // Update is called once per frame
    void Update()
    {
        if (scriptFinish.isFinished == false)
        {
            level2Music.volume = level2MusicVolume;
        }
    }
}
