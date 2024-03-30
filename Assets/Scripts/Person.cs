using UnityEngine;

public abstract class Person : MonoBehaviour
{
    [SerializeField] private string objectName;
    [SerializeField] private int objectHP;

    protected Person(string NameID, int HP)
    {
        objectName = NameID;
        objectHP = HP;
    }

    protected string DataName { get { return objectName; } }


    private void Awake()
    {
        CheckHealthValue(objectHP);
    }


    public int DataHP
    {
        get { return objectHP; }
        set
        {
            CheckHealthValue(value);
        }
    }


    public virtual void ShowStat()
    {
        Debug.Log("________Name: " + objectName);
    }


    public abstract void TakeDamage(int damage);


    private void CheckHealthValue(int value)
    {
        if (value < 0 || value > 100)
        {
            Debug.Log("________Error: Некоректне значення здоров'я при старті гри. Здоров'я буде встановлено на значення за замовчуванням - 100.");
            objectHP = 100;
        }
        else
        {
            objectHP = value;
        }
    }
}