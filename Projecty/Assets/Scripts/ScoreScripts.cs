using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScripts : MonoBehaviour
{
    public GameObject textscore;
    public Text Score;
    public int CatchCoin;

    // Start is called before the first frame update
    void Start()
    {
        Score = textscore.GetComponent<Text>();
        CatchCoin = 0;
    }

    // Update is called once per frame
    void Update()
    {
     
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Coin")
        {
            CatchCoin++;
            Score.text = "" + CatchCoin;
        }
    }
}
