using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clue : InteractableBase
{
    public string clueName, clueDescription;

    public override void OnInteract()
    {
        AddClue();
        used = true;
        //gameObject.SetActive(false);
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

    private void AddClue()
    {
        if (!used)
        {
            ClueMenu.instance.CreateClueEntry(clueName, clueDescription);
        }
    }
}
