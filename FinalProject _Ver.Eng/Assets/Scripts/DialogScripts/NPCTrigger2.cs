using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCTrigger2 : MonoBehaviour
{
    //public NPCTrigger2[] npcTrigger2s;
    public BoxCollider2D[] boxCollider2Ds;
    public Player_Movement player_Movement;
    public ReadyToJudge readyToJudge;
    public GameObject chaImage;
    public DialogSystem dialogSystem;
    public bool isTalk;
    public bool isStop;


    // Start is called before the first frame update
    void Start()
    {
        //EventCharacter eventCharacter = FindObjectOfType<EventCharacter>(); 
    }
    public void OnMouseDown()
    {
        if (isTalk && !isStop)
        {
            chaImage.SetActive(true);
            dialogSystem.StartDialog();
            Debug.Log("istalk");
            isTalk = false;
            player_Movement.speed = 0;
            boxCollider2Ds[0].enabled = false;
            boxCollider2Ds[1].enabled = false;
            boxCollider2Ds[2].enabled = false;
            boxCollider2Ds[3].enabled = false;
            // player_Movement.enabled = false;
        }

    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && dialogSystem.isNextSentence! && !isTalk)
        {
            chaImage.SetActive(false);
            readyToJudge.i++;
            isStop = true;
            player_Movement.speed = 7;
            //player_Movement.enabled = true;
            isTalk = true;
            boxCollider2Ds[0].enabled = true;
            boxCollider2Ds[1].enabled = true;
            boxCollider2Ds[2].enabled = true;
            boxCollider2Ds[3].enabled = true;
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
