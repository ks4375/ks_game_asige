using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class traning_script : MonoBehaviour {

    public static int Kisyo = 0;
	public static int Kisyo_Max = 50;
    public static int Speed_main = 20;
    public static int Stamina_main = 20;
    public static int Taiju = 500;
    public static int Week = 0;
	public static int Taiju_race = 500;

    private int tra01_zouka = 2;
    private int tra02_zouka = 2;
    private int tra03_zouka = 1;
    private int tra04_zouka = 1;

    private int _week, _kisyo, _kisyo_max, _speed_main, _stamina_main, _taiju,_taiju_race;

    public Text week_text, taiju_text, taiju_race;

    // Use this for initialization
    void Start () {
		_kisyo = 0;
		_kisyo_max = Kisyo_Max;
        _speed_main = Speed_main;
        _stamina_main = Stamina_main;
        _taiju = Taiju;
        _week = 0;
        week_text.text = "中" + _week.ToString() + "週";
		taiju_change();
}
	
	// Update is called once per frame
	void Update () {
		
	}
	void taiju_change(){
		_taiju_race = _taiju - Taiju_race;
		taiju_text.text = _taiju.ToString () + "kg";
		if (_taiju_race > 0) {
			taiju_race.text = "（ +" + _taiju_race.ToString () + "kg）";
		} else if (_taiju_race == 0) {
			taiju_race.text = "（ ±0kg ）";
		} else
			taiju_race.text = "（ " + _taiju_race.ToString () + "kg）";
	}
    
    void week_change()
    {
        _week++;
        if (_kisyo >= 10)
        {
            _kisyo = _kisyo - 5;
        }
        week_text.text = "中" + _week.ToString() + "週";
		taiju_change ();
    }

    public void tre01_siba()
    {
        _speed_main = _speed_main + tra01_zouka;
		if (_kisyo <= 100) {
			_kisyo_max = _kisyo_max + 2;
		}
        _taiju = _taiju - 4;
        week_change();
    }
    public void tre02_dirt()
    {
        _stamina_main = _stamina_main + tra02_zouka;
		if (_kisyo <= 100) {
			_kisyo_max = _kisyo_max + 2;
		}
        _taiju = _taiju - 4;
        week_change();
    }
    public void tre03_hanro()
    {
        _speed_main = _speed_main + tra03_zouka;
        _taiju = _taiju - 2;
        week_change();
    }
    public void tre04_wood()
    {
        _stamina_main = _stamina_main + tra04_zouka;
        _taiju = _taiju - 2;
        week_change();
    }
    public void tre05_yokusyu()
    {
        int taiju_rand = Random.Range(1,3) * 2;
        _taiju = _taiju + taiju_rand;
        week_change(); 
    }

    public void tre_06_race()
    {
		_kisyo = _kisyo_max - _kisyo;
        Kisyo = _kisyo;
		Kisyo_Max = _kisyo_max;
        Speed_main = _speed_main;
        Stamina_main = _stamina_main;
        Taiju = _taiju;
		Taiju_race = _taiju;
        Week = _week;
        SceneManager.LoadScene("select");
    }
}
