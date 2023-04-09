using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextScene : MonoBehaviour
{
    public SceneChange sceneChange;
    [SerializeField] private bool isNextScene;

    void Start()
    {


    }
    private void OnTriggerEnter2D(Collider2D other)//เมื่อเข้าใน BoxCollider2D
    {
        if (other.gameObject.tag == "Player")
        {
            isNextScene = true;
            sceneChange.FadeToNextScene();

        }
    }
    private void OnTriggerExit2D(Collider2D other) //เมื่อออกจาก BoxCollider2D
    {
        if (other.gameObject.tag == "Player")
        {
            isNextScene = false;
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isNextScene == true)
        {
            sceneChange.FadeToNextScene();
            Debug.Log("NextScene");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//เปลี่ยนฉาก
        }
    }
    public void On_Click()
    {
        // sceneChange.FadeToNextScene();
        // Debug.Log("NextScene");
    }
}
