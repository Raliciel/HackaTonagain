using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restrat : MonoBehaviour {

    public void RestratScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
