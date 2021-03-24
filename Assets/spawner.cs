using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawner : MonoBehaviour
{

    public float maxTime = 1;
    private float timer = 0;
    public GameObject pipe;
    public float height;
    public int score_count = 0;
    public Text score;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newpipe = Instantiate(pipe);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime)
        {
            timer = 0;
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-1f, 1.5f), 0);
            Destroy(newpipe, 15);
            score_count += 10;
            score.text = "Kill Score: " + score_count;

        }

        timer += Time.deltaTime;
    }
}
