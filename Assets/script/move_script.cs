using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class move_script : MonoBehaviour {

	public float speed;
    public Camera _setCamera;

    int taiju_best = 480;
    //Margin
    float margin = 0.2f; //マージン(画面外に出てどれくらい離れたら消えるか)を指定
    float negativeMargin;

    int _speed, _stamina, _kisyo, _taiju, _week;
    int _speed_a, _stamina_a, _kisyo_a, _taiju_a, _week_a;
    float _speed_b, _stamina_b;

	int timer;

    void Start()
    {
		timer = 0;

        //競走馬スペック

        _speed = traning_script.Speed_main;
        _stamina = traning_script.Stamina_main;
        _kisyo = traning_script.Kisyo;
        _taiju = traning_script.Taiju;
        _week = traning_script.Week;

        _speed_a = _speed;
        _stamina_a = _stamina;

        if (_week >= 13)
        {
            _kisyo_a = _kisyo / 2;
        }
        else _kisyo_a = _kisyo;

        _taiju_a = taiju_best - _taiju;
        Mathf.Abs(_taiju_a);
        _stamina_a = _stamina_a - _taiju_a * 4;

        _speed_b = (float)_speed_a;     //デフォルト20;
        _stamina_b = (float)_stamina_a;

		/*if ((100 - _kisyo_a) >= 0) {
			_speed_b = _speed_b *((100.0f - _kisyo_a) / 100.0f);
		} else
			_speed_b = _speed_b * (_kisyo_a / 100.0f);
		*/
        _speed_b = _speed_b / 1000.0f;

        if (_setCamera == null)
        {
            _setCamera = Camera.main;
        }

        negativeMargin = 0 - margin;

    }

    // Update is called once per frame
    void Update () {

		_stamina_b -= 0.05f;
		if (_stamina_b <= 0.0f) {
			_speed_b = _speed_b / 2.0f;
		}


        if (this.isOutOfScreen())
        {
			_taiju = _taiju - 4;
			traning_script.Taiju = _taiju;
            SceneManager.LoadScene("result");
        }
        if(transform.position.y >= 40.0f)
        {
			_taiju = _taiju - 4;
			_speed = _speed + 2;
			traning_script.Taiju = _taiju;
			traning_script.Speed_main = _speed;
			traning_script.Kisyo_Max += 2;
            SceneManager.LoadScene("result2");
        }
		if (distance_script.flg == 1) {
			timer++;
			if (timer >= 120) {
				timer = 0;
				_taiju = _taiju - 4;
				_speed = _speed + 2;
				traning_script.Taiju = _taiju;
				traning_script.Speed_main = _speed;
				traning_script.Kisyo_Max += 2;
				SceneManager.LoadScene ("result2");
			}
		}

        transform.position = new Vector3 (
			transform.position.x + Input.GetAxis("Horizontal") * speed,
			transform.position.y + _speed_b,
			0.0f
		);
	
	}
    bool isOutOfScreen()
    {
        Vector3 positionInScreen = _setCamera.WorldToViewportPoint(transform.position);
        positionInScreen.z = transform.position.z;

        if (positionInScreen.y <= negativeMargin)
        {
            return true;
        }
        else {
            return false;
        }
    }
}
