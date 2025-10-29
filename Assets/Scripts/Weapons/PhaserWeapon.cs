using UnityEngine;
using System.Collections.Generic;

public class PhaserWeapon : MonoBehaviour
{
    public static PhaserWeapon Instance;
    // [SerializeField] private GameObject prefab;
    [SerializeField] private ObjectPooler bulletPool;

    public float speed;
    public float damage;


    void Awake(){
        if (Instance != null){
            Destroy(gameObject);
        } else {
            Instance = this;
        }
    }

    public void Shoot(){
        // Instantiate(prefab, transform.position, transform.rotation);
        GameObject bullet = bulletPool.GetPooledObject();
        bullet.transform.position = transform.position;
        bullet.SetActive(true);
    }
}
