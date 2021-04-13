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
    // Start is called before the first frame update
    void Start()
    {
        currentIndex = 0;
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
        if(currentIndex>= numberDisplays.Count)
        {
            if(currentPassword != correctPassword)
            {
              Invoke( "ResetPassword", 0.4f);
            }
            currentIndex = 0;
        }
    }

    public void ResetPassword()
    {
        foreach (Text t in numberDisplays)
        {
            t.text = "";
        }
    }
    public void Close()
    {
        ResetPassword();
        currentIndex = 0;
        PinEnter.SetActive(false);
    }
}
