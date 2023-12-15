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
            StartCoroutine(Wait());
        }
    }

    public override void OnInspect()
    {
        InteractText.instance.SetText("Press E to turn on tap");
        used = true;
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3);
        water.Stop();
        used = false;
    }
}
