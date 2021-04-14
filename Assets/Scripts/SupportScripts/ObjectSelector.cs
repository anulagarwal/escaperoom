using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSelector : MonoBehaviour
{
    #region MonoBehaviour Functions
    private void OnMouseDown()
    {
        StartCoroutine(ObjectShaker.Instance.Shake(this.transform));
    }
    #endregion
}
