using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class UIManager : MonoBehaviour
{
    public Slider slider;
    public GameObject myImage;
    public Transform parent;
    public Button CreateButton;
    public Toggle myToggle;
    public Slider sl;



    int score = 0;
    public TMP_Text ScoreText;

    private void Start()
    {
        CreateButton.onClick.AddListener(OnImageCreateButtonClick);
        myToggle.onValueChanged.AddListener(Rame);
        Instantiate(myImage, parent);
    }


    public void Addscore()
    {
        score += 10;
        ScoreText.text = score.ToString() + "$";
    }

   

    public void OnImageCreateButtonClick()
    {
        Instantiate(myImage, parent);
    }

    public void Rame(bool value)
    {

    }
}
