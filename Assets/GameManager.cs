using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject Character;
    public GameObject Spawner;
    public GameObject Particles;
    public GameObject Overlay;
    public Text scoreText;
    public Text startGameText;
    public Image GameName;
    public Text credit;
    public Text credit2;
    public Text scoreTexte;

    private void Awake()
    {
        Character.GetComponent<Rigidbody2D>().gravityScale = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        scoreTexte.text = Spawner.gameObject.GetComponent<spawner>().score_count.ToString();

        if (Input.touchCount <= 0)
        {
            return;
        }
                if (Input.GetTouch(0).phase == TouchPhase.Began)
                {
                    IninitializeGame();
                }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        IninitializeGame();
    }

    public void IninitializeGame()
    {
        Particles.SetActive(true);
        GameName.gameObject.SetActive(false);
        startGameText.enabled = false;
        credit.gameObject.SetActive(false);
        credit2.gameObject.SetActive(false);
        scoreText.gameObject.SetActive(true);
        Overlay.SetActive(false);
        Character.GetComponent<Rigidbody2D>().gravityScale = 2;
        Character.GetComponent<CoronaCharacterMovement>().enabled = true;
        Character.GetComponent<CoronaMovement>().enabled = true;
        Spawner.SetActive(true);
    }


}
