using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace DroneGame
{
    public class TimeTrial : MonoBehaviour
    {
        #region Variables
        public TextMeshProUGUI timeRemaining;
        public TextMeshProUGUI goalsRemaining;
        public TextMeshProUGUI highScore;
        private float timer = 0f;
        private bool timerActive = false;
        [SerializeField] private GameObject[] Goals = new GameObject[1];
        private int c = 0;
        #endregion

        #region Main Functions 
        // Start is called before the first frame update
        void Start()
        {
            timeRemaining.text = timer.ToString("F2");
            highScore.text = PlayerPrefs.GetFloat("HighScore", 200f).ToString("F2");
        }

        // Update is called once per frame
        void Update()
        {
            if (timerActive)
            {
                timer += Time.deltaTime;
                timeRemaining.text = timer.ToString("F2");
            }
        }

        private void OnTriggerEnter(Collider hit)
        {
            if (hit.gameObject == Goals[c])
            {
                if(c == 0)
                {
                    timer = 0f;
                    timerActive = true;
                }
                else if (c == 8)
                {
                    timerActive = false;
                    if (timer < PlayerPrefs.GetFloat("HighScore", 200f))
                    {
                        PlayerPrefs.SetFloat("HighScore", timer);
                        highScore.text = timer.ToString("F2");
                    }
                }
                c++;
                goalsRemaining.text = c + "/9";
                if(timerActive == false)
                {
                    c = 0;
                }
            }
            
        }
        #endregion

        #region Custom Functions
        #endregion
    }
}
