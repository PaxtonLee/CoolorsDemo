using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public Color color1;
    public Color color2;
    public Color color3;
    public Color color4;
    public Color color5;
    public button startButton;

    // Start is called before the first frame update
    void Start()
    {
        color1 = new Color(0, 0, 0, 0);
        color2 = new Color(0, 0, 0, 0);
        color3 = new Color(0, 0, 0, 0);
        color4 = new Color(0, 0, 0, 0);
        color5 = new Color(0, 0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startButton()
    {
        startButton.setActive(false);
        StartCoroutine(LoadYourAsyncScene(Level1));
    }

    IEnumerator LoadYourAsyncScene(string Scene)
    {

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(Scene);

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
