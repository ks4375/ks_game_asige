using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class countdown_script : MonoBehaviour {

    public Text countdown;
    int count;
    int sec;

	// Use this for initialization
	void Start () {
        count = 3;
        countdown.text = count.ToString();
	}
	
    void count_a()
    {
        if (count > 0)
        {
            countdown.text = count.ToString();
        }
        else countdown.text = "GO!";
        if (count == -1)
        {
			SceneManager.LoadScene("main");
        }
    }

	// Update is called once per frame
	void Update () {
        sec++;
        if(sec >= 60)
        {
            count--;
            sec = 0;
            count_a();
        }
	
	}
}
