using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class removeFire : MonoBehaviour
{
    //public Text status;
    public int count;
    private AudioSource Daudio;
    public AudioClip DSound;

    // Start is called before the first frame update
    void Start()
    {
		this.Daudio = this.gameObject.AddComponent<AudioSource>();
        this.Daudio.clip = this.DSound;
        this.Daudio.loop = false;
           //status = gameObject.GetComponentInChildren<Text>();
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("fire"))
        {
            other.gameObject.SetActive (false);
            this.Daudio.Play();
            grab.newText[0].text="잘했습니다! 다음 스테이지로 넘어가세요";
            Invoke("removeMyself", 1f);
            
   
        }
        
        //if (other.gameObject.CompareTag("orange"))
        //{
            //status.text = "Choose another one";
        //}
    }

    // Update is called once per frame
    void Update()
    {
        //status.text=" ";
    }
    
    void removeMyself(){
		gameObject.SetActive(false);
	}
}
