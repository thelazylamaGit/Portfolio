using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Attack : MonoBehaviour
{
    #region Vairables
    [SerializeField]private Transform firePoint = null;
    [SerializeField] private GameObject bulletPrefab = null;
    #endregion

    #region Main Functions
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    #endregion

    #region Custom Functions
    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
    #endregion
}
