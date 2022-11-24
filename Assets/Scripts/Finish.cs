using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Finish : MonoBehaviour
{
    public MeshRenderer finish;
    public KeyDetection keyDetection;
    public GameObject finishTemp;
    public GameObject confetti;
    public int nextLevel;
    public TMP_Text congrats;
    public TMP_Text nextLevelCountdown;
    // Start is called before the first frame update
    void Start()
    {
        congrats.enabled = false;
        nextLevelCountdown.enabled = false;
        confetti.SetActive(false);
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
                confetti.SetActive(true);
                StartCoroutine(Menang());
            }
        }
    }

    public IEnumerator Menang()
    {
        congrats.enabled = true;
        nextLevelCountdown.enabled = true;
        // isMoving = false;
        for (int i = 5; i > 0; i--)
        {
            nextLevelCountdown.text = $"Switching to next level in {i}";
            yield return new WaitForSeconds(1);
        }
        SceneManager.LoadScene("Level" + nextLevel);
    }
}
