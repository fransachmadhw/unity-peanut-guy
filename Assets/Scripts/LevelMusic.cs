using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMusic : MonoBehaviour
{
    public AudioSource levelMusic;
    // public AudioSource gameOverAudio;
    // public AudioClip level1Music;
    public GameObject PlayerNut;
    public Finish scriptFinish;
    public GameOver scriptGameOver;
    [Range(0, 1)] public float levelMusicVolume = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        levelMusic.Play();

    }

    // Update is called once per frame
    void Update()
    {
        levelMusic.volume = levelMusicVolume;
        if (scriptFinish.isFinished)
        {
            levelMusic.Stop();
        }

        if (scriptGameOver.isGameOver)
        {
            levelMusic.Stop();

        }
    }
}
