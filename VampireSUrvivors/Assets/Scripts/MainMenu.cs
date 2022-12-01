using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject panel;

    private void Update()
    {
       if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (panel.activeInHierarchy == false)
            {
                OpenMenu();

            }
            else
            {
                CloseMenu();
            }
        }
    }

    public void CloseMenu()
    {
        panel.SetActive(false);
    }

    public void OpenMenu()
    {
        panel.SetActive(true);
    }
}