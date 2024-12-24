using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{

    public GameObject gameOverText;
    public GameObject SpikeBall;



    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("SpikeBall"))
        {
            Debug.Log("Collision");
            SceneManager.LoadScene("gameOverScene");
        }

        if (collision.gameObject.CompareTag("gool"))
        {
            SceneManager.LoadScene("resultScene");
        }
    }

}
