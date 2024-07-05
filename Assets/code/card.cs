public class Card
{
    public int id;//卡牌id
    public string cost;//消耗部位
    public string cardName;//卡牌名字

    //构造函数
    public Card(int _id, string _cost, string _cardName)
    {
        this.id = _id;
        this.cost = _cost;
        this.cardName = _cardName;
    }
}
//魔使卡牌
public class Familiar : Card
{
    public int attack;//攻击力
    public int startAttack;//初始攻击力
    public int hp;//生命值
    public int startHp;//初始生命值
    //构造函数
    public Familiar(int _id, string _cost, string _cardName, int _attack, int _hp) : base(_id, _cost, _cardName)
    {
        this.attack = _attack;
        this.startAttack = _attack;
        this.hp = _hp;
        this.startHp = _hp;
    }
}
//魔法卡牌
public class Magic : Card
{
    public string effect;//效果
    //构造函数
    public Magic(int _id, string _cost, string _cardName, string _effect) : base(_id, _cost, _cardName)
    {
        this.effect = _effect;
    }
}