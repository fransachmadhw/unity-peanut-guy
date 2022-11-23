using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPos : MonoBehaviour
{
    public Vector3 checkPoint;
    // Start is called before the first frame update
    void Awake()
    {
        checkPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5f)
        {
            transform.position = checkPoint;
        }
    }

    public void LoadCheckPoint()
    {
        transform.position = checkPoint;
    }
}
