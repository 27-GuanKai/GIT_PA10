using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class scorescript : MonoBehaviour
{
    public float score;
    public Text Scoretext;
    // Start is called before the first frame update
    private void Awake()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
            Scoretext.GetComponent<Text>().text = ("Score: " + score);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "wall")
        {
            Debug.Log("Score");
            score++;
            Scoretext.GetComponent<Text>().text = ("Score: " + score);
        }
    }
    private void FixedUpdate()
    {
        GameObject.FindGameObjectsWithTag("wall");
    }
}
