using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : InteractableBase
{
    public override void OnInteract()
    {
        GetComponent<Animator>().SetTrigger("Open");
        used = true;
    }

    public override void OnInspect()
    {
        if (!used)
        {
            inspectText = "Press E to open door";
            InteractText.instance.SetText(inspectText);
        }
    }

    public override void Think()
    {
        ThoughtText.instance.SetText(thought);
    }
}
