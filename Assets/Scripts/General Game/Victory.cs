using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Victory : MonoBehaviour
{
    public GameObject theTreasure;
    public GameObject theBook;
    public AudioSource treasureSound;
    public AudioSource victorySound;
    public GameObject theRobot;
    public GameObject vicoryPannel;
    public GameObject totalScorePannel;
    public GameObject theTrigger;
    public GameObject theBlocker3;
    public GameObject magicBookValue;
    public GameObject totalScoreValue;
    public GameObject soldierKilledValue;

    void OnTriggerEnter(Collider other)
    {
        theTreasure.SetActive(true);
        theBlocker3.SetActive(true);
        theBlocker3.transform.parent = null;
        if (GoldKey.hasKey == 1)
        {
            StartCoroutine(VicrotyAnimate());
        }
    }

    IEnumerator VicrotyAnimate()
    {
        yield return new WaitForSeconds(1);
        treasureSound.Play();
        theTreasure.GetComponent<Animator>().Play("ArmatureAction");
        yield return new WaitForSeconds(8);
        treasureSound.Pause();
        theBook.SetActive(true);
        theBook.GetComponent<Animator>().Play("Go out");
        yield return new WaitForSeconds(0.2f);
        theBook.GetComponent<Animator>().Play("Take 01");
        victorySound.Play();
        theRobot.SetActive(true);
        vicoryPannel.SetActive(true);
        yield return new WaitForSeconds(6);
        vicoryPannel.SetActive(false);
        totalScorePannel.SetActive(true);
        yield return new WaitForSeconds(1);
        magicBookValue.GetComponent<Text>().text = "Magic book: " + GoldKey.hasKey;
        yield return new WaitForSeconds(1);
        totalScoreValue.GetComponent<Text>().text = "Score: " + GiftPickup.theScoreValue;
        yield return new WaitForSeconds(1);
        soldierKilledValue.GetComponent<Text>().text = "Soldier killed: " + GunFire.theSoliderKilled;
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(0);

    }
}
