using DesignPattern.Patterns.FactoryPattern.Factory_Method;
using System;

namespace DesignPattern.Patterns.FactoryPattern.Factory_Method
{
    public interface IAbility
    {
        void UseAbility();
    }

    public enum AbilityType
    {
        fire, ice, slash, thrust
    }


    public class IceAbility : IAbility
    {
        public void UseAbility()
        {
            Console.WriteLine("Ice ability used");
        }
    }
    public class FireAbility : IAbility
    {
        public void UseAbility()
        {
            Console.WriteLine("Fire ability used");
        }
    }
    public class SlashAbility : IAbility
    {
        public void UseAbility()
        {
            Console.WriteLine("slash attack used");
        }
    }

    public class ThrustAbility : IAbility
    {
        public void UseAbility()
        {
            Console.WriteLine("thrust attack used");
        }
    }
}




    public interface IAbilityFactory
{
    IAbility CreateAbility(AbilityType abilityType);
}

public class ElementalAbilityFactory : IAbilityFactory
{
    public IAbility CreateAbility(AbilityType abilityType)
    {
        switch (abilityType)
        {
            case AbilityType.fire:
                return new FireAbility();
            case AbilityType.ice:
                return new IceAbility();
            default:
                return null;
        }
    }
}

public class PhysicalAbilityFactory : IAbilityFactory
{
    public IAbility CreateAbility(AbilityType abilityType)
    {
        switch (abilityType)
        {
            case AbilityType.slash:
                return new SlashAbility();
            case AbilityType.thrust:
                return new ThrustAbility();
            default:
                return null;
        }
    }
}


namespace DesignPattern.Patterns.FactoryPattern.Factory_Method
{
    public class FactoryMethodDemo
    {
        public void Run()
        {
            IAbilityFactory abilityFactory = new ElementalAbilityFactory();

            IAbility ability = abilityFactory.CreateAbility(AbilityType.fire);
            ability.UseAbility();

            ability = abilityFactory.CreateAbility(AbilityType.ice);
            ability.UseAbility();

            abilityFactory = new PhysicalAbilityFactory();
            ability = abilityFactory.CreateAbility(AbilityType.thrust);
            ability.UseAbility();

            ability = abilityFactory.CreateAbility(AbilityType.slash);
            ability.UseAbility();
        }
    }
}





namespace Patterns
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            FactoryMethodDemo factoryMethodDemo = new FactoryMethodDemo();
            factoryMethodDemo.Run();
        }
    }
}

// Above program outputs following
// Fire ability used
// Ice ability used
// thrust attack used
// slash attack used