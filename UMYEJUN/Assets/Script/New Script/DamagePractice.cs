using UnityEngine;

public class DamagePractice : MonoBehaviour
{

    public  int attack = 3;
    public int defense = 10;
    public bool isCritical = false;
    public bool targetIsBoss = false;

    [ContextMenu("데미지")]
    void Calc()
    {

        int damage = attack - defense;
        damage = Mathf.Max(damage, 1);
        if (isCritical)
        {
            damage = damage * 2;
        }
        if (targetIsBoss)
        {
            damage = damage / 2;
        }
        Debug.Log(damage);
    }




    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
