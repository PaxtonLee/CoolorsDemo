using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance { get; set; }

    public Color32 color1 = new Color32(255, 191, 0, 255);
    public Color32 color2 = new Color32(232, 63, 111, 255);
    public Color32 color3 = new Color32(34, 116, 165, 255);
    public Color32 color4 = new Color32(50, 147, 111, 255);
    public Color32 color5 = new Color32(255, 255, 255, 255);

    public GameObject startbutton;
    public GameObject creditsbutton;
    public GameObject titletext;

    public GameObject starttext;
    public GameObject creditstext;
    
    public GameObject canvas;
    public GameObject events;
    public GameObject background;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            DontDestroyOnLoad(canvas);
            DontDestroyOnLoad(events);
        }
        else
        {
            Destroy(gameObject);
            Destroy(canvas);
            Destroy(events);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        starttext.GetComponent<Text>().color = color1;
        creditstext.GetComponent<Text>().color = color1;
        titletext.GetComponent<TextMeshProUGUI>().color = color2;
        background.GetComponent<Image>().color = color3;
        startbutton.GetComponent<Image>().color = color4;
        creditsbutton.GetComponent<Image>().color = color4;
    }
    
    public void setColor1(Color newcolor)
    {
        color1 = newcolor;
    }

    public void setColor2(Color newcolor)
    {
        color2 = newcolor;
    }

    public void setColor3(Color newcolor)
    {
        color3 = newcolor;
    }

    public void setColor4(Color newcolor)
    {
        color4 = newcolor;
    }

    public void setColor5(Color newcolor)
    {
        color5 = newcolor;
    }

    public void startButton()
    {
        startbutton.SetActive(false);
        titletext.SetActive(false);
        StartCoroutine(LoadYourAsyncScene("Level1"));
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
