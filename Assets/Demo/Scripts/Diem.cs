using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Diem : MonoBehaviour
{
    public PlayerShoot playerShoot { get; private set; }

    public TextMeshProUGUI diem;
    public Text TimeGame;
    public int _diem = 0;
    public float _time = 0f;
    private bool hasCollided = false;
    public ScoreData diemLuu;
    public GameObject UiLose;

    public bool dead => playerShoot.enabled;

    // Start is called before the first frame update
    void Start()
    {
        diem.SetText(_diem.ToString());
        playerShoot = GetComponent<PlayerShoot>();
    }

    // Update is called once per frame
    void Update()
    {
        
        _time += Time.deltaTime;
        TimeGame.text = "Time: " + _time.ToString("00") + "giây";
    }
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            diemLuu.Score++;
            _diem+=1;
            diem.SetText(_diem.ToString());
        }

        if (other.gameObject.CompareTag("Block"))
        {
            diemLuu.Score++;
            _diem += 2;
            diem.SetText(_diem.ToString());
            if (!hasCollided)
            {
                hasCollided = true;
            }
        }
        if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
            Time.timeScale = 0;
            UiLose.SetActive(true);
        }
        if (other.gameObject.CompareTag("Flower"))
        {
            playerShoot.enabled = true;
        }
    }
}
