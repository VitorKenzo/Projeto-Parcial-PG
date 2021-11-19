using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulo_Macaco : MonoBehaviour
{

    public Animator myMonkey = null;
    public string monkeyJump = "Monkey_Jump";
    public AudioSource sfx = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M)){
            myMonkey.Play(monkeyJump);
            sfx.Play();
        }
    }
}
