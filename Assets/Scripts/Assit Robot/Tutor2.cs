using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutor2 : MonoBehaviour
{
    public GameObject theRobot;
    public GameObject tutorText;
    public AudioSource robotVoice;
    public GameObject theTrigger;
    public GameObject theBlocker2;

    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(robotTutor());
    }

    IEnumerator robotTutor()
    {
        theBlocker2.SetActive(true);
        theBlocker2.transform.parent = null;
        theRobot.SetActive(true);
        robotVoice.Play();
        tutorText.SetActive(true);
        yield return new WaitForSeconds(2);
        theBlocker2.SetActive(false);
        Destroy(theTrigger);
        tutorText.SetActive(false);
        robotVoice.Pause();
        theRobot.SetActive(false);
    }
}
