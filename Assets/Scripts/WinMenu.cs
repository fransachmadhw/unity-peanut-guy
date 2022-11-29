using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
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
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        mouseInput.cursorInputForLook = false;
        mouseInput.cursorLocked = false;
        playerControl.enabled = false;
    }

    public void toMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
