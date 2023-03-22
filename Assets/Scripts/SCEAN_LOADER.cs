using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SCEAN_LOADER : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void ReloadScean()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
