using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundAnimController : MonoBehaviour
{
    [Range(0, 1)]
    public float animPercent;

    public Animator bgAnim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        bgAnim.Play("MainAnimation", 0, animPercent);
    }
}
