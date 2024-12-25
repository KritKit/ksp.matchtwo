using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public void playbtn(){
        SceneManager.LoadScene("SampleScene");
    }
    public void exitbtn(){
        Application.Quit();
    }
}
