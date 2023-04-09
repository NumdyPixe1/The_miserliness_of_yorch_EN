using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrevScene : MonoBehaviour
{
    public SceneChange sceneChange;
    [SerializeField] private bool isPrevScene;

    void Start()
    {


    }
    private void OnTriggerEnter2D(Collider2D other)//เมื่อเข้าใน BoxCollider2D
    {
        if (other.gameObject.tag == "Player")
        {
            isPrevScene = true;
            sceneChange.FadeToPreviousScene();
        }
    }
    private void OnTriggerExit2D(Collider2D other) //เมื่อออกจาก BoxCollider2D
    {
        if (other.gameObject.tag == "Player")
        {
            isPrevScene = false;
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isPrevScene == true)//เมื่อกด F และ isWarp เป็นจริง
        {
            sceneChange.FadeToPreviousScene();
            Debug.Log("PrevScene");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//เปลี่ยนฉาก
        }
    }
}
