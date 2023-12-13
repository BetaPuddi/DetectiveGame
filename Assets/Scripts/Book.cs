using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : InteractableBase
{
    public override void OnInteract()
    {
        Debug.Log("Book");
    }
}
