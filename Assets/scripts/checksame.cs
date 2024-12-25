using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class checksame : MonoBehaviour
{
    public scrgame scrgame;
    public GameObject[] btnmatching = new GameObject[4];
    public GameObject blindBG, setMenu;
    public static int moreonez;
    public int stackscore = 0; 
    public List<int> infoscore = new List<int>();
    public static List<int> posiscore = new List<int>();
    public TextMeshProUGUI scoretext,finalscore;

    void Start(){
        blindBG.SetActive(false);
        moreonez = 0;
        stackscore = 0;
        infoscore = scrgame.infoscore;
        infoscore.Clear();
        posiscore.Clear();
    }

    // Update is called once per frame
    void Update(){
        Debug.Log("moreonez : "+moreonez);
        if(moreonez == 2){
            Debug.Log("Two");
            if(infoscore[0] == infoscore[1]){
                Debug.Log("Same");
                StartCoroutine(waitandhide());
            }else{
                Debug.Log("Not Same");
                StartCoroutine(waitandblind());  
            }
            infoscore.Clear();
            moreonez = 0;
        }
        if(stackscore == 8){
            Debug.Log("Finish");
            setMenu.SetActive(true);
            finalscore.text = scoretext.text;
            Time.timeScale = 0;
        }
    }

    IEnumerator waitandblind(){
        Debug.Log("Blind");
        blindBG.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        foreach (Button btn in scrgame.disablbtn){
            if (btn != null){
                btn.interactable = true;
            }
        }
        foreach (int pos in posiscore){
            scrgame.btntext[pos].text = "";
        }
        posiscore.Clear();
        blindBG.SetActive(false);
    }

    IEnumerator waitandhide(){
        blindBG.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        foreach (int pos in posiscore){
            Debug.Log("Hide : "+pos);
            scrgame.matching[pos].SetActive(false);
        }
        posiscore.Clear();
        blindBG.SetActive(false);
        stackscore++;
    }
}
