using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            animator.SetTrigger("ToggleDoor");
        }
    }

    void OnTriggerExit(Collider collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            animator.SetTrigger("ToggleDoor");
        }
    }
}
