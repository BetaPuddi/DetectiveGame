using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupboardDoor : InteractableBase
{
    [SerializeField] private bool right;
    [SerializeField] private bool side;

    public override void OnInteract()
    {
        if (right && !side)
        {
            GetComponent<Animator>().SetTrigger("UseR");
        }
        else if (!right && !side)
        {
            GetComponent<Animator>().SetTrigger("UseL");
        }
        else if (right && side)
        {
            GetComponent<Animator>().SetTrigger("UseR2");
        }
        else if (!right && side)
        {
            GetComponent<Animator>().SetTrigger("UseL2");
        }
    }
}
