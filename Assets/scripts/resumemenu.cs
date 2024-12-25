using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class resumemenu : MonoBehaviour
{
    public GameObject pausemenu;

    public void resumebtn(){
        pausemenu.SetActive(!pausemenu.activeSelf);
        Time.timeScale = (Time.timeScale == 1f) ? 0 : 1;
    }

    public void restartbtn(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
    public void mainmenu(){
        SceneManager.LoadScene("mainmenu");
    }
    public void quitbtn(){
        Application.Quit();
    }
}
