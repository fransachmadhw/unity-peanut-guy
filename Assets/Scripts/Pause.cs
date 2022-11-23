using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public bool pause = false;
    public RawImage pauseOverlay;
    public GameObject pauseMenu;
    public StarterAssets.ThirdPersonController playerControl;
    public StarterAssets.StarterAssetsInputs mouseInput;
    // Start is called before the first frame update
    void Start()
    {
        pauseOverlay.enabled = false;
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!pause)
        {
            // if (Input.GetKeyDown(KeyCode.Escape))
            // {
            //     mouseInput.cursorInputForLook = false;
            //     mouseInput.cursorLocked = false;
            //     pauseOverlay.enabled = true;
            //     pauseMenu.SetActive(true);
            //     Time.timeScale = 0;
            //     playerControl.enabled = false;
            //     pause = true;
            //     // player.myText.text = "Paused";
            //     // player.myText2.gameObject.SetActive(true);
            // }
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
        Cursor.visible = false;
        mouseInput.cursorInputForLook = true;
        mouseInput.cursorLocked = true;
        pauseOverlay.enabled = false;
        pauseMenu.SetActive(false);
        pause = false;
        playerControl.enabled = true;
        // player.myText.text = "";
        // player.myText2.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void toMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
