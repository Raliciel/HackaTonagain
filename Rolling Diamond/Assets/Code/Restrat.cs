using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restrat : MonoBehaviour {
    public Transform Respawn;

    public void RestratScene()
    {
        SceneManager.LoadScene("TestLevel");
    }
}
