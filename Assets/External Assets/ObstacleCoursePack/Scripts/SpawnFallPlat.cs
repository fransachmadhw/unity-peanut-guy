using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFallPlat : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] tes;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        // foreach (ContactPoint contact in collision.contacts)
        // {
        //Debug.DrawRay(contact.point, contact.normal, Color.white);
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(Spawn(3));
        }
        // }
    }

    IEnumerator Spawn(float time)
    {
        yield return new WaitForSeconds(time);
        tes[0].SetActive(true);
        tes[1].SetActive(true);
    }
}
