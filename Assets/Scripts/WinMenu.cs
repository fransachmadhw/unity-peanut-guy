using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    public StarterAssets.ThirdPersonController playerControl;
    public StarterAssets.StarterAssetsInputs mouseInput;
    public AudioSource winMenu;
    [Range(0, 1)] public float winMenuVolume = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        winMenu.Play();
    }

    // Update is called once per frame
    void Update()
    {
        winMenu.volume = winMenuVolume;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        mouseInput.cursorInputForLook = false;
        mouseInput.cursorLocked = false;
        playerControl.enabled = false;

        if (Input.GetKeyDown(KeyCode.JoystickButton0))
        {
            toMainMenu();
        }
    }

    public void toMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
