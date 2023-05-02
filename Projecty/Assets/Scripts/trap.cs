using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap : MonoBehaviour
{
    public Animator animator;
    public GameObject GameOver;
    public Animator animator2;

    // Start is called before the first frame update
    void Start()
    {
        GameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            animator.SetBool("death", true);
            GameOver.SetActive(true);
            Time.timeScale = 1;
            animator.SetBool("GameOver", true);

        }
    }
}
