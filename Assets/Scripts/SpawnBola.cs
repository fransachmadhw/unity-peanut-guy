using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBola : MonoBehaviour
{
    public GameObject[] ArrayBola;
    // Start is called before the first frame update
    void Start()
    {
        ArrayBola[0].SetActive(false);
        ArrayBola[1].SetActive(false);
        ArrayBola[2].SetActive(false);
        ArrayBola[3].SetActive(false);
        ArrayBola[4].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Hit");
            ArrayBola[0].SetActive(true);
            ArrayBola[1].SetActive(true);
            ArrayBola[2].SetActive(true);
            ArrayBola[3].SetActive(true);
            ArrayBola[4].SetActive(true);
        }
    }
}
