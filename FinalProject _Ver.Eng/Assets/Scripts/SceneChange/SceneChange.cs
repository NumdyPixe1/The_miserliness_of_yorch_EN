using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChange : MonoBehaviour
{
    public Animator animator;
    [SerializeField] private int SceneToLoad;

    public void FadeToNextScene()
    {
        FadeToScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void FadeToPreviousScene()
    {
        FadeToScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void FadeToLoadScene()
    {
        FadeToScene(0);

    }
    public void FadeToRoomScene0()
    {
        FadeToScene(5);

    }
    public void FadeToRoomScene1()
    {
        FadeToScene(7);

    }
    public void FadeToRoomScene2()
    {
        FadeToScene(8);

    }
    public void FadeToRoomScene3()
    {
        FadeToScene(9);

    }
    public void FadeToRoomScene4()
    {
        FadeToScene(10);

    }
    public void FadeToRoomScene5()
    {
        FadeToScene(11);

    }
    public void FadeToRoomScene6()
    {
        FadeToScene(12);

    }
    public void FadeToScene(int SceneIndex)
    {
        SceneToLoad = SceneIndex;
        animator.SetTrigger("FadeOut");
    }
    public void OnFadeComplete()//Fade ทำงานเสร็จแล้ว
    {
        SceneManager.LoadScene(SceneToLoad);
    }
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.D))
        // {
        //     FadeToNextScene();
        // }
        // if (Input.GetKeyDown(KeyCode.A))
        // {
        //     FadeToPreviousScene();
        // }
    }
}
