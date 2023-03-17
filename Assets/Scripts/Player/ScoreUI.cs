using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public GameObject theScoreText;
    public static int theCurrentScore;

    void Start()
    {
        theCurrentScore = 0;
    }
    void LateUpdate()
    {
        theCurrentScore = GiftPickup.theScoreValue;
        theScoreText.GetComponent<Text>().text = "" + theCurrentScore;
    }
}
