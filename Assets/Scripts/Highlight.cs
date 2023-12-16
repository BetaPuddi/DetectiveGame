using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEditor;

public class Highlight : MonoBehaviour
{
    public LayerMask interactableLayer;
    public float lengthOfRay;

    private Transform rayCastOrigin;
    private Transform previouslyHitObject;

    [CanBeNull] public InteractableBase interactable;

    // Start is called before the first frame update
    void Start()
    {
        rayCastOrigin = gameObject.transform;
        previouslyHitObject = null;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;


        Debug.DrawRay(rayCastOrigin.position, transform.TransformDirection(Vector3.forward) * lengthOfRay, Color.red);


        if (Physics.Raycast(rayCastOrigin.position, transform.TransformDirection(Vector3.forward), out hit, lengthOfRay, interactableLayer))
        {
            Debug.DrawRay(rayCastOrigin.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.green);
            print("Hit: " + hit.transform.name);
            previouslyHitObject = hit.transform;
            interactable = previouslyHitObject.GetComponent<InteractableBase>();
            if (interactable != null)
            {
                interactable.OnInspect();
                interactable.Think();
            }
        }
        else //if (hit.transform.gameObject.layer != interactableLayer)
        {
            //previouslyHitObject.GetComponent<MeshRenderer>().material.color = Color.white;
            previouslyHitObject = null;
            interactable = null;
            InteractText.instance.SetText("");
            ThoughtText.instance.SetText("");
        }
    }
}
