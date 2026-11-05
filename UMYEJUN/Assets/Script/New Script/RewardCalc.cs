using UnityEngine;
using static UnityEngine.LowLevelPhysics2D.PhysicsLayers;

public class RewardCalc : MonoBehaviour
{
    public int playSeconds = 3725;
    public int gold = 1234;
    public int members = 4;
    public int kills = 7;
    public int expPerKill = 35;
    public int totalDamage = 250;
    public int hits = 20;
    public float expRate = 1.5f;


    [ContextMenu("정산 시스템")]
    void ShowStats()
    {
        int hour = playSeconds / 3600;
        int min = playSeconds / 60 % 60;
        int sec = playSeconds % 60;
        Debug.Log("플레이 시간 " + hour + "시간 " + min + "분 " + sec + "초");

        int a = (gold / members);
        int b = (gold % members);
        Debug.Log("1인당 " + a + "G" + ", 리더 보너스 " + b + "G");

        int c = (kills * expPerKill);
        int d = (int)(c * expRate);
        Debug.Log("경험치 " + d + " (기본 " + c + ")");

        int e = 1 + d / 100;
        int f = (int)(100 - (d % 100));
        Debug.Log("Lv " + e + " 다음 레벨 까지 " + f);

        Debug.Log("평균 데미지 " + (float)totalDamage / hits);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
