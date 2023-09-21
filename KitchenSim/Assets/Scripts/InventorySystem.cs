using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour, Observer
{
    public void OnNotify(object obj, NotificationType notificationType)
    {
        if (notificationType == NotificationType.FruitsCollected)
        {
            Debug.Log("Fruits Obtained!");
        }

        if (notificationType == NotificationType.IceCollected)
        {
            Debug.Log("Ice Obtained!");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // add Achievement System object as observer to all observable objects
        foreach (Observable subject in FindObjectsOfType<Observable>())
        {
            subject.AddObserver(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
