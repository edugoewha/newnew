using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elephant : MonoBehaviour
{
	private AudioSource Oaudio;
    private AudioSource Xaudio;
    public AudioClip OSound;
    public AudioClip XSound;
    public GameObject Elephantword;
    
    void Start()
    {
        this.Oaudio = this.gameObject.AddComponent<AudioSource>();
        this.Oaudio.clip = this.OSound;
        this.Oaudio.loop = false;

        this.Xaudio = this.gameObject.AddComponent<AudioSource>();
        this.Xaudio.clip = this.XSound;
        this.Xaudio.loop = false;

    }
    
    void OnMouseDown(){
    	if (grab2.inHand6)
        {
            grab2.newText[1].enabled = true;
            grab2.inHand6 = false;
            Destroy(Elephantword);
            grab2.newText[1].text = "O";
            this.Oaudio.Play();
            Invoke("DisableText", 1f);
           
            grab2.count--;
        }
        if (grab2.inHand4 || grab2.inHand2 || grab2.inHand3 || grab2.inHand1 || grab2.inHand5)
        {
            grab2.newText[1].enabled = true;
            grab2.newText[1].text = "X";
            this.Xaudio.Play();
            Invoke("DisableText", 1f);
         
        }
    }
    void DisableText()
    {
        grab2.newText[1].enabled = false;
    }

}

