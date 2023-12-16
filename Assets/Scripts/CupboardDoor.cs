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
            used = true;
        }
        else if (!right && !side)
        {
            GetComponent<Animator>().SetTrigger("UseL");
            used = true;
        }
        else if (right && side)
        {
            GetComponent<Animator>().SetTrigger("UseR2");
            used = true;
        }
        else if (!right && side)
        {
            GetComponent<Animator>().SetTrigger("UseL2");
            used = true;
        }
    }

    public override void OnInspect()
    {
        if (!used)
        {
            InteractText.instance.SetText("Press E to open cupboard door");
        }
    }

    public override void Think()
    {
        ThoughtText.instance.SetText(thought);
    }
}
