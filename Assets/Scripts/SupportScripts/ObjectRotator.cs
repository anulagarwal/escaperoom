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
    public bool isObjectSelected;
    public bool isDoorSelected;
    Ray ray;
    RaycastHit hit;
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
           

            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.tag == "Pin")
                {
                    isObjectSelected = true;
                }
                else if(hit.transform.tag == "Door")
                {
                    isDoorSelected = true;
                }
                else
                {
                  //  LevelUIManager.Instance.EnableGamePhase_2(false);
                  //  LevelUIManager.Instance.HidePasswordScreen();
                  //  LevelUIManager.Instance.HidePin();


                    isObjectSelected = false;
                    isDoorSelected = false;
                        
                }
            }

        }

        if (Input.GetMouseButton(0))
        {
            if(!isObjectSelected && Mathf.Abs(Input.mousePosition.x - oldX) >1)
            transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y + ((Input.mousePosition.x - oldX)/4), transform.rotation.z);
            
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (isObjectSelected)
            {
                LevelUIManager.Instance.ShowPin();
                isObjectSelected = false;
            }
            if (isDoorSelected)
            {
                LevelUIManager.Instance.ShowPasswordScreen();
                isDoorSelected = false;
            }
        }
        
    }
    #endregion
}
