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
            used = true;
        }
        else
        {
            GetComponent<Animator>().SetTrigger("OpenL");
            used = true;
        }
    }

    public override void OnInspect()
    {
        if (!used)
        {
            InteractText.instance.SetText("Press E to open curtains");
        }
    }

    public override void Think()
    {
        ThoughtText.instance.SetText(thought);
    }
}


