using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curtains : InteractableBase
{
    [SerializeField] private bool right;

    public override void OnInteract()
    {
        if (right)
        {
            GetComponent<Animator>().SetTrigger("OpenR");
        }
        else
        {
            GetComponent<Animator>().SetTrigger("OpenL");
        }
    }
}


