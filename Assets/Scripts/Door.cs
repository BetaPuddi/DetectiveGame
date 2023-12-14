using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : InteractableBase
{
    public override void OnInteract()
    {
        GetComponent<Animator>().SetTrigger("Open");
    }
}
