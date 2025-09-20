public class Unit
{
    public string Name{get;}
    public float Health=>@health;
    public int Damage{get;}
    public float Armor{get;}
    private float @health;

    public Unit():this("Unknown Unit"){
    }
    public Unit(string name)
    {
        Name = name;
        @health = 100f;
        Damage = 5;
        Armor = 0.6f;
    }
    public float GetRealHealth()
    {
        return @health * (1f + Armor);
    }
    public bool SetDamage(float damage){
        @health -= damage * (1f - Armor);
        return @health <= 0f;
    }
}
