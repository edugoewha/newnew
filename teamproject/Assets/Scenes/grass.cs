using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grass : MonoBehaviour
{
    private AudioSource Oaudio;
    private AudioSource Xaudio;
    public AudioClip OSound;
    public AudioClip XSound;
    public GameObject Grassword;

    void Start()
    {
        this.Oaudio = this.gameObject.AddComponent<AudioSource>();
        this.Oaudio.clip = this.OSound;
        this.Oaudio.loop = false;

        this.Xaudio = this.gameObject.AddComponent<AudioSource>();
        this.Xaudio.clip = this.XSound;
        this.Xaudio.loop = false;

    }

    void OnMouseDown()
    {
        if (grab.inHand1)
        {
            grab.newText[1].enabled = true;
            grab.inHand1 = false;
            Destroy(Grassword);
            grab.newText[1].text = "O";
            this.Oaudio.Play();
            Invoke("DisableText", 1f);
           
            grab.count--;
        }
        if (grab.inHand6 || grab.inHand2 || grab.inHand3 || grab.inHand4 || grab.inHand5)
        {
            grab.newText[1].enabled = true;
            grab.newText[1].text = "X";
            this.Xaudio.Play();
            Invoke("DisableText", 1f);
         
        }
    }
    void DisableText()
    {
        grab.newText[1].enabled = false;
    }
}
