using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abduction : MonoBehaviour
{

    public Animator myChicken = null;
    public Animator myDeer = null;
    public string Chicken = "Chicken";
    public string Ab = "Abduction";
    public AudioSource sfx = null;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A)){
            StartCoroutine(Anim());
        }
    }
    
    IEnumerator Anim()
    {
        myChicken.Play(Chicken);
        yield return new WaitForSeconds(2);
        myDeer.Play(Ab);
        sfx.Play();
        
    }
}


