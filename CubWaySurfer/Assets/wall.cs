using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wall : MonoBehaviour
{
    public Text ScoreText;
    public int score = 0;
    public int increase = 1;

    private void OnTriggerEnter(Collider collision)
    {
        score = score + increase;
        ScoreText.text = score.ToString();
    }

        void Start()
    {

    }

    void Update()
    {

    }
}

