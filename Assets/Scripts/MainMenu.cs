using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public StarterAssets.ThirdPersonController playerControl;
    public StarterAssets.StarterAssetsInputs mouseInput;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

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
