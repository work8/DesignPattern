using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Example
{
    class FactoryMethodExample
    {
        static void Main(string[] args)
        {

        }
    }

    public interface Building{

         Unit makeUnit(string _unitType);
    }

    public class Barracks : Building
    {
        public Unit makeUnit(string _unitType)
        {
            if(_unitType.Equals("Marine"))
            return new Marine();
            if (_unitType.Equals("Firebat"))
                return new Firebat();
            return null;
        }
    }

    public class Starport : Building
    {
        public Unit makeUnit(string _unitType)
        {
            if (_unitType.Equals("DropShip"))
                return new DropShip();
            
            return null;
        }
    }




    public abstract class Unit
    {
        private string strName { get; set; }
        private string weaponType { get; set; }
        private int healthValue { get; set; }
        private int weaponDamage { get; set; }

    }

    public class Marine : Unit
    {

    }
    public class Firebat : Unit
    {

    }
    public class DropShip : Unit
    {

    }
}
