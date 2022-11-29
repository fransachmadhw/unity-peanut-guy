using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public StarterAssets.ThirdPersonController playerControl;
    public StarterAssets.StarterAssetsInputs mouseInput;
    public AudioSource audioMenu;
    [Range(0, 10)] public float audioVolume = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        audioMenu.Play();
    }

    // Update is called once per frame
    void Update()
    {
        audioMenu.volume = audioVolume;
        if (Input.GetKeyDown(KeyCode.JoystickButton7))
        {
            Play();
        }
    }

    public void Play()
    {
        SceneManager.LoadScene("Level1");
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        // mouseInput.cursorInputForLook = true;
        // mouseInput.cursorLocked = true;
        // playerControl.enabled = true;
    }

    public void Exit()
    {
        Application.Quit();
    }
}
