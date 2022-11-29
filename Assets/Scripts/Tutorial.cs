using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public GameObject tutorialOverlay;
    public GameObject TutorialMenu1;
    public GameObject TutorialMenu2;
    public GameObject TutorialButton;
    public StarterAssets.ThirdPersonController playerControl;
    public StarterAssets.StarterAssetsInputs mouseInput;
    public bool isTutorial;

    // Start is called before the first frame update
    void Start()
    {
        isTutorial = true;
        tutorialOverlay.SetActive(true);
        TutorialMenu1.SetActive(true);
        TutorialMenu2.SetActive(false);
        TutorialButton.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        mouseInput.cursorInputForLook = false;
        mouseInput.cursorLocked = false;
        playerControl.enabled = false;
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (isTutorial)
        {
            if (Input.GetKeyDown(KeyCode.JoystickButton0))
            {
                understand();
            }
            if (Input.GetKeyDown(KeyCode.JoystickButton1))
            {
                nextTutorial();
            }
            if (Input.GetKeyDown(KeyCode.JoystickButton2))
            {
                previousTutorial();
            }
        }
    }

    public void previousTutorial()
    {
        TutorialMenu1.SetActive(true);
        TutorialMenu2.SetActive(false);
        TutorialButton.SetActive(true);
    }

    public void nextTutorial()
    {
        TutorialMenu1.SetActive(false);
        TutorialMenu2.SetActive(true);
        TutorialButton.SetActive(true);
    }

    public void understand()
    {
        isTutorial = false;
        tutorialOverlay.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        mouseInput.cursorInputForLook = true;
        mouseInput.cursorLocked = true;
        playerControl.enabled = true;
        TutorialMenu1.SetActive(false);
        TutorialMenu2.SetActive(false);
        TutorialButton.SetActive(false);
        Time.timeScale = 1;
    }
}
