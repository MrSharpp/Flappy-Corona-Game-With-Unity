using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class endScreen : MonoBehaviour
{
 

    public void restartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        
    }

    private void Update()
    {
        if (Input.touchCount <= 0)
        {
            return;
        }
        StartCoroutine(HandleEndScreen());
    }

    private  IEnumerator  HandleEndScreen()
    {
        foreach (Touch touce in Input.touches)
        {
                if (Input.GetTouch(0).phase == TouchPhase.Began)
                {
                    yield return new WaitForSeconds(1f);
                    Time.timeScale = 1;
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                    
                }
        }
    }
}
