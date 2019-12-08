using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class setting : MonoBehaviour
{
	public GameObject SettingPanel;

    public void SettingControl(){
		if(Time.timeScale == 1){
			SettingPanel.SetActive(true);
			Time.timeScale = 0;
		}
		else{
			Time.timeScale = 1;
			SettingPanel.SetActive(false);
		}
	}
    
}
