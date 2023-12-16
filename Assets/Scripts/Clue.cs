using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clue : InteractableBase
{
    public string clueName, clueDescription;

    public override void OnInteract()
    {
        AddClue();
        gameObject.SetActive(false);
    }

    public override void OnInspect()
    {
        throw new System.NotImplementedException();
    }

    public override void Think()
    {
        throw new System.NotImplementedException();
    }

    private void AddClue()
    {
        ClueMenu.instance.CreateClueEntry(clueName, clueDescription);
    }
}
