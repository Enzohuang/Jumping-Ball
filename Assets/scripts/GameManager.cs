using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float restartDelay = 1f;
    // Start is called before the first frame update
    public void EndGame()
    {
        Invoke("Restart", restartDelay);
    }

    public GameObject completeLevelUI;

     void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        //Debug.Log("fdsavsadbvdsagsdag");
    }
}
