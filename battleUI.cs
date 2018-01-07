using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class battleUI : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        List<string> btnsName = new List<string>();
        //下面输入的是UI里对应的按钮名字
        btnsName.Add("Atk");
        btnsName.Add("Item");
        btnsName.Add("run");

        foreach (string btnName in btnsName)
        {
            GameObject btnObj = GameObject.Find(btnName);
            Button btn = btnObj.GetComponent<Button>();
            btn.onClick.AddListener(delegate ()
            {
                this.OnClick(btnObj);
            });
        }

    }

    public void OnClick(GameObject sender)
    {
        switch (sender.name)
        {
            case "Atk":
                print(1);
                break;
            case "Item":
                print(2);
                break;
            case "run":
                print(3);
                break;
            default:
                Debug.Log("are you OK?");
                break;
        }
    }
}
