using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PinController : MonoBehaviour
{

    public int currentIndex;
    public List<Text> numberDisplays;
    public GameObject PinEnter;
    public string correctPassword;
    public string currentPassword;
    public GameObject wrongText;
    public GameObject correctText;
    public Transform door;
    public bool unlockDoor;

    // Start is called before the first frame update
    void Start()
    {
        currentIndex = 0;
        print(Quaternion.Euler(0, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateText(string val)
    {
        numberDisplays[currentIndex].text = val;
        currentPassword += val;
        currentIndex++;
        wrongText.SetActive(false);
        if(currentIndex>= numberDisplays.Count)
        {
            if(currentPassword != correctPassword)
            {
              Invoke( "ResetPassword", 0.4f);
            }
            else
            {
                correctText.SetActive(true);
                Invoke("UnlockDoor",1f);
            }
            currentIndex = 0;
        }
    }
    public void UnlockDoor()
    {
        unlockDoor = true;
        door.GetComponent<Door>().Rotate();
        PinEnter.SetActive(false);

    }

    public void ResetPassword()
    {
        foreach (Text t in numberDisplays)
        {
            t.text = "";
        }
        currentPassword = "";
        wrongText.SetActive(true);
    }
    public void Close()
    {
        ResetPassword();
        currentIndex = 0;
        PinEnter.SetActive(false);
    }
}
