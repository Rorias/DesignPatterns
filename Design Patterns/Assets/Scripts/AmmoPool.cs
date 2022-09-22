using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPool : MonoBehaviour
{
    #region singleton
    private static AmmoPool instance = null;
    public static AmmoPool Instance
    {
        get { return instance; }
    }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(gameObject);
    }
    #endregion

    public GameObject prefabBullet;
    public List<GameObject> ammoPool = new List<GameObject>();
    public int ammoCount;

    private void Start()
    {
        GenerateBullets(ammoCount);
    }

    private void GenerateBullets(int _baseBulletCount)
    {
        for (int i = 0; i < _baseBulletCount; i++)
        {
            GameObject bullet = Instantiate(prefabBullet);
            bullet.SetActive(false);
            ammoPool.Add(bullet);
        }
    }

    public GameObject RequestBullet()
    {
        foreach (var item in ammoPool)
        {
            if (!item.activeInHierarchy)
            {
                item.SetActive(true);
                return item;
            }
        }

        //if bulletpool is already used up but player needs new bullet anyway
        GameObject newBullet = Instantiate(prefabBullet);
        ammoPool.Add(newBullet);

        return newBullet;
    }
}
