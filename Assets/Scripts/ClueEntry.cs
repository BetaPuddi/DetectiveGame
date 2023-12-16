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
        descriptionText = description;
    }

    public void OnClick()
    {
        descriptionTextTMP.text = descriptionText;
        ClueMenu.instance.SetDescriptionText(descriptionTextTMP.text);
    }
}
