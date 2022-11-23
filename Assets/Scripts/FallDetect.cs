using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDetect : MonoBehaviour
{
    public Vector3 reset;
    public GameObject fall;
    // Start is called before the first frame update
    
    void Awake(){
        reset = transform.position;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "fall")
        {
            fall.transform.position = reset;
            Debug.Log("Jatuh");
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
