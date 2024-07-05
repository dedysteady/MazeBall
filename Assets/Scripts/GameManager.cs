using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Player _player;
    public GameObject heart3;
    public GameObject heart2;
    public GameObject heart1;
    public GameObject panelGagal;
    public GameObject PanelLolos;
    public AudioClip lose;
    public AudioClip win;
    public AudioClip bomb;
    public AudioClip getLive;

    private AudioSource player;

    public int _level;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<AudioSource>();

        if (_level == 1)
        {
            heart3.SetActive(true);
            heart2.SetActive(true);
            heart1.SetActive(true);
        }
        if (_level == 2)
        {
            _player.Live = PlayerPrefs.GetInt("save");
        }


    }

    // Update is called once per frame
    void Update()
    {
        Lives();
        Lolos();
        getLives();

    }

    void Lives()
    {
        if (_player.Live == 0)
        {
            heart3.SetActive(false);
            heart2.SetActive(false);
            heart1.SetActive(false);
            Debug.Log("GameOver");
            PlayBomb();
            Gagal();
        }
        if (_player.Live == 1)
        {
            heart3.SetActive(true);
            heart2.SetActive(false);
            heart1.SetActive(false);
            PlayBomb();
            Debug.Log(1);
        }
        if (_player.Live == 2)
        {
            heart3.SetActive(true);
            heart2.SetActive(true);
            heart1.SetActive(false);
            PlayBomb();
            Debug.Log(2);
        }
        if (_player.Live == 3)
        {
            heart3.SetActive(true);
            heart2.SetActive(true);
            heart1.SetActive(true);
            PlayBomb();
            Debug.Log(3);
        }
    }
    void Gagal()
    {
        if (_player.Live == 0)
        {
            panelGagal.SetActive(true);
            PlayLose();
        }
    }

    void Lolos()
    {
        if (_player._lolos == true && _level == 1)
        {
            StartCoroutine(_loading());
            PanelLolos.SetActive(true);
            PlayerPrefs.SetInt("save", _player.Live);
            PlayWin();

            IEnumerator _loading()
            {
                yield return new WaitForSeconds(2);
                SceneManager.LoadScene(2);
                _level++;

            }
        }
        if (_player._lolos == true && _level == 2)
        {
            StartCoroutine(_loading2());
            PanelLolos.SetActive(true);
            PlayWin();

            IEnumerator _loading2()
            {
                yield return new WaitForSeconds(2);
                _level++;

            }
        }
    }

    void getLives()
     {
            if(_player._getLives == true)
            {
                PlaygetLive();
                heart3.SetActive(true);
                heart2.SetActive(true);
                heart1.SetActive(true);
            }
    }

    public void PlayLose()
    {
        player.PlayOneShot(lose);
    }

    public void PlayWin()
    {
        player.PlayOneShot(win);
    }
    public void PlayBomb()
    {
        player.PlayOneShot(bomb);
    }

    public void PlaygetLive()
    {
        player.PlayOneShot(getLive);
    }
}
