using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    int count = 0;
    public Text scoreText;
    [SerializeField] GameObject coinPref;
    [SerializeField] GameObject bigCoinPref;
    private static GameManager instance;
    [SerializeField] AudioSource aSrc;
    [SerializeField] AudioClip aClip;
    //[SerializeField] float minX, maxX, minY, maxY;
    public static GameManager Instance { get { return instance; } }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(instance);
        }
        aSrc = GetComponent<AudioSource>();

    }
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(instantiateCoins(2f));
        //StartCoroutine(instantiateBigCoins(10f));

    }

    // Update is called once per frame
    void Update()
    {

    }
    /*IEnumerator instantiateCoins(float timeInterval)
    {
        while (true)
        {
            Instantiate(coinPref, new Vector2(Random.Range(minX, maxX), Random.Range(minY, minY)), Quaternion.identity);
            
            yield return new WaitForSeconds(timeInterval);

        }
    }
    IEnumerator instantiateBigCoins(float timeInterval)
    {
        while (true)
        {
            yield return new WaitForSeconds(timeInterval);
            Instantiate(bigCoinPref, new Vector2(Random.Range(8f, -8f), Random.Range(4f, -4f)), Quaternion.identity);

        }
    }*/
    public void CollectingCoins()
    {
        count++;
        scoreText.text = count.ToString();
        aSrc.clip = aClip;
        aSrc.Play();        // play coin sfx on collecting coin
    }
    public void CollectingBigCoins()
    {
        count+= 3;
        scoreText.text = count.ToString();
        aSrc.clip = aClip;
        aSrc.Play();        // play coin sfx on collecting coin
    }

    public void ApplicationQuit()
    {
        Application.Quit();
    }
}
