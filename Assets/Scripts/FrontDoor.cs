using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontDoor : InteractableBase
{
    public override void OnInteract()
    {
        EndScreen.instance.ShowEndScreen();
    }

    public override void OnInspect()
    {
        if (!used)
        {
            inspectText = "Press E to leave";
            InteractText.instance.SetText(inspectText);
        }
    }

    public override void Think()
    {
        ThoughtText.instance.SetText(thought);
    }
}
