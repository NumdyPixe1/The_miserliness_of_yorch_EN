using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ReadyToJudge : MonoBehaviour
{
    public DialogSystem[] dialogSystems;
    public GameObject DialogCan;
    public BoxCollider2D[] boxCollider2D;
    public bool isEnd = false;
    public bool isNext = false;
    public bool badEnd = false;
    public bool goodEnd = false;
    public bool hide = false;
    public GameObject[] paper;
    public Player_Movement player_Movement;
    public GameObject select, panel, selectText, BG, continueButtonEnd, continueArrow, gameOver;
    public GameObject[] End;
    public int i = 0;
    public SceneChange sceneChange;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && i >= 5)
        {
            //Destroy(DialogCan);
            DialogCan.SetActive(false);
            player_Movement.speed = 0;
            boxCollider2D[0].enabled = false;
            boxCollider2D[1].enabled = false;
            boxCollider2D[2].enabled = false;
            boxCollider2D[3].enabled = false;
            boxCollider2D[4].enabled = false;
            select.SetActive(true);
            panel.SetActive(true);
            selectText.SetActive(true);
        }
        // if (i >= 5 || dialogSystems[0].isNextSentence! || dialogSystems[1].isNextSentence! || dialogSystems[2].isNextSentence! || dialogSystems[3].isNextSentence! || dialogSystems[4].isNextSentence!)
        // {
        //     player_Movement.speed = 0;
        //     npcTrigger2[0].enabled = false;
        //     npcTrigger2[1].enabled = false;
        //     npcTrigger2[2].enabled = false;
        //     npcTrigger2[3].enabled = false;
        //     npcTrigger2[4].enabled = false;
        //     select.SetActive(true);
        //     panel.SetActive(true);
        //     selectText.SetActive(true);
        // }
        if (hide)
        {
            select.SetActive(false);
            panel.SetActive(false);
            selectText.SetActive(false);
            BG.SetActive(true);
            continueButtonEnd.SetActive(true);
            continueArrow.SetActive(true);

        }


    }
    public void OnMouseUp()
    {
        if (goodEnd)//ผ่าน
        {
            paper[0].SetActive(false);
            Debug.Log("paper close");
            End[0].SetActive(true);
            StartCoroutine(Wait1());
        }
        if (goodEnd && isNext)
        {
            Debug.Log("End2");
            End[1].SetActive(true);
            StartCoroutine(Wait2());
        }
        if (goodEnd && isNext && isEnd)
        {
            sceneChange.FadeToLoadScene();
        }
        if (badEnd)
        {
            gameOver.SetActive(true);
            paper[1].SetActive(false);
            paper[2].SetActive(false);
            paper[3].SetActive(false);
            paper[4].SetActive(false);
            StartCoroutine(Wait2());
        }
        if (badEnd && isEnd)
        {
            sceneChange.FadeToLoadScene();
        }

    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1.5f);



    }
    IEnumerator Wait1()
    {
        yield return new WaitForSeconds(0.5f);
        isNext = true;
    }
    IEnumerator Wait2()
    {
        yield return new WaitForSeconds(0.5f);
        isEnd = true;
    }


    public void Simon()
    {
        goodEnd = true;
        hide = true;
        paper[0].SetActive(true);
        paper[1].SetActive(false);
        paper[2].SetActive(false);
        paper[3].SetActive(false);
        paper[4].SetActive(false);
        //continueArrow.SetActive(true);
    }
    public void Canteen()
    {
        badEnd = true;
        paper[0].SetActive(false);
        paper[1].SetActive(true);
        paper[2].SetActive(false);
        paper[3].SetActive(false);
        paper[4].SetActive(false);

        hide = true;


    }
    public void Rainey()
    {
        badEnd = true;
        paper[0].SetActive(false);
        paper[1].SetActive(false);
        paper[2].SetActive(false);
        paper[3].SetActive(true);
        paper[4].SetActive(false);

        hide = true;

    }

    public void Samuel()
    {
        badEnd = true;
        paper[0].SetActive(false);
        paper[1].SetActive(false);
        paper[2].SetActive(true);
        paper[3].SetActive(false);
        paper[4].SetActive(false);

        hide = true;

    }
    public void Scarlet()
    {
        badEnd = true;
        paper[0].SetActive(false);
        paper[1].SetActive(false);
        paper[2].SetActive(false);
        paper[3].SetActive(false);
        paper[4].SetActive(true);

        hide = true;

    }
}
