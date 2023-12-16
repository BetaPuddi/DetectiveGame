using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EndScreen : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI resultsText;
    [SerializeField] private GameObject endScreenPanel, player;

    public static EndScreen instance;

    private void Awake()
    {
        instance = this;
    }

    public void ShowEndScreen()
    {
        endScreenPanel.gameObject.SetActive(true);
        resultsText.text = "You found " + ProgressTracker.instance.cluesFound + " clues!";
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        player.GetComponent<PlayerMovement>().menuOpen = true;
    }

    public void BackToMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }
}
