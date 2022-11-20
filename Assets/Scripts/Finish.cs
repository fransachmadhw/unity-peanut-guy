using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public MeshRenderer finish;
    public KeyDetection keyDetection;
    public GameObject finishTemp;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (keyDetection.totalKey == 5)
        {
            finish.enabled = false;
            finishTemp.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (keyDetection.totalKey == 5)
        {
            if (other.gameObject.tag == "Player")
            {
                SceneManager.LoadScene("Level2");
            }
        }
    }
}
