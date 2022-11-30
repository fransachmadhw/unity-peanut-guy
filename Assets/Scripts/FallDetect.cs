using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDetect : MonoBehaviour
{
    public GameOver scriptGameOver;
    public AudioClip gameOverClip;
    public GameObject player;
    [Range(0, 1)] public float gameOverVolume = 0.5f;
    // public Vector3 reset;
    // public GameObject fall;
    // Start is called before the first frame update

    // void Awake(){
    //     reset = transform.position;
    // }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // void OnCollisionEnter(Collision collision)
    // {
    //     if (collision.gameObject.tag == "fall")
    //     {
    //         fall.transform.position = reset;
    //         Debug.Log("Jatuh");
    //     }
    // }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            scriptGameOver.isGameOver = true;
            AudioSource.PlayClipAtPoint(gameOverClip, other.gameObject.transform.position, gameOverVolume);
        }
    }

    public void ResetPlayer()
    {
        // fall.transform.position = reset;
        // player.myText.text = "";
        // player.ResetButton.gameObject.SetActive(false);
        // player.gameObject.SetActive(true);
        // player.isMoving = true;
    }
}
