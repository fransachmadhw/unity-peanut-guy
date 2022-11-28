using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelCount : MonoBehaviour
{
    public int levelCount;
    public Text count;
    // Start is called before the first frame update
    void Start()
    {
        count.text = "" + levelCount;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
