using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTrigger : MonoBehaviour
{
    DialogSystem dialogSystem;
    //public GameObject Object;
    [SerializeField] private int index;
    public bool Clicked;
    void Start()
    {
        if (Clicked)
        {
            OnClick_Object();
        }

    }

    void Update()
    {


    }

    public void OnClick_Object()
    {
        Clicked = false;
        print("Clicked");
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Clicked = true;
    }












}
