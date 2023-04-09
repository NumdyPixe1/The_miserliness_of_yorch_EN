using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventStory_1 : MonoBehaviour
{
    public EventStory_2 eventStory_2;
    public EventStory_4 eventStory_4;

    public GameObject[] chaImage;

    public bool isNext;

    public GameObject continueButton, continueArrow;
    public GameObject[] backGroundImager;
    public DialogSystem dialogSystem1;
    public AudioSource audioSource;
    private void Awake()
    {
        GetComponent<EventStory_1>().enabled = false;

    }
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Debug.Log("Start EventStory_1");
        backGroundImager[0].SetActive(true);
        backGroundImager[1].SetActive(true);
        StartCoroutine(Wait());
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1f);
        dialogSystem1.StartDialog();
    }
    void Update()
    {
        if (dialogSystem1.index == 0)
        {
            chaImage[0].SetActive(true);
        }
        if (dialogSystem1.index == 1)
        {
            chaImage[0].SetActive(false);
            chaImage[1].SetActive(true);
        }
        if (dialogSystem1.index == 3)
        {
            chaImage[1].SetActive(false);
            chaImage[2].SetActive(true);

        }
        if (Input.GetMouseButtonDown(0) & dialogSystem1.isStopTalking || Input.GetKeyDown(KeyCode.Space) & dialogSystem1.isStopTalking)
        {
            audioSource.Play();
            Debug.Log("Fire");
            Destroy(this.chaImage[2]);
            Destroy(this.backGroundImager[1]);
            eventStory_4.enabled = true;
            dialogSystem1.enabled = false;
        }

    }

}
