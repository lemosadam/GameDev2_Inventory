//using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactives : MonoBehaviour
{
    [SerializeField] GameObject topFridge;
    [SerializeField] GameObject freezer;
    protected GameObject[] itemsInFridge;
    

    // Start is called before the first frame update
    void Start()
    {
        itemsInFridge = GameObject.FindGameObjectsWithTag("inFridge");
        foreach (GameObject item in itemsInFridge)
        {
            item.SetActive(false);
        }
        topFridge.SetActive(false);
        freezer.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if(this.name == "Top") {
            foreach (GameObject item in itemsInFridge)
            {
                item.SetActive(true);
            }
        
            Debug.Log("clicked");
        }

        if(this.name == "Bottom") {
            freezer.SetActive(true);
            Debug.Log("clicked");
        }
    }
}
