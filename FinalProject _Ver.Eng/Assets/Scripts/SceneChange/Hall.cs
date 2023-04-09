using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hall : MonoBehaviour
{
    public SceneChange sceneChange;
    [SerializeField] private bool isNextScene;
    private void OnTriggerEnter2D(Collider2D other)//เมื่อเข้าใน BoxCollider2D
    {
        if (other.gameObject.tag == "Player")
        {
            sceneChange.FadeToRoomScene6();
            isNextScene = true;
            //sceneChange.FadeToNextScene();
        }
    }
    private void OnTriggerExit2D(Collider2D other) //เมื่อออกจาก BoxCollider2D
    {
        if (other.gameObject.tag == "Player")
        {
            isNextScene = false;
        }
    }
}
