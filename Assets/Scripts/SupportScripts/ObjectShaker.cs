using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectShaker : MonoBehaviour
{
    #region Properties
    public static ObjectShaker Instance = null;
    [Header("Attributes")]
    [SerializeField] private float duration = 0f;
    [SerializeField] private float magnitude = 0f;
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

    #region Coroutines
    public IEnumerator Shake(Transform objectTransform)
    {
        Vector3 orignalPos = objectTransform.localPosition;

        float elapsed = 0f;

        while (elapsed < duration)
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float z = Random.Range(-1f, 1f) * magnitude;

            objectTransform.localPosition = new Vector3(orignalPos.x +x, orignalPos.y, orignalPos.z +z);

            elapsed += Time.deltaTime;
            yield return null;
        }

        objectTransform.localPosition = orignalPos;
    }
    #endregion
}
