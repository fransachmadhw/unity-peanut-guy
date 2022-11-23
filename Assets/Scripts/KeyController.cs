using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{
    private int keyCollect = 0;

    void Update()
    {

    }

    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Key")
        {
            Destroy(collision.gameObject);
            keyCollect = keyCollect + 1;
            Debug.Log(keyCollect);
        }
    }
}
