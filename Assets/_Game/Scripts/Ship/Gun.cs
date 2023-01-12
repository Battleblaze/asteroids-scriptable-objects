using System;
using UI;
using UnityEngine;

namespace Ship
{
    public class Gun : MonoBehaviour
    {
        [SerializeField] private Laser _laserPrefab;

        private UIscript _uIscript;

        private void Start()
        {
            _uIscript = GameObject.Find("UI").GetComponent<UIscript>();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                Shoot();
        }
        
        private void Shoot()
        {
            
            var trans = transform;
            Instantiate(_laserPrefab, trans.position, trans.rotation);
            _uIscript.SetLaserText(_uIscript.lasersshot += 1);
        }
    }
}
