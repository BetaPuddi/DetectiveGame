using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tap : InteractableBase
{
    [SerializeField] private ParticleSystem water;

    public override void OnInteract()
    {
        if (!used)
        {
            water.Play();
            used = true;
            StartCoroutine(Wait());
        }
    }

    public override void OnInspect()
    {
        switch (used)
        {
            case false:
                inspectText = "Press E to turn on tap";
                InteractText.instance.SetText(inspectText);
                break;
            case true:
                InteractText.instance.SetText("");
                break;
        }

    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3);
        water.Stop();
        used = false;
    }

    public override void Think()
    {
        if (used)
        {
            ThoughtText.instance.SetText(thought);
        }
    }
}
