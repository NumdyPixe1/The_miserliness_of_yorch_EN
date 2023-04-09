using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventStory_0 : MonoBehaviour
{
    public EventStory_1 eventStory_1;
    public SceneChange sceneChange;
    public bool isNextScene;
    bool test;
    public bool isNext;
    public GameObject[] backGroundImager;
    public GameObject continueButton, continueArrow;
    public Animator animator;
    private void Awake()
    {
        backGroundImager[0].SetActive(false);
        backGroundImager[1].SetActive(false);
        backGroundImager[2].SetActive(true);

    }
    void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(Wait());
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2.1f);
        continueButton.SetActive(true);
        continueArrow.SetActive(true);
        backGroundImager[0].SetActive(true);
    }
    public void OnMouseDown()
    {
        Debug.Log("OnMouseDown");
        isNext = true;
        if (isNextScene)
        {
            //sceneChange.FadeToNextScene();
            eventStory_1.enabled = true;
            backGroundImager[0].SetActive(false);
            backGroundImager[1].SetActive(false);
            backGroundImager[2].SetActive(false);
        }
    }

    void Update()
    {
        if (isNext)
        {
            isNext = false;
            backGroundImager[0].SetActive(false);
            backGroundImager[1].SetActive(true);
            isNextScene = true;
        }

        //Test
        // if (dialogSystem.index == 3)//เมื่อถึงบทพูดบรรทัดที่ 3
        // {
        //     chaImagerHolder[1].SetActive(true);
        //     backGroundImager[0].SetActive(false);//ปิด BG อันที่ 1
        //     //Debug.Log("ChageBackGroud");
        // }
        // if (dialogSystem.isStopTalking == true)
        // {
        //     chaImagerHolder[1].SetActive(false);
        // }
    }
}
