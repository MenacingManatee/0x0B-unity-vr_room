using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNear : MonoBehaviour
{
    public Animator anim;
    private bool played = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleDoor() {
        anim.SetBool("character_nearby", !anim.GetBool("character_nearby"));
        if (!played)
        {
            anim.Play("Base Layer.glass_door_open");
            played = true;
        }
    }
}
