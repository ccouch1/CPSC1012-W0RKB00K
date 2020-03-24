using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDataMembers
{
    public class Animals
    {
        /*
 * declare the class level varibles
 * these variables are private
 * and managed by the internal
 * methods of the class
 * 
 * the enum is a list of references
 * which reflect a value.
 */
        public enum SpeciesStatus
        {
            Viable = 0,
            Concerned = 1,
            Threatened = 2,
            Endangered = 3,
            Extinct = 4
        }

        /*
         * data members
         */

        private string _Type;
        private Int32 _Population;
        private SpeciesStatus _Status;
        /*
 * special methods whos sole propose 
 * is to store
 * or retreive values from the 
 * data members are called properties
 *
 * These methods have 2 components
 * call get and set.
 *
 * most data members will have a get
 * the set could be done elsewhere
 */



        public string Type
        {
            get //retreive
            {
                return _Type;
            }
            set //store
            {
                _Type = value;
            }
        }
        public Int32 Population
        {
            get //retreive
            {
                return _Population;
            }
        }

        public SpeciesStatus Status
        {
            get //retreive
            {
                return _Status;
            }
        }
        /*
 * class methods will do more than
 * simply set or get data member values
 * (which is the responsibility of the
 *  class properties)
 *  
 * These methods are sometimes referred
 * to as "action" methods
 */
        public void RecordPopulation(Int32 inPopulation)
        {
            _Population = inPopulation;
            /*
             * Status is dependent on the population
             */
            if (inPopulation > 1000000)
            {
                _Status = SpeciesStatus.Viable;
            }
            else
            {
                if (inPopulation > 500000)
                {
                    _Status = SpeciesStatus.Concerned;
                }
                else
                {
                    if (inPopulation > 250000)
                    {
                        _Status = SpeciesStatus.Threatened;
                    }
                    else
                    {
                        if (inPopulation > 100000)
                        {
                            _Status = SpeciesStatus.Endangered;
                        }
                        else
                        {
                            _Status = SpeciesStatus.Extinct;
                        }
                    }
                }
            }
        }



    }
}
