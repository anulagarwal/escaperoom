using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotator : MonoBehaviour
{
    #region Poperties
    [Header("Attributes")]
    [SerializeField] private float rotSpeed = 0f;
    private float oldX;

    private float width = 0f;
    #endregion

    #region MonoBehaviour Functions
    private void Start()
    {
        width = (float)Screen.width / 2f;
    }

    private void Update()
    {
       /* if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (Input.touchCount == 1)
            {
                touch = Input.GetTouch(0);

                if (touch.phase == TouchPhase.Moved)
                {
                    if (touch.position.x > width)
                    {
                        transform.Rotate(Vector3.up * Time.deltaTime * rotSpeed);
                    }
                    else
                    {
                        transform.Rotate(-Vector3.up * Time.deltaTime * rotSpeed);
                    }
                }
            }
        }
       */
        if (Input.GetMouseButtonDown(0))
        {
            oldX = Input.mousePosition.x;
            print(oldX);
        }

        if (Input.GetMouseButton(0))
        {
            //print(Input.mousePosition.x - oldX);
            transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y + ((Input.mousePosition.x - oldX)/4), transform.rotation.z);
            //transform.Rotate(Vector3.up * Time.deltaTime * (Input.mousePosition.x - oldX) *2);
            //oldX = Input.mousePosition.x;
        }
        
    }
    #endregion
}
