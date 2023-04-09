using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventStory_3 : MonoBehaviour
{
    public SceneChange sceneChange;
    public EventStory_2 eventStory_2;
    public bool isNextScene;

    public bool isNext;
    public GameObject continueButton, continueArrow;

    public GameObject[] chaImage;
    public GameObject[] backGroundImager;
    public DialogSystem dialogSystem3;
    private void Awake()
    {
        GetComponent<EventStory_3>().enabled = false;
    }
    void Start()
    {
        eventStory_2.enabled = false;
        Debug.Log("Start EventStory_3");
        backGroundImager[0].SetActive(true);
        StartCoroutine(Wait());
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3f);
        dialogSystem3.StartDialog();
        chaImage[0].SetActive(true);

    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0) & dialogSystem3.isStopTalking || Input.GetKeyDown(KeyCode.Space) & dialogSystem3.isStopTalking)
        {
            Debug.Log("OnMouseDown");
            backGroundImager[1].SetActive(true);
            StartCoroutine(WaitEvent2());
            Destroy(this.chaImage[0]);

        }
        if (Input.GetMouseButtonDown(0) & isNextScene || Input.GetKeyDown(KeyCode.Space) & isNextScene)
        {
            sceneChange.FadeToNextScene();
        }
    }
    IEnumerator WaitEvent2()
    {
        yield return new WaitForSeconds(0.5f);
        isNextScene = true;
        continueArrow.SetActive(true);

    }


}
