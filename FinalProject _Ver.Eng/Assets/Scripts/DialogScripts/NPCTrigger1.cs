using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCTrigger1 : MonoBehaviour
{
    public GameObject chaImage;
    public DialogSystem dialogSystem;
    public bool isTalk;

    // Start is called before the first frame update
    void Start()
    {
        //EventCharacter eventCharacter = FindObjectOfType<EventCharacter>(); 
    }
    public void OnMouseDown()
    {
        if (isTalk)
        {
            //chaImage.SetActive(true);
            dialogSystem.StartDialog();
            Debug.Log("istalk");
            isTalk = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == ("Player"))
        {
            isTalk = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == ("Player"))
        {
            isTalk = false;
        }
    }
}
