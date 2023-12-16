using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClueEntry : MonoBehaviour
{
    public TextMeshProUGUI nameTextTMP, descriptionTextTMP;
    public string nameText, descriptionText;

    public void SetClueText(string clueName, string description)
    {
        nameTextTMP.text = clueName;
        //descriptionTextTMP.text = description;
    }

    public void OnClick()
    {
        ClueMenu.instance.SetDescriptionText(descriptionText);
    }
}
