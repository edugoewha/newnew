using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class pause : MonoBehaviour
{
	public GameObject PausePanel;

    public void PauseControl(){
		if(Time.timeScale == 1){
			PausePanel.SetActive(true);
			Time.timeScale = 0;
		}
		else{
			Time.timeScale = 1;
			PausePanel.SetActive(false);
		}
	}
    
}
