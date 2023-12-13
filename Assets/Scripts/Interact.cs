using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public InteractableBase interactableThing;
    public Highlight highlight;

    private void Start()
    {
        interactableThing = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && highlight.interactable != null)
        {
            interactableThing = highlight.interactable;
            interactableThing.OnInteract();
        }
        else
        {
            interactableThing = null;
        }
    }
}
