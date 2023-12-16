using UnityEngine;
using TMPro;

public class InteractText : MonoBehaviour
{
    public static InteractText instance;

    void Awake()
    {
        instance = this;
    }

    public void SetText(string text)
    {
        GetComponent<TextMeshProUGUI>().text = text;
    }
}
