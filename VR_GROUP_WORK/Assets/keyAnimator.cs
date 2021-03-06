using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyAnimator : MonoBehaviour
{
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("playAnimation", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            anim.SetBool("playAnimation", true);
           // anim.Play("boxAnimation");
        }

        if (Input.GetKeyDown("2"))
        {
            anim.SetBool("playAnimation", false);
            // anim.Play("boxAnimation");
        }

    }
}
