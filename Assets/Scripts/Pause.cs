using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public bool pause = false;
    public GameOver referensiGameOver;
    public GameObject pauseOverlay;
    public GameObject pauseMenu;
    public StarterAssets.ThirdPersonController playerControl;
    public StarterAssets.StarterAssetsInputs mouseInput;
    public Animator pauseOverlayAnim;
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
                pauseGame();
            }

            if (Input.GetKeyDown(KeyCode.JoystickButton7))
            {
                pauseGame();
            }
        }
        if (pause)
        {
            if (pauseOverlayAnim.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
            {
                Time.timeScale = 0;
            }
            if (Input.GetKeyDown(KeyCode.JoystickButton0))
            {
                toMainMenu();
            }
            if (Input.GetKeyDown(KeyCode.JoystickButton3))
            {
                resumeGame();
            }
            // if (Input.GetKeyDown(KeyCode.JoystickButton7))
            // {
            //     resumeGame();
            // }
        }
    }

    public void pauseGame()
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
        pause = false;
        referensiGameOver.isGameOver = false;
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
        mouseInput.cursorInputForLook = true;
        mouseInput.cursorLocked = true;
        playerControl.enabled = true;
    }
}
