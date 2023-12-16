using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : InteractableBase
{
    public override void OnInteract()
    {
        Debug.Log("Book");
        used = true;
    }

    public override void OnInspect()
    {
        if (!used)
        {
            inspectText = "Press E to read book";
            InteractText.instance.SetText(inspectText);
        }
    }

    public override void Think()
    {
        ThoughtText.instance.SetText(thought);
    }
}
