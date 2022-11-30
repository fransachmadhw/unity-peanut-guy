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
    public GameObject congrats;
    public StarterAssets.ThirdPersonController playerControl;
    public bool isFinished;
    public AudioClip levelWinClip;
    [Range(0, 1)] public float levelWinVolume = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        congrats.SetActive(false);
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
        if (isFinished)
        {
            if (Input.GetKeyDown(KeyCode.JoystickButton0))
            {
                goToNextLevel();
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (keyDetection.totalKey == 5)
        {
            if (other.gameObject.tag == "Player")
            {
                confetti.SetActive(true);
                Menang();
                playerControl.enabled = false;
                AudioSource.PlayClipAtPoint(levelWinClip, other.gameObject.transform.position, levelWinVolume);
            }
        }
    }

    public void Menang()
    {
        isFinished = true;
        congrats.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void goToNextLevel()
    {
        isFinished = false;

        if (nextLevel == 6)
        {
            SceneManager.LoadScene("Win");
        }
        else
        {
            SceneManager.LoadScene("Level" + nextLevel);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
