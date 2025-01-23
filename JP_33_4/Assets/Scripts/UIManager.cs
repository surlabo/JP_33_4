using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    int score = 0;
    public TMP_Text ScoreText;

    public void Update()
    {
       
    }


    public void Addscore()
    {
        score += 10;
        ScoreText.text = score.ToString() + "$";
    }
}
