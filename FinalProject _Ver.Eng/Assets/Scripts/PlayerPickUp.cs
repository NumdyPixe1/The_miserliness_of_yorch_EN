using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickUp : MonoBehaviour
{
    //     public bool isPickUp;
    //     //private Item item;
    //     void Start()
    //     {
    //         //item = GameObject.FindGameObjectWithTag("Object").GetComponent<Item>();
    //         //item = add.GetComponent<Item>();
    //         //Item item = gameObject.AddComponent<Item>() as Item;
    //     }


    //     void Update()
    //     {
    //         //Physics.Raycast(this.transform.position, this.transform.forward, out hit, 2);
    //         if (Input.GetKeyDown(KeyCode.E) && isPickUp == true)
    //         {
    //             item = GameObject.FindGameObjectWithTag("Object").GetComponent<Item>();
    //             item.PickUpItem();
    //             //isPickUp = false;
    //         }
    //     }
    //     private void OnTriggerEnter2D(Collider2D other)
    //     {
    //         if (other.CompareTag("Object"))
    //         {
    //             Debug.Log("Ready to pick up.");
    //             isPickUp = true;
    //         }
    //     }
    //     private void OnTriggerExit2D(Collider2D other) //เมื่อออกจาก BoxCollider2D
    //     {
    //         if (other.CompareTag("Object"))
    //         {
    //             Debug.Log("Exited hitbox");
    //             isPickUp = false;
    //         }
    //     }
}
