using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelShowcase : MonoBehaviour
{
    public bool isShowcasing = false;
    public Canvas canvas;
    public GameObject player;
    public Tutorial tutorial;
    public float timer;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        isShowcasing = true;
        canvas.gameObject.SetActive(false);
        player.SetActive(false);
        tutorial.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time >= timer)
        {
            Destroy(gameObject);
            canvas.gameObject.SetActive(true);
            player.SetActive(true);
            tutorial.enabled = true;
            isShowcasing = false;
        }
    }
}
