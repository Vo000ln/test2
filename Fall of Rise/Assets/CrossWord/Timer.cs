
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] public float time;
    [SerializeField] public Text timerText;
    public AudioSource source;
    public AudioClip clip;
    //для проигрыша по времени
    public GameObject end;
    //дефолт
    public GameObject defaultt;
    private float _timeLeft = 0f;

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
        if(_timeLeft == 0f)
        {
            source.PlayOneShot(clip);
            //defaultt.SetActive(false);
            end.SetActive(true);
            StartCoroutine(Coroutine_time_end());
        }
    }

    IEnumerator Coroutine_time_end()
    {
        yield return new WaitForSecondsRealtime(7);
        //SceneManager.LoadScene("14Frame");
    }
}