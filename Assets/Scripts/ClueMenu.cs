using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;

public class ClueMenu : MonoBehaviour
{
    [SerializeField] private GameObject clueMenu, clueList, clueEntryPrefab, menuChecker;
    [SerializeField] private TextMeshProUGUI clueDescriptionText;
    private RectMask2D rectMask2D;

    public static ClueMenu instance;

    void Awake()
    {
        instance = this;
        rectMask2D = clueMenu.GetComponent<RectMask2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            menuChecker.SetActive(!menuChecker.activeSelf);
            Cursor.visible = menuChecker.activeSelf;
            Cursor.lockState = menuChecker.activeSelf ? CursorLockMode.None : CursorLockMode.Locked;
            rectMask2D.enabled = !menuChecker.activeSelf;
            GetComponent<PlayerMovement>().menuOpen = menuChecker.activeSelf;
        }
    }

    public void CreateClueEntry(string clueName, string clueText)
    {
        GameObject newClue = Instantiate(clueEntryPrefab, clueList.transform);
        newClue.GetComponent<ClueEntry>().SetClueText(clueName, clueText);
    }

    public void SetDescriptionText(string text)
    {
        clueDescriptionText.text = text;
    }
}
