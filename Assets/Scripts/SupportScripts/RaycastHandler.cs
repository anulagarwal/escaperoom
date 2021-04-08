using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastHandler : MonoBehaviour
{
    #region Properties
    Ray ray;
    RaycastHit hit;
    #endregion

    #region MonoBehaviour Functions
    private void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.tag == "Object")
            {
                LevelUIManager.Instance.EnableGamePhase_2(true);
            }
            else
            {
                LevelUIManager.Instance.EnableGamePhase_2(false);
            }
        }
    }
    #endregion
}
