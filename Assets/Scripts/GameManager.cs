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
    public GameObject backbutton;
    public GameObject deuteranomalybutton;
    public GameObject protanomalybutton;
    public GameObject tritanomalybutton;
    public GameObject normalbutton;

    public GameObject credits;
    public GameObject titletext;
    public GameObject starttext;
    public GameObject creditstext;
    public GameObject backtext;
    public GameObject deuteranomalytext;
    public GameObject protanomalytext;
    public GameObject tritanomalytext;
    public GameObject normaltext;

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
        backtext.GetComponent<Text>().color = color1;
        deuteranomalytext.GetComponent<Text>().color = color1;
        protanomalytext.GetComponent<Text>().color = color1;
        tritanomalytext.GetComponent<Text>().color = color1;
        normaltext.GetComponent<Text>().color = color1;
        titletext.GetComponent<TextMeshProUGUI>().color = color2;
        credits.GetComponent<TextMeshProUGUI>().color = color2;
        background.GetComponent<Image>().color = color3;
        startbutton.GetComponent<Image>().color = color4;
        creditsbutton.GetComponent<Image>().color = color4;
        deuteranomalybutton.GetComponent<Image>().color = color4;
        protanomalybutton.GetComponent<Image>().color = color4;
        tritanomalybutton.GetComponent<Image>().color = color4;
        normalbutton.GetComponent<Image>().color = color4;
        backbutton.GetComponent<Image>().color = color4;
    }
    
    public void deuteranomaly()
    {
        color1 = new Color32(242, 207, 27, 255);
        color2 = new Color32(198, 106, 104, 255);
        color3 = new Color32(50, 94, 158, 255);
        color4 = new Color32(69, 121, 116, 255);
        color5 = new Color32(255, 255, 255, 255);
    }
        
    public void protanomaly()
    {
        color1 = new Color32(243, 212, 23, 255);
        color2 = new Color32(201, 119, 105, 255);
        color3 = new Color32(49, 88, 158, 255);
        color4 = new Color32(67, 114, 115, 255);
        color5 = new Color32(255, 255, 255, 255);
    }

    public void tritanomaly()
    {
        color1 = new Color32(252, 140, 34, 255);
        color2 = new Color32(226, 75, 102, 255);
        color3 = new Color32(36, 129, 156, 255);
        color4 = new Color32(53, 137, 117, 255);
        color5 = new Color32(255, 255, 255, 255);
    }

    public void normal()
    {
        color1 = new Color32(255, 191, 0, 255);
        color2 = new Color32(232, 63, 111, 255);
        color3 = new Color32(34, 116, 165, 255);
        color4 = new Color32(50, 147, 111, 255);
        color5 = new Color32(255, 255, 255, 255);
}

    public void startButton()
    {
        startbutton.SetActive(false);
        creditsbutton.SetActive(false);
        titletext.SetActive(false);
        background.SetActive(false);
        StartCoroutine(LoadYourAsyncScene("Level1"));
    }

    public void creditsButton()
    {
        startbutton.SetActive(false);
        creditsbutton.SetActive(false);
        titletext.SetActive(false);
        background.SetActive(false);
        credits.SetActive(true);
        backbutton.SetActive(true);
    }

    public void backButton()
    {
        startbutton.SetActive(true);
        creditsbutton.SetActive(true);
        titletext.SetActive(true);
        background.SetActive(true);
        credits.SetActive(false);
        backbutton.SetActive(false);
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
