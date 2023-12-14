using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tap : InteractableBase
{
    [SerializeField] private ParticleSystem water;

    public override void OnInteract()
    {
        water.Play();
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3);
        water.Stop();
    }
}
