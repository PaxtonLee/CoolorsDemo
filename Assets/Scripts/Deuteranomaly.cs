using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.setColor1(new Color(242, 207, 27, 1));
        GameManager.Instance.setColor2(new Color(198, 106, 104, 1));
        GameManager.Instance.setColor3(new Color(50, 94, 158, 1));
        GameManager.Instance.setColor4(new Color(69, 121, 116, 1));
        GameManager.Instance.setColor5(new Color(255, 255, 255, 1));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
