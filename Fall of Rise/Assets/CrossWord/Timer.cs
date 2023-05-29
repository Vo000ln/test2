
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] public float time;
    [SerializeField] public Text timerText;
    //public AudioSource source;
    //public AudioClip clip;
    //��� ������������ ������ �� 5 ����� ��
    public GameObject audio;
    //��� ��������� �� �������
    public GameObject canvas_end;
    //������
    public GameObject defaultt;
    private float _timeLeft = 0f;

    bool once = true;

    private IEnumerator StartTimer()
    {
        while (_timeLeft > 0)
        {
            _timeLeft -= Time.deltaTime;
            UpdateTimeText();
            yield return null;
        }
    }

    private void Start()
    {
        _timeLeft = time;
        StartCoroutine(StartTimer());
    }

    private void UpdateTimeText()
    {
        if (_timeLeft < 0)
            _timeLeft = 0;

        float minutes = Mathf.FloorToInt(_timeLeft / 60);
        float seconds = Mathf.FloorToInt(_timeLeft % 60);
        timerText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
        if(_timeLeft < 5 && once)
        {
            //source.PlayOneShot(clip); //�������� �� 5 ������
            audio.SetActive(true);
            once = false;
            //defaultt.SetActive(false);
            //end.SetActive(true);
            //StartCoroutine(Coroutine_time_end());
        }
        if(_timeLeft == 0f)
        {
            audio.SetActive(false);
            StartCoroutine(Coroutine_time_end());
        }
    }

    IEnumerator Coroutine_time_end()
    {
        if (DataClass.gender == "M")
            DataClass.final_anim = 3; //������ �������� ���.
        else
            DataClass.final_anim = 4; //������ �������� ���.
        //�������� ���������� ��� �������� �� ����� �����
        canvas_end.SetActive(true);
        yield return new WaitForSecondsRealtime(2.9f);
        SceneManager.LoadScene("Final");
    }
}