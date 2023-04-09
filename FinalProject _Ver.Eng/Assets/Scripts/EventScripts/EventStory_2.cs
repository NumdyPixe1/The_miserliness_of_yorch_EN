using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventStory_2 : MonoBehaviour
{
    public EventStory_4 eventStory_4;
    public EventStory_3 eventStory_3;
    public bool isNext;
    public GameObject continueButton, continueArrow;

    public GameObject[] chaImage;
    public GameObject[] backGroundImager;
    public DialogSystem dialogSystem2;
    private void Awake()
    {
        GetComponent<EventStory_2>().enabled = false;
    }
    void Start()
    {
        eventStory_4.enabled = false;
        Debug.Log("Start EventStory_2");
        backGroundImager[0].SetActive(true);
        StartCoroutine(Wait());
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3f);
        chaImage[0].SetActive(true);
        dialogSystem2.StartDialog();

    }
    void Update()
    {
        if (dialogSystem2.index == 0)
        {
        }
        if (dialogSystem2.index == 1)
        {
            chaImage[1].SetActive(true);
            chaImage[0].SetActive(false);

        }
        if (dialogSystem2.index == 2)
        {
            chaImage[0].SetActive(true);
            chaImage[1].SetActive(false);

        }
        if (dialogSystem2.index == 3)
        {
            chaImage[0].SetActive(false);
            chaImage[1].SetActive(true);

        }

        if (Input.GetMouseButtonDown(0) & dialogSystem2.isStopTalking || Input.GetKeyDown(KeyCode.Space) & dialogSystem2.isStopTalking)
        {
            Debug.Log("OnMouseDown");
            chaImage[1].SetActive(false);
            eventStory_3.enabled = true;
            dialogSystem2.enabled = false;
        }
    }

}
