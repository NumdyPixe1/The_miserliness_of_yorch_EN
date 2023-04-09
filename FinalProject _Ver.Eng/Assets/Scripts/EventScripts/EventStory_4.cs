using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventStory_4 : MonoBehaviour
{
    public GameObject continueButton, continueArrow;
    public bool isNext;
    public EventStory_2 eventStory_2;
    public GameObject backGroundImager;

    public EventStory_1 eventStory_1;
    private void Awake()
    {
        GetComponent<EventStory_4>().enabled = false;
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1f);
        continueArrow.SetActive(true);
        continueButton.SetActive(true);
        isNext = true;
    }
    void Start()
    {
        eventStory_1.enabled = false;
        Debug.Log("Start EventStory_1.5");
        backGroundImager.SetActive(true);
        StartCoroutine(Wait());
    }
    public void Update()
    {
        if (Input.GetMouseButtonDown(0) & isNext || Input.GetKeyDown(KeyCode.Space) & isNext)
        {
            Debug.Log("OnMouseDown");
            Destroy(this.backGroundImager);
            continueArrow.SetActive(false);
            StartCoroutine(WaitEvent2());
        }
    }
    IEnumerator WaitEvent2()
    {
        yield return new WaitForSeconds(1f);
        eventStory_2.enabled = true;
    }
}
