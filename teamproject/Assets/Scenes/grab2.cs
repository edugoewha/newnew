using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class grab2 : MonoBehaviour
{
	private AudioSource audio;
    public AudioClip jumpSound;

	public GameObject bananaword;
    public GameObject tigerword;
    public GameObject spoonword;
    public GameObject carword;
    public GameObject fishword;
    public GameObject elephantword;
    public GameObject elephantobject;
    public GameObject Board;
    public GameObject Plane1;
    public GameObject Plane2;
    public GameObject Plane3;
    public GameObject Plane4;
    public GameObject Plane5;
    public GameObject Plane6;
    public GameObject myHand;
    Vector3 bananawordPos;
    Vector3 tigerwordPos;
    Vector3 spoonwordPos;
    Vector3 carwordPos;
    Vector3 fishwordPos;
    Vector3 elephantwordPos;
    Camera cam;
    public float handPower;
    public static bool inHand1;
    public static bool inHand2;
    public static bool inHand3;
    public static bool inHand4;
    public static bool inHand5;
    public static bool inHand6;

    Ray ray;
    RaycastHit hit;
    public static Text[] newText;
    public static int count;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponentInChildren<Camera>();
        newText = GetComponentsInChildren<Text>();
        
        count = 6;
        elephantobject.SetActive(false);

        this.audio = this.gameObject.AddComponent<AudioSource>();
        this.audio.clip = this.jumpSound;
        this.audio.loop = false;
    }

    // Update is called once per frame
    void Update()
    {
		if (count == 0)
        {
            Invoke("DisableText", 1f);
            this.audio.Play();
            newText[0].text = "배고픈 코끼리에게 과일을 가져다 주세요";
            Destroy(Board);
            Destroy(Plane1);
            Destroy(Plane2);
            Destroy(Plane3);
            Destroy(Plane4);
            Destroy(Plane5);
            Destroy(Plane6);
            elephantobject.SetActive(true);
            count--;
            //Board.SetActive(false);
            //Plane1.SetActive(false);
            //Plane2.SetActive(false);
            //Plane3.SetActive(false);
            //Plane4.SetActive(false);
            //Plane5.SetActive(false);
            //Plane6.SetActive(false);
        }
        else if(count > 0)
        {
            newText[0].text = "물건을 집어서 맞는 단어를 누르세요";
        }
        if (Input.GetButtonDown("Fire1"))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit)){
            
                if(hit.collider.tag == "bananaword"){
                    bananaword.transform.SetParent(myHand.transform);
                    bananaword.transform.localPosition = new Vector3(0.8f, 0.8f, 0);
                    inHand1 = true;
                }
                
                if(hit.collider.tag == "tigerword"){
                    tigerword.transform.SetParent(myHand.transform);
                    tigerword.transform.localPosition = new Vector3(0.8f, 0.8f, 0);
                    inHand2 = true;
                }
                
                if(hit.collider.tag == "spoonword"){
                    spoonword.transform.SetParent(myHand.transform);
                    spoonword.transform.localPosition = new Vector3(0.8f, 0.8f, 0);
                    inHand3 = true;
                }
                
                if(hit.collider.tag == "carword"){
                    carword.transform.SetParent(myHand.transform);
                    carword.transform.localPosition = new Vector3(0.8f, 0.8f, 0);
                    inHand4 = true;
                }
                
                if(hit.collider.tag == "fishword"){
                    fishword.transform.SetParent(myHand.transform);
                    fishword.transform.localPosition = new Vector3(0.8f, 0.8f, 0);
                    inHand5 = true;
                }
                
                if(hit.collider.tag == "elephantword"){
                    elephantword.transform.SetParent(myHand.transform);
                    elephantword.transform.localPosition = new Vector3(0.8f, 0.8f, 0);
                    inHand6 = true;
                }
            }
            
        }

    }
    void DisableText()
    {
        newText[1].enabled = false;
    }
}


