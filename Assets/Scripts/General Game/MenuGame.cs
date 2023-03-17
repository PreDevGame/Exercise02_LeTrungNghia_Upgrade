using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuGame : MonoBehaviour
{
    public GameObject fakeOut;
    public AudioSource clickSound;
    public bool startCursorState = false;

    [Header("Mouse Cursor Settings")]
    public bool cursorLocked = true;
    public bool cursorInputForLook = true;

    void Start()
    {
        SetCursorState(startCursorState);
    }

    public void buttonNewGame()
    {
        StartCoroutine(NewGame());
    }

    IEnumerator NewGame()
    {
        clickSound.Play();
        yield return new WaitForSeconds(2);
        fakeOut.SetActive(true);
        SetCursorState(cursorLocked);
        SceneManager.LoadScene(1);
    }

    private void SetCursorState(bool newState)
    {
        Cursor.lockState = newState ? CursorLockMode.Locked : CursorLockMode.None;
    }

    public void buttonCreditGame()
    {
        StartCoroutine(CreditGame());
    }

    IEnumerator CreditGame()
    {
        clickSound.Play();
        yield return new WaitForSeconds(2);
        fakeOut.SetActive(true);
        SceneManager.LoadScene(2);
    }

    public void buttonQuitGame()
    {
        StartCoroutine(QuitGame());
        Application.Quit();
    }

    IEnumerator QuitGame()
    {
        clickSound.Play();
        yield return new WaitForSeconds(2);
        fakeOut.SetActive(true);
    }

}
