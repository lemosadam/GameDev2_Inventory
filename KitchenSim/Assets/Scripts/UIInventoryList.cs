using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIInventoryList : InventorySystem, Observer
{
    public TMP_Text invUI;
    public GameObject inventory;
    // Start is called before the first frame update

    

    void Start()
    {
       
    }

    public void OnNotify(object obj, NotificationType notificationType)
    {
        if (notificationType == NotificationType.FruitsCollected)
        {
                
            //invUI.text += ToString("Fruit");
               
        }

        if (notificationType == NotificationType.IceCollected)
        {
            foreach (var item in inventoryItems)
            {
                invUI.text += item.ToString();
                Debug.Log(item);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    void Awake()
    {
        foreach (Observable subject in FindObjectsOfType<Observable>())
        {
            subject.AddObserver(this);
        }
    }
}
