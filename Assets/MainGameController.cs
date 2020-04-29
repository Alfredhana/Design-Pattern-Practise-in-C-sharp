using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ConcreteBuilder;
using ConcreteCommand;
using VisitorConcreteHuman;
using VisitorConcreteAction;
using ConcreteStatus;

[ExecuteInEditMode]
public class MainGameController : MonoBehaviour
{
    public Character target;
    public AI enemy;
    InputHandler inputHandler = new InputHandler();
    CommandProcessor commandProcessor = new CommandProcessor();

    private void Start()
    {

    }

    void Update()
    {
        enemy.Request();

        var direction = inputHandler.ReadInput();
        if (direction != Vector3.zero)
        {
            var moveCommand = new MoveCommand(target, direction);
            commandProcessor.ExecuteCommand(moveCommand);
        }

        if (inputHandler.ReadUndo())
        {
            commandProcessor.Undo();
        }


    }

    void TestVisitor()
    {
        ObjectStructure structure = new ObjectStructure();
        structure.Attach(new Man());
        structure.Attach(new Woman());

        Success success = new Success();
        structure.Display(success);

        Failing failing = new Failing();
        structure.Display(failing);

        Amativeness amativeness = new Amativeness();
        structure.Display(amativeness);
    }

    void TestConcreteFlyWeight()
    {
        ChessFactory factory = new ChessFactory();

        Chess whiteChess = factory.GetChess("White");
        whiteChess.Place(new Position(0f, 0f));

        Chess blackChess = factory.GetChess("Black");
        blackChess.Place(new Position(0f, 1f));

        Chess whiteChess1 = factory.GetChess("White");
        whiteChess1.Place(new Position(0f, 2f));

        Chess whiteChess2 = factory.GetChess("White");
        whiteChess2.Place(new Position(0f, 3f));

        Chess whiteChess3 = factory.GetChess("White");
        whiteChess3.Place(new Position(0f, 4f));
    }

    void TestFlyWeight()
    {
        FlyweightFactory factory = new FlyweightFactory();

        FlyWeight flyWeightX = factory.GetFlyweight("酷炫效果");
        flyWeightX.Operation();

        FlyWeight flyWeightY = factory.GetFlyweight("旋转效果");
        flyWeightY.Operation();

        FlyWeight flyWeightZ = factory.GetFlyweight("光影效果");
        flyWeightZ.Operation();

        FlyWeight flyWeightUnshared = new UnsharedConcreteFlyWeight("火焰效果");
        flyWeightUnshared.Operation();

        FlyWeight flyWeightM = factory.GetFlyweight("光影效果");
        flyWeightM.Operation();

        FlyWeight flyWeightN = factory.GetFlyweight("光影效果");
        flyWeightN.Operation();

        Debug.Log("Total number of fly weight : " + factory.GetFlyWeightCount());
    }

    void TestCommand()
    {
        // init
        
    }

    void TestBuilder()
    {
        MonsterBigBuilder bigMonster = new MonsterBigBuilder("Giant Tiger", 100, 100);
        Director monsterDirector = new Director();
        monsterDirector.CreateMonster(bigMonster);

        MonsterSmallBuilder smallMonster = new MonsterSmallBuilder("Small Bird", 100, 100);
        monsterDirector.CreateMonster(smallMonster);
    }

    void TestProxy()
    {
        Girl girl = new Girl();
        girl.Name = "Lu Cui Ru";

        Proxy proxy = new Proxy(girl);
        proxy.GiveDoll();
        proxy.GiveFlowers();
        proxy.GiveChocolate();
    }

    void TestDecorator()
    {
        Person component = new Person("Alfred");
        Debug.Log("First Clothes");

        Trouser trouser = new Trouser();
        TShirts tshirts = new TShirts();

        trouser.Decorate(component);
        tshirts.Decorate(trouser);
        tshirts.Show();

        Debug.Log("Second Clothes:");
        Sneaker sneaker = new Sneaker();
        Shoes shoes = new Shoes();

        sneaker.Decorate(component);
        shoes.Decorate(sneaker);
        shoes.Show();
    }

    void TestMemento()
    {
        // Initialize
        Boss boss = new Boss("Giant Bad Guy");
        boss.InitState();
        boss.StateDisplay();

        // Save Progress
        CareTaker careTaker = new CareTaker();
        careTaker.Memento = boss.SaveState();

        // Finish fight
        boss.FinishFight();
        boss.StateDisplay();

        boss.RecoverState(careTaker.Memento);
        boss.StateDisplay();
    }
    
    void TestObserver()
    {
        Secretary newSecretary = new Secretary();

        StockObserver stockGuy = new StockObserver("Stock Guy", newSecretary);
        NBAObserver nbaGuy = new NBAObserver("NBA Guy", newSecretary);

        newSecretary.Attach(stockGuy);
        newSecretary.Attach(nbaGuy);

        newSecretary.DeTach(stockGuy);

        newSecretary.Nofity();
    }

    void TestMonsterProtype()
    {
        Monster firstMonster = new Monster("Big bird");
        firstMonster.setMonsterInfo(10, 100);

        Monster secondMonster = (Monster)firstMonster.Clone();

        Monster thirdMonster = (Monster)firstMonster.Clone();

        secondMonster.Attack();
        firstMonster.Attack();
        thirdMonster.Attack();
    }
}
