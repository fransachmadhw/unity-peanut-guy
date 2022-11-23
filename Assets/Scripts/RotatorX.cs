using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorX : MonoBehaviour
{
    public float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        // transform.Rotate(new Vector3(-90, -90, 90));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * speed * Time.deltaTime * 2);
    }
}
