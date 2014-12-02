using System;
using System.Collections.Generic;
using System.Text;
using Supporting;
using AllEmployees;

namespace TheCompany
{
    /**
  * \class Container
  *
  *
  * \brief ...
  *
  * This class' purpose is to provide a container space for the data
  * that will be entering our program from the user, and ouputting to the user.
  * The container will be used to hold valid employee objects. Everytime the
  * container is modified the event will be logged using a logger.
  * Appropriate try catch blocks will be in place for any expected or unexpected failures.
  * This class will primarily deal with invalid data by bouncing the use back to the previous
  * screen and logging a failure.
  *
  * \note 
  *
  * \author (last to touch it) $Author: Brandon $
  *
  * \version $Revision: 1.0 $
  *
  * \date $Date: 2014/21/11 $
  *
  * Contact: brandon.d.davison@gmail.com
  *
  * Created on: Friday November 21 2014
  *
  * $Id: doxygen-howto.html,v 1.5 2005/04/14 14:16:20 bv Exp $
  *
  */
    public class Container
    {
        Logging logger = new Logging();
        static List<Employee> container = new List<Employee>();

        /** \brief verifyItem()
        *   \param string - record - an employee to be verified
        *   \return bool - success - represents the success condition upon exiting 
        *  /the method.
        * 
        *   This methods purpose is to take in an employee to be verified and validate its
        *   its contents to determine its validity as an employee.
        * 
        */
        public bool verifyItem(string record)
        {
            return true;
        }

        /** \brief loadDatabase()
        *   \param string - file - a file to pull from. If null, a default value is used.
        *   \return bool - success - represents the success condition upon exiting 
        *  /the method.
        * 
        *   This methods purpose is to load in a database from the suppot class, verify its
        *   contents, and add it to a local container.
        * 
        */
        public bool loadDatabase()
        {
            return true;
        }

        /** \brief saveContainer()
        *   \return bool - The success state
        * 
        *   This method's purpose is to convert each employee into a record to be saved.
        */
        public bool saveContainer(string file)
        {
            return true;
        }

        /** \brief addItem()
        *   \param Employee - emp - an employee to be added to the container
        *   \return bool - success - represents the success condition upon exiting 
        *  /the method.
        * 
        *   This methods purpose is to add an employee to the local container after it has been
        *   verified for validity
        * 
        */
        public bool addItem(string employee)
        {
            return true;
        }

        /** \brief removeItem()
        *   \param string - ID - an employee to be removed from the container
        *   \return bool - success - represents the success condition upon exiting 
        *  /the method.
        * 
        *   This methods purpose is to search for and remove an item in the local container.
        * 
        */
        public bool removeItem(string ID)
        {
            return true;
        }

        /** \brief modifyItem()
        *   \param string - ID - an employee to be removed from the container.
        *   \param string - field - the field the user wishes to modify.
        *   \param string - vale - the new value to be inserted into the employee. 
        *   \return bool - success - represents the success condition upon exiting 
        *  /the method.
        * 
        *   This methods purpose is to modify a field of an item in the local container.
        * 
        */
        public bool modifyItem(string ID, string field, string value)
        {
            return true;
        }

        /** \brief displayItem()
        *   \param int - itterate - an itterator indicating which employee to display.
        *   \return Employee - emp - an employee to be displayed.
        * 
        *   This method's purpose is to take in an iterator from the UI class and use it to
        *   return an employee to be displayed, allowing traversal.
        */
        public Employee displayItem(int itterate)
        {
            Employee emp = null;
            return emp;
        }
    }
}
