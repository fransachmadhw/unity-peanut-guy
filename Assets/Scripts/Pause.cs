using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public bool pause = false;
    public GameObject pauseOverlay;
    public GameObject pauseMenu;
    public StarterAssets.ThirdPersonController playerControl;
    public StarterAssets.StarterAssetsInputs mouseInput;
    public Animator test;
    // Start is called before the first frame update
    void Start()
    {
        pauseOverlay.SetActive(false);
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!pause)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                pause = true;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                mouseInput.cursorInputForLook = false;
                mouseInput.cursorLocked = false;
                pauseOverlay.SetActive(true);
                pauseMenu.SetActive(true);
                playerControl.enabled = false;

            }
        }
        if (test.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
        {
            Time.timeScale = 0;
        }
        if (pause)
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                // pause = false;
                // Cursor.visible = false;
                // Cursor.lockState = CursorLockMode.Locked;
                // mouseInput.cursorInputForLook = true;
                // mouseInput.cursorLocked = true;
                // pauseOverlay.enabled = false;
                // pauseMenu.SetActive(false);
                // playerControl.enabled = true;
                // Time.timeScale = 1;
                resumeGame();
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                mouseInput.cursorInputForLook = true;
                mouseInput.cursorLocked = true;
            }
        }
        // else if (pause && Input.anyKeyDown)
        // {
        //     pauseOverlay.enabled = false;
        //     pause = false;
        //     playerControl.enabled = true;
        //     // player.myText.text = "";
        //     // player.myText2.gameObject.SetActive(false);
        //     Time.timeScale = 1;
        // }
    }

    public void resumeGame()
    {
        pause = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        mouseInput.cursorInputForLook = true;
        mouseInput.cursorLocked = true;
        pauseOverlay.SetActive(false);
        pauseMenu.SetActive(false);
        playerControl.enabled = true;
        Time.timeScale = 1;
    }

    public void toMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
        mouseInput.cursorInputForLook = true;
        mouseInput.cursorLocked = true;
        playerControl.enabled = true;
    }
}
