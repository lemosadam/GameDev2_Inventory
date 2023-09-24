using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsObserved : Observable
{
    [SerializeField] Renderer ItemColor;
     protected NotificationType notif;

    // Start is called before the first frame update
    void Start()
    {
        notif = NotificationType.EmptyCollected;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver() {
        ItemColor.material.color = Color.yellow;
        //print("mouse over");
    }

    private void OnMouseExit() {
        ItemColor.material.color = Color.white;
    }

    private void OnMouseDown() {
        ItemColor.enabled = false;
        
        Notify(this, notif);
    }
}
