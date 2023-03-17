using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutor1 : MonoBehaviour
{
    public GameObject theRobot;
    public AudioSource robotVoice;
    public GameObject pannelTutor;
    public GameObject text0;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    public GameObject theStartTrigger;
    public GameObject theBlocker;

    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(robotsTutor1());
        
    }

    IEnumerator robotsTutor1()
    {
        theBlocker.SetActive(true);
        theBlocker.transform.parent = null;
        theRobot.SetActive(true);
        robotVoice.Play();
        pannelTutor.SetActive(true);
        text0.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        text0.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        text1.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        text1.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        text2.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        text2.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        text3.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        text3.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        text4.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        text4.SetActive(false);
        pannelTutor.SetActive(false);
        theBlocker.SetActive(false);
        Destroy(theStartTrigger);
        theRobot.SetActive(false);
        robotVoice.Pause();
    }
}
