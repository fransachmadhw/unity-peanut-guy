using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGameOver : MonoBehaviour
{
    public GameOver scriptGameOver;
    public AudioClip gameOverClip;
    [Range(0, 1)] public float gameOverVolume = 0.5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (scriptGameOver.isGameOver)
        {
            // AudioSource.PlayClipAtPoint(gameOverClip, transform.position, gameOverVolume);
        }
    }
}
