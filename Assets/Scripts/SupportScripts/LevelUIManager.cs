using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUIManager : MonoBehaviour
{
    #region Properties
    public static LevelUIManager Instance = null;

    [Header("Gameplay UI Panel Setup")]
    [SerializeField] private GameObject gameplayUIPanelPhase_2 = null;
    #endregion

    #region MonoBehaviour Functions
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        Instance = this;
    }
    #endregion

    #region Public Core Functions
    public void EnableGamePhase_2(bool value)
    {
        gameplayUIPanelPhase_2.SetActive(value);
    }
    #endregion
}
