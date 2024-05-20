using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public string scenename;

    void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            SceneManager.LoadScene(scenename);
        }
    }
}
