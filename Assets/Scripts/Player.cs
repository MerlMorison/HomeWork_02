using UnityEngine;
public class Player : Person
{
    private int experience;
    private int level;

    public Player(string NameID, int HP, int EXP) : base(NameID, HP)
    {
        experience = EXP;
        level = 1;
    }

    public int Experience
    {
        get { return experience; }
    }
    public int Level
    {
        get { return level; }
    }
    public override void ShowStat()
    {
        base.ShowStat();
        Debug.Log("________Experience: " + experience);
    }
    public override void TakeDamage(int damage)
    {
        Debug.Log("My name is " + DataName + ". After hitting with force: " + damage + " I have: health " + (DataHP - damage));
        DataHP -= damage;
        experience += 20;
        if (experience > 100)
        {
            Debug.Log("________Level UP! Your level - " + (level + 1) + "!");
            level++;
            experience = 0;
        }
    }
    private void Start()
    {

        Player player = GetComponent<Player>();
        if (player != null)
        {
            player.ShowStat();
        }
    }
}

