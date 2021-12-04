using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private bool hasLanded;
    [SerializeField] private bool thrown;
    [SerializeField] private float boostedForce = 5.0f;
    [SerializeField] private float maxTorque = 13.0f;
    [SerializeField] private float minSpeed = 25.0f;
    [SerializeField] private float maxSpeed = 8.0f;
    public int diceValue;
    public DiceSide[] diceSides;
    //GameObjects
    public GameObject dice1Soldier;
    public GameObject dice2Soldier;
    public GameObject dice3Soldier;
    public GameObject dice4Soldier;
    public GameObject dice5Soldier;
    public GameObject dice6Soldier;
    public GameObject win;
    
  
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(RandomForce(), ForceMode.Force);
        rb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);
        rb.AddForce(Physics.gravity, ForceMode.Acceleration);
    }

    private void Update()
    {
       

        if (rb.IsSleeping() && !hasLanded && thrown && win.GetComponent<Win>().gameOver == false)
        {
            hasLanded = true;
            RollDice();
            SideValueCheck1();
            SideValueCheck2();
        }     
    }
    public void RollDice()
    {
        if(!thrown && !hasLanded)
        {
            thrown = true;
        }
    }
    float RandomTorque()
    {
        return Random.Range(-maxTorque, maxTorque);
    }
    Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }

    public void SideValueCheck1()
    {
        diceValue = 0;
        foreach (DiceSide side in diceSides)
        {
            if(side.Onground() && !side.OnAddGainGround())
            {
                diceValue = side.sideValue;
                Debug.Log(diceValue + " has been rolled!");
                    
                switch(diceValue)
                {
                    case 1:
                        Debug.Log("1 prefab");
                        Vector3 scaleChange1 = new Vector3(1.0f, 1.0f, 1.0f);
                        dice1Soldier.transform.localScale = scaleChange1;
                        dice1Soldier.transform.Translate(Vector3.forward * Time.deltaTime * boostedForce, Space.World);
                        Instantiate(dice1Soldier, transform.position, Quaternion.identity);                           
                        break;
                    case 2:
                        Debug.Log("2 prefab");
                        Vector3 scaleChange2 = new Vector3(1.0f, 1.0f, 1.0f);
                        dice2Soldier.transform.localScale = scaleChange2;
                        dice2Soldier.transform.Translate(Vector3.forward * Time.deltaTime * boostedForce, Space.World);
                        Instantiate(dice2Soldier, transform.position, Quaternion.identity);
                        break;
                    case 3:
                        Debug.Log("3 prefab");
                        Vector3 scaleChange3 = new Vector3(1.0f, 1.0f, 1.0f);
                        dice3Soldier.transform.localScale = scaleChange3;
                        dice3Soldier.transform.Translate(Vector3.forward * Time.deltaTime * boostedForce, Space.World);
                        Instantiate(dice3Soldier, transform.position, Quaternion.identity);    
                        break;
                    case 4:
                        Debug.Log("4 prefab");
                        Vector3 scaleChange4 = new Vector3(1.0f, 1.0f, 1.0f);
                        dice4Soldier.transform.localScale = scaleChange4;
                        dice4Soldier.transform.Translate(Vector3.forward * Time.deltaTime * boostedForce, Space.World);
                        Instantiate(dice4Soldier, transform.position, Quaternion.identity);   
                        break;
                    case 5:
                        Debug.Log("5 prefab");
                        Vector3 scaleChange5 = new Vector3(1.0f, 1.0f, 1.0f);
                        dice5Soldier.transform.localScale = scaleChange5;
                        dice5Soldier.transform.Translate(Vector3.forward * Time.deltaTime * boostedForce, Space.World);
                        Instantiate(dice5Soldier, transform.position, Quaternion.identity);         
                        break;
                    case 6:
                        Debug.Log("6 prefab");
                        Vector3 scaleChange6 = new Vector3(1.0f, 1.0f, 1.0f);
                        dice6Soldier.transform.localScale = scaleChange6;
                        dice6Soldier.transform.Translate(Vector3.forward * Time.deltaTime * boostedForce, Space.World);
                        Instantiate(dice6Soldier, transform.position, Quaternion.identity);
                        break;
                }
            }

          
        }
    }

    public void SideValueCheck2()
    {
        diceValue = 0;
        foreach (DiceSide side in diceSides)
        {
            if (side.OnAddGainGround())
            {
                diceValue = side.sideValue;
                Debug.Log(diceValue + " has been rolled!");
                switch (diceValue)
                {
                    case 1:
                        Debug.Log("1 prefab SCALED");
                        Vector3 scaleChange1 = new Vector3(1.0f, 2.0f, 1.0f);
                        dice1Soldier.transform.localScale = scaleChange1;
                        dice1Soldier.transform.Translate(Vector3.forward * Time.deltaTime * boostedForce*2, Space.World);
                        Instantiate(dice1Soldier, transform.position, Quaternion.identity);
                        break;
                    case 2:
                        Debug.Log("2 prefab SCALED");
                        Vector3 scaleChange2 = new Vector3(1.0f, 2.0f, 1.0f);
                        dice2Soldier.transform.localScale = scaleChange2;
                        dice2Soldier.transform.Translate(Vector3.forward * Time.deltaTime * boostedForce*2, Space.World);
                        Instantiate(dice2Soldier, transform.position, Quaternion.identity);
                        break;
                    case 3:
                        Debug.Log("3 prefab SCALED");
                        Vector3 scaleChange3 = new Vector3(1.0f, 2.0f, 1.0f);
                        dice3Soldier.transform.localScale = scaleChange3;
                        dice3Soldier.transform.Translate(Vector3.forward * Time.deltaTime * boostedForce*2, Space.World);
                        Instantiate(dice3Soldier, transform.position, Quaternion.identity);
                        break;
                    case 4:
                        Debug.Log("4 prefab SCALED");
                        Vector3 scaleChange4 = new Vector3(1.0f, 2.0f, 1.0f);
                        dice4Soldier.transform.localScale = scaleChange4;
                        dice4Soldier.transform.Translate(Vector3.forward * Time.deltaTime * boostedForce*2, Space.World);
                        Instantiate(dice4Soldier, transform.position, Quaternion.identity);
                        break;
                    case 5:
                        Debug.Log("5 prefab SCALED");
                        Vector3 scaleChange5 = new Vector3(1.0f, 2.0f, 1.0f);
                        dice5Soldier.transform.localScale = scaleChange5;
                        dice5Soldier.transform.Translate(Vector3.forward * Time.deltaTime * boostedForce*2, Space.World);
                        Instantiate(dice5Soldier, transform.position, Quaternion.identity);
                        break;
                    case 6:
                        Debug.Log("6 prefab SCALED");
                        Vector3 scaleChange6 = new Vector3(1.0f, 2.0f, 1.0f);
                        dice6Soldier.transform.localScale = scaleChange6;
                        dice6Soldier.transform.Translate(Vector3.forward * Time.deltaTime * boostedForce*2, Space.World);
                        Instantiate(dice6Soldier, transform.position, Quaternion.identity);
                        break;

                }
            }
        }
    }

}
