using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouWinManager : MonoBehaviour
{
    [SerializeField] GameObject winMessagePanel;
    PauseManager pauseManager;

    private void Start()
    {
        pauseManager = GetComponent<PauseManager>();
    }

    public void Win()
    {
        winMessagePanel.SetActive(true);
        pauseManager.PauseGame(); 
    }

}
