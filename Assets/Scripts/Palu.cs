using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palu : MonoBehaviour
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

    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "PlayerTabrak")
        {
            scriptGameOver.isGameOver = true;
            AudioSource.PlayClipAtPoint(gameOverClip, other.gameObject.transform.position, gameOverVolume);
        }
    }
}
