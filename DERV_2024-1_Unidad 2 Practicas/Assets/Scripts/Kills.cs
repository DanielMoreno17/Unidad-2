using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Kills : MonoBehaviour
{
    public TextMeshProUGUI txt_score;
    public TextMeshProUGUI txt_feed;
    public TextMeshProUGUI txt_eggs;

    ChangeScene cambia;

    void Start()
    {
        cambia = GetComponent<ChangeScene>();
    }

    // Update is called once per frame
    void Update()
    {
        double score = Convert.ToDouble(txt_score.text);

        if (score == 5)
        {
            cambia.change(2);
        }
        //float score = float.Parse(txt_score.text);
    }
}
