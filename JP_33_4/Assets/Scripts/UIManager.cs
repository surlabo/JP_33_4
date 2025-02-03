using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Slider slider;
    public GameObject myImage;
    public Transform parent;
            
    int score = 0;
    public TMP_Text ScoreText;

    private void Start()
    {
        
        Instantiate(myImage, parent);
    }


    public void Addscore()
    {
        score += 10;
        ScoreText.text = score.ToString() + "$";
    }

    public void OnSliderValueChange()
    {
        Debug.Log(slider.value);
    }
}
