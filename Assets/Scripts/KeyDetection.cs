using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KeyDetection : MonoBehaviour
{
    public int totalKey = 0;
    public Text key;
    public RawImage keyStatus;
    public AudioClip PickUpKey;
    [Range(0, 10)] public float PickUpKeyVolume = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        keyStatus.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        key.text = "" + totalKey;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Key")
        {
            Destroy(other.gameObject);
            totalKey += 1;
            AudioSource.PlayClipAtPoint(PickUpKey, transform.position, PickUpKeyVolume);
            StartCoroutine(obtainKey());
        }
    }

    public IEnumerator obtainKey()
    {
        keyStatus.enabled = true;
        yield return new WaitForSeconds(2);
        keyStatus.enabled = false;
    }
}
