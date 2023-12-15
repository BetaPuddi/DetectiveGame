using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : InteractableBase
{
    [SerializeField] private GameObject switchOn;
    [SerializeField] private GameObject switchOff;
    [SerializeField] private GameObject bulbOn;
    [SerializeField] private GameObject bulbOff;
    [SerializeField] private bool isOn;
    [SerializeField] private bool isBroken;

    public override void OnInteract()
    {
        if (!isBroken)
        {
            switch (isOn)
            {
                case true:
                    switchOn.SetActive(false);
                    switchOff.SetActive(true);
                    bulbOff.SetActive(true);
                    bulbOn.SetActive(false);
                    isOn = false;
                    break;
                case false:
                    switchOn.SetActive(true);
                    switchOff.SetActive(false);
                    bulbOff.SetActive(false);
                    bulbOn.SetActive(true);
                    isOn = true;
                    break;
            }
        }
        else
        {
            switch (isOn)
            {
                case true:
                    switchOn.SetActive(false);
                    switchOff.SetActive(true);
                    isOn = false;
                    break;
                case false:
                    switchOn.SetActive(true);
                    switchOff.SetActive(false);
                    isOn = true;
                    break;
            }
        }
    }

    public override void OnInspect()
    {
        if (isOn)
        {
            InteractText.instance.SetText("Press E to turn light switch off");
        }
        else
        {
            InteractText.instance.SetText("Press E to turn light switch on");
        }
    }
}
