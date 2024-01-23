using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    public scorescript ss;
    public GameObject obstacle;
    public Rigidbody rb;
    public float jump;
    private Animation thisAnimation;

    void Start()
    {
        thisAnimation = GetComponent<Animation>();
        thisAnimation["Flap_Legacy"].speed = 3;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Jump");
            rb.velocity = Vector3.zero;
            rb.AddForce(new Vector3(0, jump, 0));
            thisAnimation.Play();
        }
        if (this.transform.position.y <= -3.7f)
        {
            Debug.Log("Lose");
            SceneManager.LoadScene("GameLose");
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == ("wall"))
        {
            Debug.Log("Lose");
            SceneManager.LoadScene("GameLose");
        }
    }
}
