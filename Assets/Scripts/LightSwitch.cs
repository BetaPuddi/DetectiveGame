using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : InteractableBase
{
    [SerializeField] private GameObject switchOn;
    [SerializeField] private GameObject switchOff;
    [SerializeField] private GameObject lightToToggle;
    [SerializeField] private bool isOn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void OnInteract()
    {
        switch (isOn)
        {
            case true:
                switchOn.SetActive(false);
                switchOff.SetActive(true);
                lightToToggle.SetActive(false);
                isOn = false;
                break;
            case false:
                switchOn.SetActive(true);
                switchOff.SetActive(false);
                lightToToggle.SetActive(true);
                isOn = true;
                break;
        }
    }
}
