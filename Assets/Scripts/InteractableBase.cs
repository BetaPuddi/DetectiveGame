using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InteractableBase : MonoBehaviour
{
    public bool used;
    public string thought;

    public abstract void OnInteract();
    public abstract void OnInspect();
    public abstract void Think();
}
