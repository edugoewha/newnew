using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chair : MonoBehaviour
{
    private AudioSource Oaudio;
    private AudioSource Xaudio;
    public AudioClip OSound;
    public AudioClip XSound;
    public GameObject Chairword;

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
        if (grab3.inHand1)
        {
            grab3.newText[1].enabled = true;
            grab3.inHand1 = false;
            Destroy(Chairword);
            grab3.newText[1].text = "O";
            this.Oaudio.Play();
            Invoke("DisableText", 1f);
           
            grab3.count--;
        }
        if (grab3.inHand6 || grab3.inHand2 || grab3.inHand3 || grab3.inHand4 || grab3.inHand5)
        {
            grab3.newText[1].enabled = true;
            grab3.newText[1].text = "X";
            this.Xaudio.Play();
            Invoke("DisableText", 1f);
         
        }
    }
    void DisableText()
    {
        grab3.newText[1].enabled = false;
    }
}
