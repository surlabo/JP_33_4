using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject Panel;
    public Toggle soundTGL;




    private void Start()
    {
        Panel.SetActive(false);
    }



    public void OnClickStartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void OnClickOpenSettings()
    {
        Panel.SetActive(true);
    }
    public void OnClickExsit()
    {
        Panel.SetActive(false);
    }
    public void ToogleSound()
    {
        if (soundTGL.isOn)
            Debug.Log("Sound Is On");
        else Debug.Log("Sound Is Off");
    }
    public void ChangeVolume()
    {
        //xmis daweva aweva
    }

}
