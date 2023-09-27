//using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour, Observer
{
    protected List<GameObject> inventoryItems = new List<GameObject>();

    public void OnNotify(object obj, NotificationType notificationType)
    {
        if (notificationType == NotificationType.FruitsCollected)
        {
            GameObject fruit = GameObject.Find("Fruit");
            inventoryItems.Add(fruit);
            foreach(var item in inventoryItems)
            {
                Debug.Log(item.ToString());
            }
        }

        if (notificationType == NotificationType.IceCollected)
        {
            GameObject ice = GameObject.Find("Ice");
            inventoryItems.Add(ice);
            foreach(var item in inventoryItems)
            {
                Debug.Log(item.ToString());
            }
        }
    }

    // Start is called before the first frame update
    void Awake()
    {
        foreach (Observable subject in FindObjectsOfType<Observable>())
        {
            subject.AddObserver(this);
        }
    }
    
    void Start()
    {
        // add Achievement System object as observer to all observable objects
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
