using System;
using System.Collections.Generic;
using System.Text;
using Supporting;

namespace AllEmployees
{
    /**
* \class Employee
*
*
* \brief ...
*
* This class' purpose is to provide a super type for an employee object. 
* This class represents what an employee can do, and the data pertaining to 
* the specfic employee.
* Appropriate try catch blocks will be in place for any expected or unexpected failures.
* This class will primarily only deal with basic data validation.
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
    public class Employee
    {
    }

    /**
* \class FullTimeEmployee
*
*
* \brief ...
*
* This class' purpose is to provide a sub type for an employee. 
* This class represents an employee that works full time within
* the system.
* Appropriate try catch blocks will be in place for any expected or unexpected failures.
* This class will primarily only deal with basic data validation.
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
    public class FullTimeEmployee : Employee
    {
    }

    /**
* \class PartTimeEmployee
*
*
* \brief ...
*
* This class' purpose is to provide a sub type for an employee. 
* This class represents an employee that works part time within
* the system.
* Appropriate try catch blocks will be in place for any expected or unexpected failures.
* This class will primarily only deal with basic data validation.
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
    public class PartTimeEmployee : Employee
    {
    }

    /**
* \class ContractEmployee
*
*
* \brief ...
*
* This class' purpose is to provide a sub type for an employee. 
* This class represents an employee that is working under a contract.
* Contract employees only work for the time that is specified in 
* their contract.
* Appropriate try catch blocks will be in place for any expected or unexpected failures.
* This class will primarily only deal with basic data validation.
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
    public class ContractEmployee : Employee
    {
    }

    /**
* \class SeasonalEmployee
*
*
* \brief ...
*
* This class' purpose is to provide a sub type for an employee. 
* This class represents an employee that works seasonally within the
* system.
* Appropriate try catch blocks will be in place for any expected or unexpected failures.
* This class will primarily only deal with basic data validation.
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
    public class SeasonalEmployee : Employee
    {
    }
}
