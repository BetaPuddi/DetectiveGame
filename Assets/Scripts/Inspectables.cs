using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inspectables : InteractableBase
{
    public override void OnInteract()
    {
    }

    public override void OnInspect()
    {
        if (!used)
        {
            InteractText.instance.SetText(inspectText);
        }
    }

    public override void Think()
    {
        if (!used)
        {
            ThoughtText.instance.SetText(thought);
        }
    }
}
