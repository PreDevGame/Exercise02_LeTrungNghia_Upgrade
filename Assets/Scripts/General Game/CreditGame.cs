using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditGame : MonoBehaviour
{
    public GameObject creditText;
    public GameObject fakeOut;

    void Update()
    {
        StartCoroutine(creditAction());
    }

    IEnumerator creditAction()
    {
        creditText.GetComponent<Animator>().Play("Credit");
        yield return new WaitForSeconds(15);
        fakeOut.SetActive(true);
        SceneManager.LoadScene(0);
    }
}
