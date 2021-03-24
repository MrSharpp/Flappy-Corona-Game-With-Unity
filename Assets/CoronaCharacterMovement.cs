using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoronaCharacterMovement : MonoBehaviour
{
    public GameObject UI;
    public AudioSource GameDie;
    public AudioSource GameMusic;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0) return;
        transform.Rotate(transform.rotation.x, transform.rotation.y, transform.rotation.z + 2);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Time.timeScale = 0;
        GameDie.Play();
        GameMusic.Stop();
        UI.SetActive(true);

    }
}
