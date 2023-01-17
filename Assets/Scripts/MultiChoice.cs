using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MultiChoice : MonoBehaviour 
{ 

// public GameObject TextBox;
public GameObject Choice01;
public GameObject Choice02;
public int ChoiceMade;

    public void ChoiceOption1 () {
    SceneManager.LoadScene(19);
    ChoiceMade = 1;
    }

    public void ChoiceOption2 () {
    SceneManager.LoadScene(20);
    ChoiceMade = 2;
    }

        void Update(){ 
        if (ChoiceMade > 1) {
        Choice01.SetActive (false);
        Choice02.SetActive (false);
        }
    } 
}
