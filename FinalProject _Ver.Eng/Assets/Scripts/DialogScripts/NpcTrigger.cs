using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcTrigger : MonoBehaviour
{
    public BoxCollider2D[] boxCollider2D;
    public Player_Movement player_Movement;
    public DialogSystem dialogSystem;
    public GameObject chaImagerHolder, panel;
    public bool isTalk;
    public AudioSource audioSource;
    private void Awake()
    {

        panel.SetActive(false);
        chaImagerHolder.SetActive(false);
    }
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        //EventCharacter eventCharacter = FindObjectOfType<EventCharacter>(); 
    }
    public void OnMouseUp()
    {
        if (isTalk)
        {
            audioSource.Play();
            player_Movement.speed = 0;
            panel.SetActive(true);
            chaImagerHolder.SetActive(true);
            Debug.Log("istalk");
            dialogSystem.StartDialog();
            isTalk = false;
            boxCollider2D[0].enabled = false;
            // boxCollider2D[1].enabled = false;

        }
    }
    private void Update()
    {

    }

    public void Close()
    {
        player_Movement.speed = 7;
        Debug.Log("isn't talk");
        panel.SetActive(false);
        chaImagerHolder.SetActive(false);
        isTalk = true;
        boxCollider2D[0].enabled = true;
        boxCollider2D[1].enabled = true;
        boxCollider2D[2].enabled = true;
        boxCollider2D[3].enabled = true;
        // player_Movement.speed = 7;
        // Debug.Log("isn't talk");
        // panel.SetActive(false);
        // chaImagerHolder.SetActive(false);
        // isTalk = true;
        // boxCollider2D[0].enabled = true;
        //boxCollider2D[1].enabled = true;
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
