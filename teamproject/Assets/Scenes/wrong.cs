using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wrong : MonoBehaviour
{
    //public Text status;
    public int count;
    private AudioSource Xaudio;
    public AudioClip XSound;

    // Start is called before the first frame update
    void Start()
    {
		this.Xaudio = this.gameObject.AddComponent<AudioSource>();
        this.Xaudio.clip = this.XSound;
        this.Xaudio.loop = false;
           //status = gameObject.GetComponentInChildren<Text>();
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("rock"))
        {
            other.gameObject.SetActive (false);
            this.Xaudio.Play();
            grab.newText[0].text="잘했습니다! 다음 스테이지로 넘어가세요";
            Invoke("removeMyself", 1f);
            
   
        }
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    
    void removeMyself(){
		gameObject.SetActive(false);
	}
}
