using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public bool isGameOver;
    public GameObject pauseOverlay;
    public GameObject gameOverMenu;
    public StarterAssets.ThirdPersonController playerControl;
    public StarterAssets.StarterAssetsInputs mouseInput;
    public Animator pauseOverlayAnim;
    public Pause pauseScript;

    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;
        gameOverMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            mouseInput.cursorInputForLook = false;
            mouseInput.cursorLocked = false;
            pauseOverlay.SetActive(true);
            // pauseMenu.SetActive(true);
            playerControl.enabled = false;
            gameOverMenu.SetActive(true);

            if (pauseOverlayAnim.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
            {
                Time.timeScale = 0;
            }

            if (Input.GetKeyDown(KeyCode.JoystickButton0))
            {
                restartGame();
            }

            if (Input.GetKeyDown(KeyCode.JoystickButton3))
            {
                pauseScript.toMainMenu();
            }
        }

    }

    public void restartGame()
    {
        isGameOver = false;
        Time.timeScale = 1;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        mouseInput.cursorInputForLook = true;
        mouseInput.cursorLocked = true;
        playerControl.enabled = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
