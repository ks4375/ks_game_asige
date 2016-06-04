using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour {

	public static int grade;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Scene_traning()
    {
        SceneManager.LoadScene("training");
    }

    public void Scene_countdown_OP()
    {
		grade = 0;
        SceneManager.LoadScene("countdown");
    }
	public void Scene_countdown_G3()
	{
		grade = 1;
		SceneManager.LoadScene("countdown");
	}
	public void Scene_countdown_G2()
	{
		grade = 2;
		SceneManager.LoadScene("countdown");
	}
	public void Scene_countdown_G1()
	{
		grade = 3;
		SceneManager.LoadScene("countdown");
	}
	public void Scene_countdown_SPG1()
	{
		grade = 4;
		SceneManager.LoadScene("countdown");
	}
}
