using System;
using DefaultNamespace.ScriptableEvents;
using TMPro;
using UnityEngine;
using Variables;

namespace UI
{
    public class UIscript : MonoBehaviour
    {
        [Header("Health:")]
        [SerializeField] private IntVariable _healthVar;
        [SerializeField] private TextMeshProUGUI _healthText;
        [SerializeField] private ScriptableEventIntReference _onHealthChangedEvent;
        
        [Header("Score:")]
        [SerializeField] private TextMeshProUGUI _scoreText;
        
        [Header("Timer:")]
        [SerializeField] private TextMeshProUGUI _timerText;
        
        [Header("Laser:")]
        [SerializeField] private TextMeshProUGUI _laserText;

        public int score = 0;
        public int lasersshot;
        
        private void Start()
        {
            SetHealthText($"Health: {_healthVar.Value}");
        }

        private void Update()
        {
            SetTimerText();
        }

        public void OnHealthChanged(IntReference newValue)
        {
            SetHealthText($"Health: {newValue.GetValue()}");
        }

        private void SetHealthText(string text)
        {
            _healthText.text = text;
        }
        
        public void SetScoreText(int scoreint)
        {
            _scoreText.text = "Asteroids Destoyed:" + scoreint.ToString();
        }
        
        public void SetTimerText()
        {
            _timerText.text ="Time: " + Convert.ToInt32(Time.timeSinceLevelLoad);
        }
        
        public void SetLaserText(int laserint)
        {
            _laserText.text = "Lasers Shot: " + laserint.ToString();
        }
    }
}
