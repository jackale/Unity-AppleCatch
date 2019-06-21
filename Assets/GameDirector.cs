using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject timeText;
    GameObject pointText;
    float time = 30.0f;
    int point = 0;
    // Start is called before the first frame update
    void Start()
    {
        this.timeText = GameObject.Find("Time");
        this.pointText = GameObject.Find("Point");
    }

    // Update is called once per frame
    void Update()
    {
        this.time -= Time.deltaTime;
        this.timeText.GetComponent<Text>().text =
            this.time.ToString("F1");
        this.pointText.GetComponent<Text>().text =
            this.point.ToString() + " Point";
    }

    public void GetApple()
    {
        this.point += 100;
    }

    public void GetBomb()
    {
            this.point /= 2;
    }
}
