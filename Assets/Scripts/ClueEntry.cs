using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClueEntry : MonoBehaviour
{
    public TextMeshProUGUI nameText, descriptionText;

    public void SetClueText(string clueName, string description)
    {
        nameText.text = clueName;
        descriptionText.text = description;
    }

    public void OnClick()
    {
        ClueMenu.instance.SetDescriptionText(descriptionText.text);
    }
}
