using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuHandler : MonoBehaviour {

    public void StartButtonPressed()
    {
        SceneManager.LoadScene("game");
    }

}
