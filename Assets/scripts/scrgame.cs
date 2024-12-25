using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class scrgame : MonoBehaviour
{
    public GameObject[] matching = new GameObject[17];
    public int[] positions = new int[17];
    public Button[] disablbtn;
    public int clickselect;
    public int randomscore = 0;
    public int mcount;
    public int randdd;
    public static List<int> infoscore = new List<int>();
    public List<int> randnmber = new List<int>();
    public List<int> samesame = new List<int>();


    public int switchs,switchrand = 0;
    public static bool[] checkz;
    public TextMeshProUGUI[] btntext;

    void Start(){
        Debug.Log("Start");
        mcount = 0;
        btntext = new TextMeshProUGUI[matching.Length];
        checkz = new bool[matching.Length];
        disablbtn = new Button[matching.Length];
        for(int i = 0; i < matching.Length; i++){
            checkz[i] = false;
        }
    }
    public void randomss(int clickbtn){
        clickselect = clickbtn;
        disablbtn[clickselect] = matching[clickselect].GetComponent<Button>();
        btntext[clickselect] = matching[clickselect].GetComponentInChildren<TextMeshProUGUI>();  
        
        if(checkz[clickselect] == true){
            checksame.moreonez++;
            checksame.posiscore.Add(clickselect);

            infoscore.Add(positions[clickselect]);
            disablbtn[clickselect].interactable = false;
            btntext[clickselect].text = positions[clickselect].ToString();
            Debug.Log(btntext[clickselect].text);
        }else{
            checkz[clickselect] = true;
            checksame.moreonez++;

            randdd = randnmber[UnityEngine.Random.Range(0,randnmber.Count)];
            foreach (int item in randnmber){
                if (item == randdd){
                    Debug.Log("Same : "+randdd);
                    if (!samesame.Contains(randdd)){
                        samesame.Add(randdd);
                        Debug.Log("Add : " + randdd);
                    }else{
                        mcount = 2;
                    }
                }
            }

            if(mcount == 2){
                randnmber.Remove(randdd);
                mcount = 0;
            }

            infoscore.Add(randdd);
            positions[clickselect] = randdd;
            checksame.posiscore.Add(clickselect);
            disablbtn[clickselect].interactable = false;
            btntext[clickselect].text = randdd.ToString();
            Debug.Log(btntext[clickselect].text);
        }
        
    }
}
