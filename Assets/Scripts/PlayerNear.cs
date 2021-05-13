using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNear : MonoBehaviour
{
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter() {
        anim.SetBool("character_nearby", true);
        anim.Play("Base Layer.glass_door_open");
    }
    void OnCollisionExit() {
        anim.SetBool("character_nearby", false);
    }
}
