using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClueMenu : MonoBehaviour
{
    [SerializeField] private GameObject clueMenu, playerRef;


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
}
