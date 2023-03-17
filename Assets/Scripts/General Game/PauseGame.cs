using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public GameObject pauseGameUI;
    public GameObject Blocker;
    public AudioSource gameAudio;
    public AudioSource robotVoice;
    public AudioSource clickSound;
    public bool pauseGame = false;

    [Header("Mouse Cursor Settings")]
    public bool cursorLocked = true;
    public bool cursorInputForLook = true;

    void Update()
    {
        if(Input.GetButtonDown("Cancel"))
        {
            SetCursorState(cursorLocked);
            if (pauseGame == false)
            {
                Time.timeScale = 0;
                Blocker.SetActive(true);
                Blocker.transform.parent = null;
                pauseGame = true;
                gameAudio.Pause();
                robotVoice.Pause();
                pauseGameUI.SetActive(true);
                Cursor.visible = true;
                
            }

            else
            {
                pauseGame = false;
                gameAudio.UnPause();
                robotVoice.UnPause();
                pauseGameUI.SetActive(false);
                Cursor.visible = false;
                Blocker.SetActive(false);
                Time.timeScale = 1;
            }
        }
    }

    private void SetCursorState(bool newState)
    {
        Cursor.lockState = newState ? CursorLockMode.None : CursorLockMode.Locked;
    }

    public void ContinueGame()
    {
        clickSound.Play();
        pauseGame = false;
        gameAudio.UnPause();
        robotVoice.UnPause();
        pauseGameUI.SetActive(false);
        Cursor.visible = false;
        Blocker.SetActive(false);
        Time.timeScale = 1;
    }

    public void RestartGame()
    {
        clickSound.Play();
        pauseGame = false;
        gameAudio.UnPause();
        robotVoice.UnPause();
        pauseGameUI.SetActive(false);
        Cursor.visible = false;
        Blocker.SetActive(false);
        Time.timeScale = 1;
        GunFire.theSoliderKilled = 0;
        GiftPickup.theScoreValue = 0;
        GlobalAmmo.theAmmoValue = 0;
        SceneManager.LoadScene(1);
    }

    public void BackToMenu()
    {
        clickSound.Play();
        pauseGame = false;
        gameAudio.UnPause();
        robotVoice.UnPause();
        pauseGameUI.SetActive(false);
        Cursor.visible = false;
        Blocker.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
