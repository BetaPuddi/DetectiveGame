using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClueMenu : MonoBehaviour
{
    [SerializeField] private GameObject clueMenu, playerRef, clueList;
    [SerializeField] private TextMeshProUGUI clueDescriptionText;

    public static ClueMenu instance;

    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            clueMenu.SetActive(!clueMenu.activeSelf);
            Cursor.visible = clueMenu.activeSelf;
            Cursor.lockState = clueMenu.activeSelf ? CursorLockMode.None : CursorLockMode.Locked;
            GetComponent<PlayerMovement>().menuOpen = clueMenu.activeSelf;
        }
    }

    public void CreateClueEntry(string clueName, string clueText)
    {
        GameObject newClue = Instantiate(Resources.Load("Prefabs/ClueEntry") as GameObject, clueList.transform);
        newClue.GetComponent<ClueEntry>().SetClueText(clueName, clueText);
    }

    public void SetDescriptionText(string text)
    {
        clueDescriptionText.text = text;
    }
}
